using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class PlayerCreationManager
{
    public static int skillPoints = 15;
    private static int maxPerSkill = 10;

    public static CharacterClass currentClassSelection = CharacterClass.Human;

    public static int currentHealthBar = 0;
    public static int currentDamageBar = 0;
    public static int currentMagicPowerBar = 0;
    public static int currentStealthBar = 0;

    public static void IncreaseStat(Statistic stat, int increase)
    {
        if (skillPoints - increase < 0) return;
        
        switch(stat)
        {
            case Statistic.Health:
                {
                    if (currentHealthBar + increase <= maxPerSkill)
                    {
                        currentHealthBar += increase;
                        skillPoints -= increase;
                    }
                    return;
                }
            case Statistic.Damage:
                {
                    if (currentDamageBar + increase <= maxPerSkill)
                    {
                        currentDamageBar += increase;
                        skillPoints -= increase;
                    }
                    return;
                }
            case Statistic.Magic:
                {
                    if (currentMagicPowerBar + increase <= maxPerSkill)
                    {
                        currentMagicPowerBar += increase;
                        skillPoints -= increase;
                    }
                    return;
                }
            case Statistic.Stealth:
                {
                    if (currentStealthBar + increase <= maxPerSkill)
                    {
                        currentStealthBar += increase;
                        skillPoints -= increase;
                    }
                    return;
                }
        }
    }
    public static void Reset()
    {
        currentHealthBar = 0;
        currentDamageBar = 0;
        currentMagicPowerBar = 0;
        currentStealthBar = 0;

        skillPoints = 15;
    }
}


public enum Statistic
{
    Health,
    Damage,
    Magic,
    Stealth
}