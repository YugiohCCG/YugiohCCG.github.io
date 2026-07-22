namespace Unity.Collections;

internal sealed class BitField32DebugView
{
	private BitField32 BitField; //Field offset: 0x10

	public Boolean[] Bits
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 124
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BitField32DebugView(BitField32 bitfield) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Boolean[] get_Bits() { }

}

