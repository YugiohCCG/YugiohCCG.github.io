namespace System.Net;

internal static class Logging
{

	internal static bool On
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool get_On() { }

}

