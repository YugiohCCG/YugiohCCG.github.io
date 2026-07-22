namespace System;

public interface IAsyncDisposable
{

	public ValueTask DisposeAsync() { }

}

