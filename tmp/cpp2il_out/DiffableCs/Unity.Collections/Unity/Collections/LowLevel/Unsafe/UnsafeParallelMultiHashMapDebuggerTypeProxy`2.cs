namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy
{
	private UnsafeParallelMultiHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	public List<ListPair`2<TKey, List`1<TValue>>> Items
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 1384
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeParallelMultiHashMapDebuggerTypeProxy`2(UnsafeParallelMultiHashMap<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	public List<ListPair`2<TKey, List`1<TValue>>> get_Items() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(ref UnsafeParallelMultiHashMap<TKey, TValue>& hashMap, AllocatorHandle allocator) { }

}

