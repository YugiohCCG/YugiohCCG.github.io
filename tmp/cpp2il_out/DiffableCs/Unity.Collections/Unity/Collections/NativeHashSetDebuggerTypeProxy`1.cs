namespace Unity.Collections;

internal sealed class NativeHashSetDebuggerTypeProxy
{
	private HashMapHelper<T>* Data; //Field offset: 0x0

	public List<T> Items
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
		[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 554
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeHashSetDebuggerTypeProxy`1(NativeHashSet<T> data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericStructType>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public List<T> get_Items() { }

}

