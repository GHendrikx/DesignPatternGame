public class SmallArmDecorator : CharacterDecorator
{
    Limb myLimb;

    public override void Execute(Character _char)
    {
        _char.myTraits.ArmLength -= 10;
        myLimb = new Limb(_char.myTraits.ArmLength, LimbType.Arm);

		//not sure about this but the drawing tells me this.
		_char.myTraits.limbs.Add(myLimb);
    }

    public override void Undo(Character _char)
    {
        _char.myTraits.ArmLength += 10;
		_char.myTraits.limbs.Remove(myLimb);
	}
}
