namespace Unity.Collections;

internal sealed class NativeHashMapDebuggerTypeProxy
{
	private HashMapHelper<TKey>* Data; //Field offset: 0x0

	public List<Pair`2<TKey, TValue>> Items
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		 get { } //Length: 1047
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeHashMapDebuggerTypeProxy`2(NativeHashMap<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeHashMapDebuggerTypeProxy`2(ReadOnly<TKey, TValue> target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public List<Pair`2<TKey, TValue>> get_Items() { }

}

