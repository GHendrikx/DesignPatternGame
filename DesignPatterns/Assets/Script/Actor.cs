using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor : MonoBehaviour, INotifier
{
	public Action onUpdated { get; set; }

	// super behaviours
	public List<Power> myPowers { get; protected set; } = new List<Power>();

	public virtual void Awake()
	{
		FindObjectOfType<ActorPowersViewer>()?.SetInstance(this);
	}

	public void ActivatePower(uint index) {
		if (index < myPowers.Count) myPowers[(int)index].ActivatePower();
	}

	public void DeactivatePower(uint index) {
		if (index < myPowers.Count) myPowers[(int)index].DeactivatePower();
	}
}