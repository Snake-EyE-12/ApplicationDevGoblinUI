using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pickup
{
    protected string name;
    protected int value;
    public int index;
    public Pickup(string _name, int _value, int index) {
        this.name = _name;
        this.value = _value;
        this.index = index;
    }
    public virtual void Gather(Player player)
    {

    }
    public string getName()
    {
        return name;
    }

}