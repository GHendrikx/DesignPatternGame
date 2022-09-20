using System.Collections;
using UnityEngine;

public abstract class Power
{
	protected Actor myActor;
	public abstract void ActivatePower();
	public virtual void DeactivatePower() { }

	public void SetActor(Actor actor)
	{
		myActor = actor;
	}

	public void Jump()
	{
		Debug.Log("Jump!");
	}

	public void Yell()
	{
		Debug.Log("Yell!");
	}

	public void MeleeAttack()
	{
		Debug.Log("Melee!");
	}

	public void RangedAttack()
	{
		Debug.Log("Ranged!");
	}

	public void SpawnParticles()
	{
		Debug.Log("Particle Stuff!");
	}
}

public class JumpPower : Power
{
	public override void ActivatePower()
	{
		Jump();
		SpawnParticles();	// Stofwolkje bijvoorbeeld
	}
}

public class YellPower : Power
{
	public override void ActivatePower()
	{
		Yell();
		SpawnParticles();	// Schreeuwen met consumptie
	}
}

public class MeleePower : Power
{
	public override void ActivatePower()
	{
		MeleeAttack();
	}
}

public class RangedPower : Power
{
	public override void ActivatePower()
	{
		RangedAttack();
	}
}

public class FrenzyPower : Power
{
	public override void ActivatePower()
	{
		// AAAAAaaAaAAaA
		MeleeAttack();
		RangedAttack();
		Yell();
		// All of the particles!
		SpawnParticles();
		SpawnParticles();
		SpawnParticles();
	}
}