using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
	public void Execute();
}

public interface ICommand<T>
{
	public void Execute(T instance);
}

public interface IReversibleCommand : ICommand
{    
    public void Undo();
}

public interface IReversibleCommand<T> : ICommand<T>
{

    public void Undo(T instance);
}

public interface ICommandStackManager<T>
{
	Stack<T> history { get; }
	Stack<T> future { get; }
	void Undo();
	void Redo();
}