using System.Collections.Generic;

public abstract class ACharacter {
	// traits, editable by powers & decorators
	public int headSize = 1;
	
	// super behaviours
	protected List<Power> myPowers = new List<Power>();

	public void ActivatePower(uint index) {
		if (index < myPowers.Count) myPowers[index].ActivatePower();
	}

	public void DeactivatePower(uint index) {
		if (index < myPowers.Count) myPowers[index].DeactivatePower();
	}
}


public class Character : ACharacter {

}