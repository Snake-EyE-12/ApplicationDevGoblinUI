using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MoneyChanger : Attack
{
    private int count;
    public MoneyChanger(Character owner, string attackName, string description, int cooldown, int count) : base(owner, attackName, description, cooldown)
    {
        this.count = count;
    }

    public override string Use(Character target)
    {
        if(target is Player)
        {
            (target as Player).AddCoins(-count);
            cooldownTimer = -1;
            return (attackName + " - Stealing " + count + " Coin");
        }
        else if(owner is Player)
        {
            (owner as Player).AddCoins(CalculateValue());
            return (attackName + " - Stealing " + count + " Coin");
        }
        return (attackName + " - Failed");
    }
    public override int CalculateValue()
    {
        if(owner is Player)
        {
            Player player = (owner as Player);
            return (count * player.getStealth() / 10) + player.getStealth();
        }
        return count;
        
    }
    public override string GetDescription()
    {
        string text = base.GetDescription();
        int steal = CalculateValue();
        if (steal > 0) text += "Steals " + steal + " coin.\n";
        return text;
    }
}