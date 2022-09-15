using System.Collections;
using UnityEngine;

public abstract class CharacterDecorator : IDecorator, ICommand
{
    protected Character myCharacter;

    public CharacterDecorator(Character _char)
    {
		myCharacter = _char;
    }

	public abstract void Execute();
	public abstract void Undo();
}

public class BigheadDecorator : CharacterDecorator
{
	public BigheadDecorator(Character _char) : base(_char) {}

	public override void Execute() {
		myCharacter.myTraits.headSize += 10;
	}

	public override void Undo() {
		myCharacter.myTraits.headSize -= 10;
	}
}