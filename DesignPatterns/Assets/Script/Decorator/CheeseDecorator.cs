using System.Collections;
using UnityEngine;

public class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(IPizza pizza) : base(pizza) { }

    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra cheese";
        return type;
    }
}
