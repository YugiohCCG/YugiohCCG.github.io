namespace UnityEngine.Rendering;

internal struct IndirectBufferAllocInfo
{
	public int drawAllocIndex; //Field offset: 0x0
	public int drawCount; //Field offset: 0x4
	public int instanceAllocIndex; //Field offset: 0x8
	public int instanceCount; //Field offset: 0xC

	[CallerCount(Count = 0)]
	public int GetExtraDrawInfoSlotIndex() { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool IsEmpty() { }

	[CalledBy(Type = typeof(PrefixSumDrawsAndInstances), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsWithinLimits(in IndirectBufferLimits limits) { }

}

