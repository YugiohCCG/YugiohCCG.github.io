namespace Unity.Burst.Intrinsics;

public static class Common
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void Pause() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public static ulong umul128(ulong x, ulong y, out ulong high) { }

}

