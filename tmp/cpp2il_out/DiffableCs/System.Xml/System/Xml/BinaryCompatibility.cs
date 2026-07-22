namespace System.Xml;

internal static class BinaryCompatibility
{

	public static bool TargetsAtLeast_Desktop_V4_5_2
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

