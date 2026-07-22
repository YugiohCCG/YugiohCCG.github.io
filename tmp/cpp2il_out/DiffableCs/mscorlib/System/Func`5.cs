namespace System;

public sealed class Func : MulticastDelegate
{

	[CalledBy(Type = "ZXing.BarcodeReaderGeneric`1", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Func`5(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

