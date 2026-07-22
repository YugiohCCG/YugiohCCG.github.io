namespace Unity.Collections;

internal sealed class BitField64DebugView
{
	private BitField64 Data; //Field offset: 0x10

	public Boolean[] Bits
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 126
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BitField64DebugView(BitField64 data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public Boolean[] get_Bits() { }

}

