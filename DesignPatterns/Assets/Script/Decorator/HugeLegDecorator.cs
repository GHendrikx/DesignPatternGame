using UnityEngine;

public class HugeLegDecorator : CharacterDecorator
{
    public HugeLegDecorator(Character _char) : base(_char) { }

    public override void Execute()
    {
        myCharacter.myTraits.LegLength += 10;

        //not sure about this but the drawing tells me this.
        myCharacter.myTraits.limbs.Add(new Limbs(myCharacter.myTraits.ArmLength, LimbType.Leg));
    }

    public override void Undo()
    {
        myCharacter.myTraits.LegLength -= 10;
    }
}
