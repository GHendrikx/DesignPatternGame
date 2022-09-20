class HatDecorator : CharacterDecorator
{
    public override void Execute(Character _char)
    {
        _char.myTraits.hatCount++;
    }

    public override void Undo(Character _char)
    {
		_char.myTraits.hatCount--;
	}
}
