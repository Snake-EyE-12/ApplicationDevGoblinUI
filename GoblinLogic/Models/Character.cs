using System;
using System.Collections.Generic;

public class Character
{
	protected CharacterClass _characterClass;
    protected int health;
    protected int maxHealth;
    protected int damage;
    protected Attack[] attacks;
    public int block = 0;

    public Character(CharacterClass characterClass, int health, int damage, Attack[] attacks)
    {
        _characterClass = characterClass;
        this.health = health;
        this.maxHealth = health;
        this.damage = damage;
        this.attacks = attacks;
    }
    public Character(CharacterClass characterClass, int health, int damage)
    {
        _characterClass = characterClass;
        this.health = health;
        this.maxHealth = health;
        this.damage = damage;
    }
    public Attack[] getAttacks()
    {
        return attacks;
    }
    public virtual bool Attack(int index, Character opponent) { return false; }
    public bool takeDamage(int amount)
    {
        health -= amount;
        return health <= 0;
    }
    public int getHealth()
    {
        return health;
    }
    public int getMaxHealth()
    {
        return maxHealth;
    }
    public int getDamage()
    {
        return damage;
    }
    public void setAttacks(Attack[] attacks)
    {
        this.attacks = attacks;
    }
    public void heal(int amount, bool max = false)
    {
        if(max)
        {
            maxHealth += amount;
        }
        health += amount;
        if (health > maxHealth) health = maxHealth;
    }
}

public enum CharacterClass
{
    Dwarf,
    Elf,
    Human,
    Druid,
    Goblin
}