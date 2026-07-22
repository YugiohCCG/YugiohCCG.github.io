namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public static class CollectionHelper
{
	[BurstCompile]
	internal struct DummyJob : IJob
	{

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	public struct LongDoubleUnion
	{
		internal long longValue; //Field offset: 0x0
		internal double doubleValue; //Field offset: 0x0

	}

	public const int CacheLineSize = 64; //Field offset: 0x0

	[CalledBy(Type = typeof(UnsafeQueueData), Member = "AllocateQueue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(UnsafeQueueData*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public static int Align(int size, int alignmentPowerOfTwo) { }

	[CalledBy(Type = typeof(UnsafeParallelHashMapData), Member = "AllocateHashMap", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(AllocatorHandle), typeof(UnsafeParallelHashMapData*&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeParallelHashMapData), Member = "CalculateDataSize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long), typeof(Int64&), typeof(Int64&), typeof(Int64&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 8)]
	public static long Align(long size, int alignmentPowerOfTwo) { }

	[CallerCount(Count = 0)]
	public static ulong Align(ulong size, ulong alignmentPowerOfTwo) { }

	[CallerCount(Count = 0)]
	internal static Void* AlignPointer(Void* ptr, int alignmentPowerOfTwo) { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	internal static int AssumePositive(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckAllocator(AllocatorHandle allocator) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	internal static void CheckCapacityInRange(int capacity, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckCapacityInRange(int capacity, int maxCapacity, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckConvertArguments(int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckIndexInRange(int index, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckIntPositivePowerOfTwo(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)})]
	internal static void CheckIsUnmanaged() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "ENABLE_UNITY_COLLECTIONS_CHECKS", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(DummyJob)})]
	public static void CheckReflectionDataCorrect(IntPtr reflectionData) { }

	[BurstDiscard]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private static void CheckReflectionDataCorrectInternal(IntPtr reflectionData, ref bool burstCompiled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckUlongPositivePowerOfTwo(ulong value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, AllocatorHandle allocator, bool setTempMemoryHandle = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray<T> ConvertExistingNativeListToNativeArray(ref NativeList<T>& nativeList, int length, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Managed array")]
	public static NativeArray<T> CreateNativeArray(T[] array, ref U allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray<T> CreateNativeArray(NativeArray<T> array, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeList`1), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(NativeKeyValueArrays`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeQueue`1), Member = "ToArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(HashMapHelper`1), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(HashMapHelper`1), Member = "GetValueArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CalledBy(Type = typeof(UnsafeParallelMultiHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "Initialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.AttachmentDescriptor>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static NativeArray<T> CreateNativeArray(int length, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Managed array")]
	public static NativeArray<T> CreateNativeArray(T[] array, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(AllocatorHandle)})]
	public static NativeArray<T> CreateNativeArray(int length, ref U allocator, NativeArrayOptions options = 1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int), typeof(AllocatorHandle)})]
	public static NativeParallelMultiHashMap<TKey, TValue> CreateNativeParallelMultiHashMap(int length, ref U allocator) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void Dispose(NativeArray<T> nativeArray) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static void DisposeNativeArray(NativeArray<T> nativeArray, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(FixedList`2), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedList64Bytes`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedList128Bytes`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedList512Bytes`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedList4096Bytes`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ComputeHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	public static uint Hash(Void* ptr, int bytes) { }

	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsAligned(Void* p, int alignmentPowerOfTwo) { }

	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool IsAligned(ulong offset, int alignmentPowerOfTwo) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsPowerOfTwo(int value) { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int Log2Ceil(int value) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int Log2Floor(int value) { }

	[CalledBy(Type = typeof(NativeReference`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeReference`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(UnsafeAppendBuffer), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeAppendBuffer), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(UnsafeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeList`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	internal static bool ShouldDeallocate(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "OffsetOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromBurstCompatTesting("Used only for debugging, and uses managed strings")]
	internal static void WriteLayout(Type type) { }

}

