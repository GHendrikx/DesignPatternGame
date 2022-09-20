using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(TMPro.TMP_Text))]
public class CharacterTraitViewer : MonoBehaviour
{
    private Character myChar;
    private TMP_Text myText;
	private StringBuilder sb = new StringBuilder();

	private void Awake()
    {
        myText = GetComponent<TMP_Text>();
    }

    public void SetCharacter( Character _char )
    {
        if ( myChar != null )
        {
            myChar.onTraitsUpdated -= RebuildView;
		}
        myChar = _char;
		myChar.onTraitsUpdated += RebuildView;
	}

    public void RebuildView()
    {
        sb.Clear();

        sb.AppendLine("Traits: ");
        sb.AppendLine("");
        sb.AppendLine($"My head is {myChar.myTraits.headSize} units large,");
		sb.AppendLine($" I am wearing {myChar.myTraits.hatCount} {(myChar.myTraits.hatCount == 1 ? "hat" : "hats")},");
        if (myChar.myTraits.limbs.Count == 0)
        {
			sb.AppendLine($"  and I have no arms or legs :(");
		}
		foreach ( Limb limb in myChar.myTraits.limbs)
        {
            sb.AppendLine($"  and I have {(limb.limbType == LimbType.Arm ? "an arm" : "a leg" )} of length {limb.Length}");
        }

        myText.text = sb.ToString();
    }
}
