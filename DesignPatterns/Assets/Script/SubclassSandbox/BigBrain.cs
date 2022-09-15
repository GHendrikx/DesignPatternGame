using System.Collections;
using UnityEngine;

public class BigBrain : Power
{
  public BigBrain( Character _char ) : base(_char) {}

    public override void ActivatePower()
    {
      //Headsize 10x
      myCharacter.myTraits.headSize *= 10;
    }

    public override void DeactivatePower()
    {
      //headsize /10
      myCharacter.myTraits.headSize /= 10;
	}
}
