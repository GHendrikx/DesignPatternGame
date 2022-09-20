using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public interface INotifier
{
	Action onUpdated { get; set; }
}

public abstract class Viewer<T> : MonoBehaviour where T : INotifier
{
	protected T instance;
	protected TMP_Text myText;
	protected StringBuilder sb = new StringBuilder();

	private void Awake()
	{
		myText = GetComponent<TMP_Text>();
	}

	public void SetInstance(T instance)
	{
		if (this.instance != null)
		{
			this.instance.onUpdated -= RebuildView;
		}
		this.instance = instance;
		this.instance.onUpdated += RebuildView;
		Debug.Log("eh?");
	}

	public abstract void RebuildView();
}

[RequireComponent(typeof(TMPro.TMP_Text))]
public class CharacterTraitViewer : Viewer<Character>
{
    public override void RebuildView()
    {
        sb.Clear();

        sb.AppendLine("Traits: ");
        sb.AppendLine("");
        sb.AppendLine($"My head is {instance.myTraits.headSize} units large,");
		sb.AppendLine($" I am wearing {instance.myTraits.hatCount} {(instance.myTraits.hatCount == 1 ? "hat" : "hats")},");
        if (instance.myTraits.limbs.Count == 0)
        {
			sb.AppendLine($"  and I have no arms or legs :(");
		}
		foreach ( Limb limb in instance.myTraits.limbs)
        {
            sb.AppendLine($"  and I have {(limb.limbType == LimbType.Arm ? "an arm" : "a leg" )} of length {limb.Length}");
        }

        myText.text = sb.ToString();
    }
}
