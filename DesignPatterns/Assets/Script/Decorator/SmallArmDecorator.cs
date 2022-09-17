public class SmallArmDecorator : CharacterDecorator
{
    public SmallArmDecorator(Character _char) : base(_char) { }

    public override void Execute()
    {
        myCharacter.myTraits.ArmLength -= 10;

        //not sure about this but the drawing tells me this.
        myCharacter.myTraits.limbs.Add(new Limbs(myCharacter.myTraits.ArmLength, LimbType.Arms));
    }

    public override void Undo()
    {
        myCharacter.myTraits.ArmLength += 10;
    }
}
