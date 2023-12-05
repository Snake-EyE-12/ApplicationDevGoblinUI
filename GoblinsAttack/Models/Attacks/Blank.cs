using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Blank : Attack
{
    public Blank(Character owner, string attackName, string description, int cooldown) : base(owner, attackName, description, cooldown)
    {
    }

    public override string Use(Character target)
    {
        return (attackName);
    }
}
