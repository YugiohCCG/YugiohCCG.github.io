namespace UnityEngine;

[Extension]
public static class AsyncOperationAwaitableExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ExcludeFromDocs]
	[Extension]
	public static Awaiter GetAwaiter(AsyncOperation op) { }

}

