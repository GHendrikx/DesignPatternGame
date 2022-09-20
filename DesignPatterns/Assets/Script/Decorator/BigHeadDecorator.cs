public class BigheadDecorator : CharacterDecorator
{
	public override void Execute(Character _char)
	{
		_char.myTraits.headSize += 1;
	}

	public override void Undo(Character _char)
	{
		_char.myTraits.headSize -= 1;
	}
}