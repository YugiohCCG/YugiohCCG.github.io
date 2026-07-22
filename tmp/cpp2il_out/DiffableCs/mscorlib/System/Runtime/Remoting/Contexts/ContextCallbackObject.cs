namespace System.Runtime.Remoting.Contexts;

internal class ContextCallbackObject : ContextBoundObject
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContextCallbackObject() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void DoCallBack(CrossContextDelegate deleg) { }

}

