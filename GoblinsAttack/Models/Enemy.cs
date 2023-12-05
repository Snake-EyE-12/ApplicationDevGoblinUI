using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy : Character
{
    private MessageDialogue message;
    private int attackMarker = 0;

    public Enemy(CharacterClass characterClass, int health, int damage, Attack[] attacks, MessageDialogue dialogueStart) : base(characterClass, health, damage, attacks)
    {
        message = dialogueStart;
    }
    public MessageDialogue getMessage()
    {
        return message;
    }
    public override bool Attack(int index, Character opponent)
    {
        UIData.setNarration(attacks[attackMarker].Use(opponent), false);
        attackMarker++;
        if(attackMarker >= attacks.Count()) attackMarker = 0;
        return true;
    }
    public void Reset()
    {
        attackMarker = 0;
        health = maxHealth;
        block = 0;
    }
}