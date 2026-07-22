namespace System.Threading;

internal static class _ThreadPoolWaitCallback
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	internal static bool PerformWaitCallback() { }

}

