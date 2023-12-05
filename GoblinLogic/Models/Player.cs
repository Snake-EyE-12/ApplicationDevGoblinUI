using System;

public class Player : Character
{
	protected int magicPower;
	protected int stealth;
    public int coins = 0;

	public Player(CharacterClass characterClass, int health, int damage, int magicPower, int stealth) : base(characterClass, health, damage)
    {
        this.magicPower = magicPower;
        this.stealth = stealth;
    }
    public override bool Attack(int index, Character opponent)
    {
        if (attacks[index].IsOnCooldown())
        {
            UIData.setNarration("Attack On Cooldown");
            return false;
        }
        UIData.setNarration(attacks[index].Use(opponent), true);
        return true;
    }
    public int AddCoins(int amount)
    {
        coins += amount;
        if(coins <0) { coins = 0; }
        return coins;
    }
    public int getStealth()
    {
        return stealth;
    }
    public int getMagic()
    {
        return magicPower;
    }
}
