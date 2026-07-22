namespace System;

public sealed class Action : MulticastDelegate
{

	[CalledBy(Type = "UnityEngine.ObjectDispatcher", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 178)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Action`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(T obj) { }

}

