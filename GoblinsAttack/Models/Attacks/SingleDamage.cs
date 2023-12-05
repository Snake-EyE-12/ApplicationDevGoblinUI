using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SingleDamage : Attack
{
    private int value;
    public SingleDamage(Character owner, string attackName, string description, int cooldown, int value) : base(owner, attackName, description, cooldown)
    {
        this.value = value;
    }

    public override string Use(Character target)
    {
        int damage = CalculateValue();
        if(target != null && target.block > 0)
        {
            target.block = Math.Max(target.block - damage, 0);

        }
        else target.takeDamage(damage);
        cooldownTimer = -1;
        return (attackName + " - Attacking For " + damage + " Damage");
    }
    public override int CalculateValue()
    {
        if (owner == null) return value;
        return (value * owner.getDamage() / 10) + owner.getDamage();
    }
    public override string GetDescription()
    {
        string text = base.GetDescription();
        int damage = CalculateValue();
        if (damage > 0) text += "Hits for " + damage + " damage.\n";
        return text;
    }
}
