namespace System.Runtime.CompilerServices;

public interface INotifyCompletion
{

	public void OnCompleted(Action continuation) { }

}

