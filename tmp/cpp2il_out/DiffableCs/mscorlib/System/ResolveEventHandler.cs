namespace System;

public sealed class ResolveEventHandler : MulticastDelegate
{

	[CallerCount(Count = 79)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public ResolveEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override Assembly Invoke(object sender, ResolveEventArgs args) { }

}

