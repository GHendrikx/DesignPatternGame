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