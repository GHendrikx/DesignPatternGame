public class BigheadDecorator : CharacterDecorator
{
	public BigheadDecorator(Character _char) : base(_char) { }

	public override void Execute()
	{
		myCharacter.myTraits.headSize += 10;
	}

	public override void Undo()
	{
		myCharacter.myTraits.headSize -= 10;
	}
}