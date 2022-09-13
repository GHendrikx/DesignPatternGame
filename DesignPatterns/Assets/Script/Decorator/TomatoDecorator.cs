using UnityEngine;

    public class TomatoDecorator : PizzaDecorator
    {
    public TomatoDecorator(IPizza _pizza) : base(_pizza) { }

    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra tomatoes";
        return type;
    }
    }
