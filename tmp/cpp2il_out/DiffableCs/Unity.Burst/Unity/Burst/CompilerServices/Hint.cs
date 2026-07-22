namespace Unity.Burst.CompilerServices;

public static class Hint
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void Assume(bool condition) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static bool Likely(bool condition) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static bool Unlikely(bool condition) { }

}

