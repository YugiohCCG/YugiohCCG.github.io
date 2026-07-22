namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
public struct AllocatorHelper : IDisposable
{
	private readonly T* m_allocator; //Field offset: 0x0
	private AllocatorHandle m_backingAllocator; //Field offset: 0x0

	public T Allocator
	{
		[CallerCount(Count = 65)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 36
	}

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorManager), Member = "CreateAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(bool), typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("CreateAllocator is unburstable")]
	public AllocatorHelper`1(AllocatorHandle backingAllocator, bool isGlobal = false, int globalIndex = 0) { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AllocatorManager), Member = "DestroyAllocator", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("DestroyAllocator is unburstable")]
	public override void Dispose() { }

	[CallerCount(Count = 65)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_Allocator() { }

}

