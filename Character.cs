using System;
using System.Collections.Generic;

public class Character
{
	protected CharacterClass _characterClass;
    protected int health;
    protected int damage;
    protected List<Attack> attacks = new();
}

public enum CharacterClass
{
    Dwarf,
    Elf,
    Human,
    Druid,
    Goblin
}