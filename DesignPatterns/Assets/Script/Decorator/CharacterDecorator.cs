using System.Collections;
using UnityEngine;

public abstract class CharacterDecorator : IDecorator<Character>, ICommand<Character>
{
	public abstract void Execute(Character _char);
	public abstract void Undo(Character _char);
}