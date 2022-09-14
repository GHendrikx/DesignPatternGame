using System.Collections;
using UnityEngine;

public abstract class Power
{
	protected ACharacter myCharacter;
	
	public abstract void ActivatePower();
    public abstract void DeactivatePower();

	public Power(ACharacter _owner) 
	{
		myCharacter = _owner;
	}
}