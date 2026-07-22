namespace System.Numerics.Hashing;

internal static class HashHelpers
{
	public static readonly int RandomSeed; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "GetHashCode", ReturnType = typeof(int))]
	private static HashHelpers() { }

	[CallerCount(Count = 113)]
	[DeduplicatedMethod]
	public static int Combine(int h1, int h2) { }

}

