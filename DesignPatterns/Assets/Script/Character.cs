using System.Collections.Generic;

public class Character : Actor {

	// traits, editable by powers & decorators
	public Traits myTraits;
	
	// DISCUSS: Where does this belong? Character or Actor?
	// super behaviours
	public Stack<IDecorator> myDecorations = new Stack<IDecorator>();

	public void Awake() { }
	
	public void Start(){ }
}