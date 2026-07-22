namespace System;

internal sealed class IOAsyncCallback : MulticastDelegate
{

	[CallerCount(Count = 389)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public IOAsyncCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(IOAsyncResult ioares) { }

}

