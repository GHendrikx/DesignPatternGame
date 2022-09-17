class HatDecorator : CharacterDecorator
{

    public HatDecorator(Character _char) : base(_char) { }

    public override void Execute()
    {
        //+1 hat
    }

    public override void Undo()
    {
        //-1 hat
    }
}
