using UnityEngine;

public class HugeLegDecorator : CharacterDecorator
{
    Limb myLimb;

    public override void Execute(Character _char)
    {
        _char.myTraits.LegLength += 10;

        myLimb = new Limb(_char.myTraits.LegLength, LimbType.Leg);

		//not sure about this but the drawing tells me this.
		_char.myTraits.limbs.Add(myLimb);
    }

    public override void Undo(Character _char)
    {
        _char.myTraits.LegLength -= 10;

		_char.myTraits.limbs.Remove(myLimb);
	}
}
