namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeScratchAllocator
{
	private Void* m_Pointer; //Field offset: 0x0
	private int m_LengthInBytes; //Field offset: 0x8
	private readonly int m_CapacityInBytes; //Field offset: 0xC

	[CallerCount(Count = 0)]
	public UnsafeScratchAllocator(Void* ptr, int capacityInBytes) { }

	[CalledBy(Type = typeof(UnsafeScratchAllocator), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Void*))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Void* Allocate(int sizeInBytes, int alignmentInBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeScratchAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public Void* Allocate(int count = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckAllocationDoesNotExceedCapacity(ulong requestedSize) { }

}

