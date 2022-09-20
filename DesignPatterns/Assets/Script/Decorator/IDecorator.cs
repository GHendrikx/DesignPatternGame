
﻿public interface IDecorator
{
    void Execute();
}

public interface IDecorator<T> {
	void Execute(T instance);
}
