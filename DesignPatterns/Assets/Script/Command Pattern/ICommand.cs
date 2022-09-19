using System.Collections;
using UnityEngine;

public interface ICommand
{
    public void Execute();
    public void Undo();
}

public interface ICommand<T>
{
    public void Execute(T instance);
    public void Undo(T instance);
}
