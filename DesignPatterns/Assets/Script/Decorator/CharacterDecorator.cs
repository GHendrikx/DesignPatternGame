using System.Collections;
using UnityEngine;

public abstract class CharacterDecorator : IDecorator<Character>, ICommand<Character>
{
	public abstract void Execute(Character _char);
	public abstract void Undo(Character _char);
}

public class BigheadDecorator : CharacterDecorator
{
	public override void Execute(Character _char) {
		_char.myTraits.headSize += 10;
	}

	public override void Undo(Character _char) {
		_char.myTraits.headSize -= 10;
	}
}