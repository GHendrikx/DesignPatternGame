using System.Collections;
using UnityEngine;

    public class OnionDecorator : PizzaDecorator
    {

        public OnionDecorator(IPizza _pizza) :base(_pizza) { }

    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra onions";
        return type;
    }
}
