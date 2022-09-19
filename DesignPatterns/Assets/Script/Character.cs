
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System.Linq;

public class Character : Actor {

	// traits, editable by powers & decorators
	public Traits myTraits;
	
<<<<<<< HEAD
	// DISCUSS: Where does this belong? Character or Actor?
	// super behaviours
	public Stack<IDecorator> myDecorations = new Stack<IDecorator>();

	public void Awake() { }
	
	public void Start(){ }
=======
	public Stack<IDecorator<Character>> myDecorations = new Stack<IDecorator<Character>>();

	public void Awake()
	{
		
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
			int rand = Random.Range(0, types.Count());
			IDecorator<Character> dec = (IDecorator<Character>)System.Activator.CreateInstance(types.ElementAt(rand));
			myDecorations.Push(dec);
		}

		foreach( IDecorator<Character> d in myDecorations )
		{
			Debug.Log( d.GetType().ToString() );
		}
	}
>>>>>>> Random Generator CharacterDecorators
}