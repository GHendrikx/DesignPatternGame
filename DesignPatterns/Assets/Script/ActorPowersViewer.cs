using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorPowersViewer : Viewer<Actor>
{
    public override void RebuildView()
    {
        sb.Clear();

        sb.AppendLine($"I have {instance.myPowers.Count} powers...");
        sb.AppendLine("");
        foreach(Power p in instance.myPowers)
        {
            sb.AppendLine($" {p.GetType().ToString()},");
        }

        myText.text = sb.ToString();
    }
}
