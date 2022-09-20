using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct KeyCommand
{
    public KeyCode keyCode;
    public ICommand command;
}

public class PowerCommand : ICommand
{
    private uint powerNumber = 0;
    private Actor myActor;

    public PowerCommand(Actor actor, uint powerNumber)
    {
        this.myActor = actor;
        this.powerNumber = powerNumber;
    }

    public void Execute()
    {
        myActor.ActivatePower(powerNumber);

	}
}

public class InputHandler
{
    private Dictionary<KeyCode, List<ICommand>> keyCommands = new Dictionary<KeyCode, List<ICommand>>();

    public void Add(KeyCode key, ICommand command)
    {
        if (!keyCommands.ContainsKey(key))
        {
			keyCommands.Add(key, new List<ICommand>());
		}
        keyCommands[key].Add(command);
	}

    public void HandleCommands()
    {
        foreach ( KeyValuePair<KeyCode, List<ICommand>> pair in keyCommands )
        {
            if ( Input.GetKeyDown(pair.Key))
            {
                foreach( ICommand command in pair.Value )
                {
                    command.Execute();
                }
            }
        }
    }
}

[RequireComponent(typeof(Actor))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private List<KeyCode> keyList = new List<KeyCode>();

    private InputHandler myInput;
    private Actor myActor;

    // Start is called before the first frame update
    private void Awake()
    {
        myInput = new InputHandler();
        myActor = GetComponent<Actor>();
	}

    private void Start()
    {
		for (uint i = 0; i < myActor.myPowers.Count && i < keyList.Count; ++i)
		{
			myInput.Add(keyList[(int)i], new PowerCommand(myActor, i));
		}
	}

    // Update is called once per frame
    void Update()
    {
        myInput.HandleCommands();
    }
}
