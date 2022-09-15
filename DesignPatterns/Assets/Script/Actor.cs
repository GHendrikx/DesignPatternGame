using System.Collections.Generic;
using UnityEngine;

public abstract class Actor : MonoBehaviour {	
	// super behaviours
	protected List<Power> myPowers = new List<Power>();

	public void ActivatePower(uint index) {
		if (index < myPowers.Count) myPowers[(int)index].ActivatePower();
	}

	public void DeactivatePower(uint index) {
		if (index < myPowers.Count) myPowers[(int)index].DeactivatePower();
	}
}
