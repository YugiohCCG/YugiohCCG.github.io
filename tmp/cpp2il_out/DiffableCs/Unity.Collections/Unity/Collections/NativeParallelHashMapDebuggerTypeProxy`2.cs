namespace Unity.Collections;

internal sealed class NativeParallelHashMapDebuggerTypeProxy
{
	private UnsafeParallelHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	public List<Pair`2<TKey, TValue>> Items
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unity.Collections.NativeKeyValueArrays`2<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 1015
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeParallelHashMapDebuggerTypeProxy`2(NativeParallelHashMap<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal NativeParallelHashMapDebuggerTypeProxy`2(ReadOnly<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeKeyValueArrays`2<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType, Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

