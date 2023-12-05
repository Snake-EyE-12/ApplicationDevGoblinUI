using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Invest : Pickup
{
    public Invest(int index, string _name, int _value) : base(_name, _value, index)
    {
    }
    public override void Gather(Player player)
    {
        player.AddCoins(value);
    }
}