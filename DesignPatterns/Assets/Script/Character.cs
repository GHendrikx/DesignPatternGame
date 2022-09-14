using System.Collections.Generic;

public class Character : Actor {
	// traits, editable by powers & decorators
	public List<Traits> myTraits;

	public Stack<IDecorator> myDecorations = new Stack<IDecorator>();
	
	// super behaviours
	protected List<Power> myPowers = new List<Power>();

	public void Awake(){

	}
	
	public void Start(){

	}
}