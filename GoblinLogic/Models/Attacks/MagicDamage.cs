using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicDamage : Attack
{
    private int value;
    private bool multiply;
    public MagicDamage(Character owner, string attackName, string description, int cooldown, int value, bool multiply) : base(owner, attackName, description, cooldown)
    {
        this.value = value;
        this.multiply = multiply;
    }

    public override string Use(Character target)
    {
        int damage = CalculateValue();
        target.takeDamage(damage);
        cooldownTimer = -1;
        return (attackName + " - Attacking For " + damage + " Damage");
    }
    public override int CalculateValue()
    {
        if (owner == null) return value;
        return (value * (owner as Player).getMagic() * (multiply ? owner.getDamage() : 1) );
    }
    public override string GetDescription()
    {
        string text = base.GetDescription();
        int damage = CalculateValue();
        if (damage > 0) text += "Hits for " + damage + " magic damage.\n";
        return text;
    }
}
