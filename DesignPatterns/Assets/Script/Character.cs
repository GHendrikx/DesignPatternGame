
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System.Linq;
using System;

public class Character : Actor, ICommandStackManager<IDecorator<Character>>
{
	// traits, editable by powers & decorators
	public Traits myTraits = new Traits();
	public Stack<IDecorator<Character>> history { get; private set; } = new Stack<IDecorator<Character>>();
	public Stack<IDecorator<Character>> future { get; private set; } = new Stack<IDecorator<Character>>();


	public override void Awake()
	{
		FindObjectOfType<CharacterTraitViewer>()?.SetInstance(this);

		myPowers.Add(new JumpPower());
		myPowers.Add(new YellPower());
		myPowers.Add(new MeleePower());
		myPowers.Add(new RangedPower());
		myPowers.Add(new FrenzyPower());
		foreach( Power p in myPowers )
		{
			p.SetActor(this);
		}

		base.Awake();
	}

	public void Start()
	{
		
	}

	public void AddRandomDecoration()
	{
		IEnumerable<System.Type> types = Assembly.GetExecutingAssembly()
													.GetTypes()
													.Where(myType => typeof(CharacterDecorator).IsAssignableFrom(myType) && myType != typeof(CharacterDecorator) && !myType.IsAbstract);
		if ( types.Count() > 0 ) 
		{
			int rand = UnityEngine.Random.Range(0, types.Count());
			IDecorator<Character> dec = (IDecorator<Character>)System.Activator.CreateInstance(types.ElementAt(rand));
			dec.Execute(this);

			history.Push(dec);
			future.Clear();

			onUpdated?.Invoke();
		}
	}

	public void Undo()
	{
		if (history.Count > 0)
		{
			IDecorator<Character> toUndo = history.Pop();
			future.Push(toUndo);
			(toUndo as IReversibleCommand<Character>).Undo(this);

			onUpdated?.Invoke();
		}
	}

	public void Redo()
	{
		if (future.Count > 0)
		{
			IDecorator<Character> toRedo = future.Pop();
			history.Push(toRedo);
			toRedo.Execute(this);

			onUpdated?.Invoke();
		}
	}
}