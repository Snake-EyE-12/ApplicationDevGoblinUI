using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Heal : Pickup
{
    bool max = false;
    public Heal(int index, string _name, int _value, bool max) : base(_name, _value, index)
    {
        this.max = max;
    }
    public override void Gather(Player player)
    {
        player.heal(value, max);
    }
}