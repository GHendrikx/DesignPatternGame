using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPattern : MonoBehaviour
{
    private Stack<ICommand> commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand _command)
    {
        commands.Push(_command);
        _command.Execute();
    }

    public void UndoCommand()
    {
        ICommand command = commands.Pop();
        command.Undo();
    }
}
