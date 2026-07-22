namespace Unity.Collections;

internal sealed class NativeParallelMultiHashMapDebuggerTypeProxy
{
	private NativeParallelMultiHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	public List<ListPair`2<TKey, List`1<TValue>>> Items
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 2107
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeParallelMultiHashMapDebuggerTypeProxy`2(NativeParallelMultiHashMap<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	public List<ListPair`2<TKey, List`1<TValue>>> get_Items() { }

}

