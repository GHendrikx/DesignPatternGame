using System.Collections;
using UnityEngine;

public class LongLegs: Power {

    public LongLegs(Character _char) : base(_char) {}

    public override void ActivatePower()
    {
        //myActor.LegLength *= 10;
    }

    public override void DeactivatePower()
    {
        //myActor.LegLength /= 10;
    }
}