namespace Unity.Burst.CompilerServices;

public static class Aliasing
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectAliased(Void* a, Void* b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectAliased(in A a, in B b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectAliased(Void* a, in B b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectAliased(in A a, Void* b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectNotAliased(Void* a, Void* b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectNotAliased(in A a, in B b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectNotAliased(Void* a, in B b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public static void ExpectNotAliased(in A a, Void* b) { }

}

