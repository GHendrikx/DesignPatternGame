using System.Collections;
using UnityEngine;

public class BigBrain : Power
{
    public override void ActivatePower()
    {
		//Headsize 10x
		myCharacter.headSize *= 10;
    }

    public override void DeactivatePower()
    {
		//headsize /10
		myCharacter.headSize /= 10;
	}
}
