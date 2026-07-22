namespace UnityEngine.UIElements;

internal struct CountingBloomFilter
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_Counters>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(byte), 16384)]
	private <m_Counters>e__FixedBuffer m_Counters; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private void AdjustSlot(uint index, bool increment) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool ContainsHash(uint hash) { }

	[CallerCount(Count = 0)]
	private uint Hash1(uint hash) { }

	[CallerCount(Count = 0)]
	private uint Hash2(uint hash) { }

	[CallerCount(Count = 0)]
	public void InsertHash(uint hash) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsSlotEmpty(uint index) { }

	[CallerCount(Count = 0)]
	public void RemoveHash(uint hash) { }

}

