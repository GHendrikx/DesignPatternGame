using System.Collections;
using UnityEngine;

public abstract class CharacterDecorator : IDecorator, ICommand
{
    private ACharacter myCharacter;

    public CharacterDecorator(ACharacter _char)
    {
		myCharacter = _char;
    }

	public abstract void Execute();
	public abstract void Undo();
}

public class BigheadDecorator : CharacterDecorator
{
	public void Execute() {
		myCharacter.myTraits.headSize += 10;
	}

	public void Undo() {
		myCharacter.myTraits.headSize -= 10;
	}
}