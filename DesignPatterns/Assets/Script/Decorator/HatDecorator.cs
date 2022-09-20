class HatDecorator : CharacterDecorator
{
    public override void Execute(Character _char)
    {
        //+1 hat
    }

    public override void Undo(Character _char)
    {
        //-1 hat
    }
}
