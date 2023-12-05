using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace GoblinsAttack;
// TODO:
//Close windows on exit

// Current error seems to be a binding problem
//
public static class Game
{
    static private Player player = null;
    static private MapManager map = new MapManager();
    static private int encounters = 0;
    static private string[] blankAttackNames = { "Wait", "Air Punch", "Breathe", "Intimidate", "Stink Eye" };
    static public Fight fight = new Fight();
    static private Pickup[] rewards = new Pickup[2];
    static public bool gameWon = false;
    public static void Load()
    {
        map.ChangeState(MapState.Intro);
    }
    public static void confirmPlayer(int health, int damage, int magic, int stealth, CharacterClass type)
    {
        gameWon = false;
        Assets.enemies[3].getAttacks()[1].SetOwner(Assets.enemies[3]);
        player = new Player(type, Math.Max(health, 1), Math.Max(damage, 1), Math.Max(magic, 1), Math.Max(stealth, 1));
        player.setAttacks(getCharacterAttacks(type, player));
        changeEncounter();
        
    }
    public static int getEncounterNumber()
    {
        return encounters;
    }
    public static int getPlayerCoins()
    {
        return player.coins;
    }
    public static void changeEncounter()
    {
        if (encounters >= Assets.enemies.Length)
        {
            gameWon = true;
            map.ChangeState(MapState.Over);
            return;
        }
        fight.enemy = Assets.enemies[encounters];
        fight.dialogue = fight.enemy.getMessage();
        string test = fight.dialogue.getResponsesAsStrings().First();
        UIData.SetHealthAmounts(player.getHealth(), fight.enemy.getHealth(), true);
        map.ChangeState(MapState.Dialogue);
        encounters++;
    }
    public static bool respondToDialogue(int response)
    {
        if (fight.dialogue.getResponses()[response].getNextMessage() == null)
        {
            map.ChangeState(MapState.Fight);
            fight.playerTurn = true;
            return false;
        }

        fight.dialogue = fight.dialogue.getResponses()[response].getNextMessage();
        return true;
    }
    public static MessageDialogue getCurrentDialogue()
    {
        if (fight.dialogue == null)
        {
            map.ChangeState(MapState.Fight);
            fight.playerTurn = true;
        }
        return fight.dialogue;
    }
    public static bool playerAttemptedAttack(int index)
    {
        if (!fight.playerTurn)
        {
            UIData.setNarration("It Is Not Your Turn!");
            return false;
        }
        if (player.Attack(index, fight.enemy))
        {
            fight.playerTurn = false;
            UIData.SetHealthAmounts(player.getHealth(), fight.enemy.getHealth());
            return true;
        }
        return false;
        

    }
    public static void opponentAttack()
    {

        if (fight.playerTurn) return;
        if(fight.enemy.getHealth() <= 0)
        {
            fightComplete();
            return;
        }
        fight.enemy.Attack(0, player);
        UIData.SetHealthAmounts(player.getHealth(), fight.enemy.getHealth());
        if (player.getHealth() <= 0)
        {
            playerDied();
        }
        fight.playerTurn = true;
        foreach(Attack attack in player.getAttacks())
        {
            attack.DecrementCooldown();
        }
    }
    private static void playerDied()
    {
        map.ChangeState(MapState.Over);
    }
    private static void fightComplete()
    {
        for(int i = 0; i < 2; i++)
        {
            rewards[i] = Assets.pickups[Random.Shared.Next(Assets.pickups.Length)];
        }
        map.ChangeState(MapState.Reward);
        UIData.setRewards(rewards);
    }
    public static void pickReward(int which)
    {
        rewards[which - 1].Gather(player);

    }

    public static Player getPlayer()
    {
        return player;
    }
    public static void Reset()
    {
        map.ChangeState(MapState.Intro);
        encounters = 0;
        player = null;
        fight.playerTurn = true;
        Assets.Reset();
        PlayerCreationManager.Reset();
    }
    








    
    private static Attack[] getCharacterAttacks(CharacterClass type, Character player)
    {
        List<Attack> attacks = new List<Attack>();
        switch (type)
        {
            case CharacterClass.Dwarf:
                {
                    attacks.Add(new SingleDamage(player, "Axe Throw", "Better watch out!", 1, 1));
                    attacks.Add(new SingleDamage(player, "Chop", "Big Damage!", 3, 3));
                    attacks.Add(new Block(player, "Sheild Up", "Attempt to block.", 1, 3));
                    break;
                }
            case CharacterClass.Druid:
                {
                    attacks.Add(new SingleDamage(player, "Vine Grab", "Made with love.", 1, 1));
                    attacks.Add(new SingleDamage(player, "Snap", "Crack of the whip.", 3, 3));
                    attacks.Add(new MagicDamage(player, "Whisper", "Talk to the animals.", 3, 1, true));
                    break;
                }
            case CharacterClass.Human:
                {
                    attacks.Add(new SingleDamage(player, "Smack", "Back and forth.", 1, 1));
                    attacks.Add(new SingleDamage(player, "Beat Up", "Left then right.", 2, 2));
                    break;
                }
            case CharacterClass.Elf:
                {
                    attacks.Add(new SingleDamage(player, "Snipe", "What a shot!", 3, 4));
                    attacks.Add(new Block(player, "Arm Raise", "Attempt to block.", 2, 5));
                    attacks.Add(new MagicDamage(player, "Wonder", "Peak into their minds!", 1, 2, false));

                    break;
                }
            case CharacterClass.Goblin:
                {
                    attacks.Add(new SingleDamage(player, "Slice", "A dagger in action!", 1, 1));
                    attacks.Add(new MoneyChanger(player, "Steal", "Take their gold.", 3, 3));
                    attacks.Add(new SingleDamage(player, "Double Slice", "Slice slice slice!", 5, 5));
                    break;
                }
        }
        int count = attacks.Count;
        for(int i = 0; i < 4 - count; i++)
        {
            attacks.Add(new Blank(player, blankAttackNames[Random.Shared.Next(0, blankAttackNames.Count())], "A little bit of nothing.", 0));
        }
        return attacks.ToArray();
    }
}
