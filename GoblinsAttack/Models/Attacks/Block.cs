using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Block : Attack
{
    private int value;
    private bool blockedIt;
    public Block(Character owner, string attackName, string description, int cooldown, int value) : base(owner, attackName, description, cooldown)
    {
        this.value = value;
    }

    public override int CalculateValue()
    {
        blockedIt = false;
        if (owner is Player)
        {
            if ((Random.Shared.Next(11) < (owner as Player).getStealth()))
            {
                blockedIt = true;
                return (value * (owner as Player).getStealth() / 10) + owner.getDamage();
            }
            else return 0;
        }
        else if(owner == null)
        {
            blockedIt = true;
        }
        return value;
    }
    public int CalculateValueNoChance()
    {
        if (owner is Player)
        {
             return (value * (owner as Player).getStealth() / 10) + owner.getDamage();
             
        }
        
        return value;
    }

    public override string GetDescription()
    {
        string text = base.GetDescription();
        int block = CalculateValueNoChance();
        if (block > 0) text += "Blocks for " + block + ".\n";
        return text;
    }

    public override string Use(Character target)
    {
        int block = CalculateValue();
        owner.block = block;
        cooldownTimer = -1;
        if(blockedIt || owner == null || (owner is Enemy) && block != 0)
        {
            return (attackName + " - Blocking For " + block + ".");
        }
        return (attackName + " - Block Failed.");
    }
}