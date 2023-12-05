using GoblinsAttack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class UIData
{
    private static string battleNarration = "Fight!";
    private static HealthData healths = new HealthData();
    public static Pickup[] currentRewards;
    public static void setNarration(string message, bool playerTurn)
    {
        battleNarration = (playerTurn) ? "You used: " : "Opponent used: ";
        battleNarration += message;
    }
    public static void setNarration(string message)
    {
        battleNarration = message;
    }
    public static string getNarration()
    {
        return battleNarration;
    }
    public static void SetHealthAmounts(int playerHealth, int enemtHealth, bool maximum = false)
    {
        if(playerHealth < 0) playerHealth = 0;
        if(enemtHealth < 0) enemtHealth = 0;
        if(maximum)
        {
            healths = new HealthData(playerHealth, playerHealth, enemtHealth, enemtHealth);
            return;
        }
        healths.playerHealth = playerHealth;
        healths.enemyHealth = enemtHealth;
    }
    public static HealthData GetHealthValues()
    {
        return healths;
    }
    public static void setRewards(Pickup[] rewards)
    {
        currentRewards = rewards;
    }


}
public class HealthData
{
    public int playerHealth;
    public int playerMaxHealth;
    public int enemyHealth;
    public int enemyMaxHealth;
    public HealthData() { }
    public HealthData(int playerHealth, int playerMaxHealth, int enemyHealth, int enemyMaxHealth)
    {
        this.playerHealth = playerHealth;
        this.playerMaxHealth = playerMaxHealth;
        this.enemyHealth = enemyHealth;
        this.enemyMaxHealth = enemyMaxHealth;
    }
}