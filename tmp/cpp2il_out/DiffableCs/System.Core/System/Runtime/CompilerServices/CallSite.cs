namespace System.Runtime.CompilerServices;

public class CallSite
{
	internal readonly CallSiteBinder _binder; //Field offset: 0x10
	internal bool _match; //Field offset: 0x18

	public CallSiteBinder Binder
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CallSite(CallSiteBinder binder) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public CallSiteBinder get_Binder() { }

}

