using UnityEngine;

public class HugeLegDecorator : CharacterDecorator
{
    public override void Execute(Character _char)
    {
        _char.myTraits.LegLength += 10;

        //not sure about this but the drawing tells me this.
        _char.myTraits.limbs.Add(new Limbs(_char.myTraits.ArmLength, LimbType.Leg));
    }

    public override void Undo(Character _char)
    {
        _char.myTraits.LegLength -= 10;
    }
}
