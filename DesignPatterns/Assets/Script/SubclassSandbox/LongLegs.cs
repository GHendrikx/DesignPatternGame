using System.Collections;
using UnityEngine;

public class LongLegs: Power{

    public override void ActivatePower()
    {
        myCharacter.LegLength *= 10;
    }

    public override void DeactivatePower()
    {
        myCharacter.LegLength /= 10;
    }
}