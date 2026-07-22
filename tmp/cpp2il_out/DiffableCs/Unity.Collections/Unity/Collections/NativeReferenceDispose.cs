namespace Unity.Collections;

[NativeContainer]
internal struct NativeReferenceDispose
{
	[NativeDisableUnsafePtrRestriction]
	internal Void* m_Data; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[CalledBy(Type = typeof(NativeReferenceDisposeJob), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Block), Member = "set_Alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorManager), Member = "Try", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block&)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Dispose() { }

}

