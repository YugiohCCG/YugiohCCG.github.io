namespace System.Net;

internal class InternalException : SystemException
{

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal InternalException() { }

}

