using System.Collections;
using UnityEngine;

public class Tester : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        IPizza pizza = new Pizza();
        IPizza cheeseDecorator = new CheeseDecorator(pizza);
        IPizza onionDecorator = new OnionDecorator(cheeseDecorator);   
        IPizza tomatoDecorator = new TomatoDecorator(onionDecorator);
        Debug.Log(tomatoDecorator.GetPizzaType());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
