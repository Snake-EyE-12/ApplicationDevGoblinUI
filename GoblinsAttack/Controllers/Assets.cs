using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAttack;

public static class Assets
{
    static Response[] fight = { new Response("It shall be a fight!", null) };

    static Response[] fightInstead = { new Response("Agreed.", null) };
    static MessageDialogue oldTimesFight = new MessageDialogue("Lets duel like old times!", fightInstead);
    static MessageDialogue questionToFight = new MessageDialogue("Ok, how about we fight instead?", fightInstead);
    static Response[] notAChatter = { new Response("Nope.", questionToFight), new Response("Let us duel instead!", null) };
    static MessageDialogue chatterToday = new MessageDialogue("Not much for chatting today are you?", notAChatter);
    static Response[] helloFriend = { new Response("Hello!", chatterToday), new Response("Greetings old friend.", oldTimesFight) };
    static MessageDialogue friendsUnite = new MessageDialogue("Hello friend, I have been waiting for you!", helloFriend);

    static MessageDialogue goblinCharge = new MessageDialogue("The coin is mine!", fight);
    static Response[] myOwnCoin = { new Response("You are a trickster, fight me now!", null), new Response("Fine", goblinCharge) };
    static MessageDialogue theGoblinCoin = new MessageDialogue("No, you must flip one of yours.", myOwnCoin);
    static MessageDialogue notSoFair = new MessageDialogue("We must duel for it!", fightInstead);
    static Response[] fairCoin = { new Response("That does not sound fair.", notSoFair), new Response("Ok, do you have a coin to flip.", theGoblinCoin) };
    static MessageDialogue noShareGoblin = new MessageDialogue("Let us flip a coin. Tails, I win, Heads, you lose!", fairCoin);
    static MessageDialogue notWealthy = new MessageDialogue("Let me pick those pockets and find out!", fight);
    static Response[] lookingWealthy = { new Response("I am not.", notWealthy), new Response("That does not mean I will share with a Goblin.", noShareGoblin) };
    static MessageDialogue firstGoblin = new MessageDialogue("You look wealthy!", lookingWealthy);

    static Response[] youStupid = { new Response("Unbelievable!", null) };
    static MessageDialogue answeredAMightyFighter = new MessageDialogue("No, you stupid!", youStupid);
    static Response[] smellFaceRiddle = { new Response("You will die for your sarcasm!", null), new Response("A mighty fighter?", answeredAMightyFighter) };
    static MessageDialogue answerARiddle = new MessageDialogue("Ok, what has a smelly face and two eyes staring at me?", smellFaceRiddle);
    static Response[] shallNotPass = { new Response("Wispers: I must try.", null), new Response("What if I answer a riddle?", answerARiddle) };
    static MessageDialogue firstTroll = new MessageDialogue("You Shall Not Pass!", shallNotPass);

    static MessageDialogue noTinyBlob = new MessageDialogue("I don't have time for you, you tiny fool.", fight);
    static MessageDialogue catTongue = new MessageDialogue("Cat got your tongue.", fight);
    static Response[] okBud = { new Response("...", catTongue), new Response("I can take you in a fight!", null), new Response("Do you not belive me?", noTinyBlob), new Response("Don't temp me!", null) };
    static Response[] justShrek = { new Response("Haha, prepare to die!", null), new Response("Do not pretend to be someone you are not!", null) };
    static MessageDialogue mightyFighter = new MessageDialogue("Ok bud.", okBud);
    static MessageDialogue iAmShrek = new MessageDialogue("Shrek.", justShrek);
    static Response[] whoAreYou = { new Response("The mighty fighter of the nearest town.", mightyFighter), new Response("Who are you?", iAmShrek) };
    static MessageDialogue firstShrek = new MessageDialogue("Who are you?", whoAreYou);


    static Attack[] friendAttacks =
    {
        new Blank(null, "Wave", "A simple form of hello.", 0),
        new SingleDamage(null, "Cut", "The slice of a knife.", 0, 1)
    };
    static Attack[] goblinAttacks =
    {
        new Blank(null, "Smile", "With yellow teeth.", 0),
        new SingleDamage(null, "Jab", "The rust will hurt.", 0, 1),
        new MoneyChanger(null, "Steal", "Poverty reached.", 0, 2)
    };
    static Attack[] trollAttacks =
    {
        new SingleDamage(null, "Punch", "The moldy fist.", 0, 1),
        new SingleDamage(null, "Club", "Beaten by the club.", 0, 2),
        new SingleDamage(null, "Pound", "Into the ground.", 0, 4)
    };
    static Attack[] shrekAttacks =
    {
        new Blank(null, "Yell", "Onions have layers!", 0),
        new Block(null, "Pick up", "To the back you go.", 0, 3),
        new SingleDamage(null, "Roar", "Ears wiggling.", 0, 9)
    };
    public static Enemy[] enemies =
    {
        new Enemy(CharacterClass.Human, 5, 1, friendAttacks, friendsUnite),                   // 0
        new Enemy(CharacterClass.Goblin, 9, 1, goblinAttacks, firstGoblin),                   // 1
        new Enemy(CharacterClass.Goblin, 16, 1, trollAttacks, firstTroll),                    // 2
        new Enemy(CharacterClass.Goblin, 23, 1, shrekAttacks, firstShrek)                     // 3
    };

    public static Pickup[] pickups =
    {
        new Heal(0, "Healthy Potion", 1, true),
        new Heal(1, "Heal", 3, false),
        new Invest(2, "Coin Pile", 6),
        new Invest(3, "Coin", 1)
    };

    public static void Reset()
    {
        foreach (Enemy enemy in enemies)
        {
            enemy.Reset();
        }
    }
}
