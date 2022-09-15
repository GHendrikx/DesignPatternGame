using System.Collections;
using UnityEngine;

public abstract class Power
{
	protected Character myCharacter;
	
	public abstract void ActivatePower();
    public abstract void DeactivatePower();

	public Power(Character _char) 
	{
		myCharacter = _char;
	}
}