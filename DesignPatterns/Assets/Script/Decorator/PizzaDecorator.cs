using System.Collections;
using UnityEngine;

public class PizzaDecorator : IPizza
{
    private IPizza _pizza;

    public PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
    }
    public virtual string GetPizzaType()
    {
        return _pizza.GetPizzaType();
    }
}
