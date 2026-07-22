namespace System;

public sealed class AssemblyLoadEventHandler : MulticastDelegate
{

	[CallerCount(Count = 290)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public AssemblyLoadEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object sender, AssemblyLoadEventArgs args) { }

}

