using System.Collections;
using UnityEngine;

public class Pizza : IPizza
{
    public string GetPizzaType()
    {
        return "This is a normal pizza";
    }
}
