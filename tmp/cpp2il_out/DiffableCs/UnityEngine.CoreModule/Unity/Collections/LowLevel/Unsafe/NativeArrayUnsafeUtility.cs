namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
public static class NativeArrayUnsafeUtility
{

	[CallerCount(Count = 97)]
	[DeduplicatedMethod]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public static Void* GetUnsafeBufferPointerWithoutChecks(NativeArray<T> nativeArray) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* GetUnsafePtr(NativeArray<T> nativeArray) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* GetUnsafeReadOnlyPtr(NativeArray<T> nativeArray) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	[Extension]
	public static Void* GetUnsafeReadOnlyPtr(ReadOnly<T> nativeArray) { }

}

