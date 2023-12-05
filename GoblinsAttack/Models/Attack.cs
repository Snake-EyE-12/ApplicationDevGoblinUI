using System;

public abstract class Attack
{
	protected string attackName = "";
	protected int cooldown = 0;
	protected int cooldownTimer = 0;
	protected string description;
    protected Character owner;

    public Attack(Character owner, string attackName, string description, int cooldown)
	{
		this.owner = owner;
		this.attackName = attackName;
		this.description = description;
		this.cooldown = cooldown;
		this.cooldownTimer = cooldown;
	}
	public abstract string Use(Character target);
	public virtual int CalculateValue() { return 0; }
	public virtual string GetDescription() {
		string text = description + "\n";
		if (IsOnCooldown()) text += "On Cooldown for " + (cooldown - cooldownTimer) + (cooldown - cooldownTimer == 1 ? " turn.\n" : " turns.\n");
		return text;
	}
	public void DecrementCooldown()
	{
		if(cooldownTimer < cooldown) cooldownTimer++;
	}
	public string GetName()
	{
		return attackName;
	}
	public bool IsOnCooldown()
	{
		return cooldownTimer != cooldown;
	}
	public void SetOwner(Character owner)
	{
		this.owner=owner;
	}
}
