namespace System.Buffers;

internal static class Utilities
{

	[CallerCount(Count = 0)]
	internal static int GetMaxSizeForBucket(int binIndex) { }

	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static int SelectBucketIndex(int bufferSize) { }

}

