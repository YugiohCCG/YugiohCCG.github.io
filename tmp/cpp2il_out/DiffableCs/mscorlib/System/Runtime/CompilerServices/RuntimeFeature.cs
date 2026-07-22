namespace System.Runtime.CompilerServices;

public static class RuntimeFeature
{

	public static bool IsDynamicCodeSupported
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool get_IsDynamicCodeSupported() { }

}

