namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeAtomicCounter64
{
	public Int64* Counter; //Field offset: 0x0

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public UnsafeAtomicCounter64(Void* ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(long)}, ReturnType = typeof(long))]
	public long Add(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public long AddSat(long value, long max = 9223372036854775807) { }

	[CallerCount(Count = 0)]
	public void Reset(long value = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&), typeof(long)}, ReturnType = typeof(long))]
	public long Sub(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public long SubSat(long value, long min = -9223372036854775808) { }

}

