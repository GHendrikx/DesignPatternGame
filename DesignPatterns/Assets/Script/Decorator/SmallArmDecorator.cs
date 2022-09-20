public class SmallArmDecorator : CharacterDecorator
{
    public override void Execute(Character _char)
    {
        _char.myTraits.ArmLength -= 10;

        //not sure about this but the drawing tells me this.
        _char.myTraits.limbs.Add(new Limbs(_char.myTraits.ArmLength, LimbType.Arms));
    }

    public override void Undo(Character _char)
    {
        _char.myTraits.ArmLength += 10;
    }
}
