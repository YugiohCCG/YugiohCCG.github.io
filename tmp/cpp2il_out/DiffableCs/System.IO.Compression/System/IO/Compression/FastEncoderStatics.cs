namespace System.IO.Compression;

internal static class FastEncoderStatics
{
	internal static readonly Byte[] FastEncoderTreeStructureData; //Field offset: 0x0
	internal static readonly Byte[] BFinalFastEncoderTreeStructureData; //Field offset: 0x8
	internal static readonly UInt32[] FastEncoderLiteralCodeInfo; //Field offset: 0x10
	internal static readonly UInt32[] FastEncoderDistanceCodeInfo; //Field offset: 0x18
	internal static readonly UInt32[] BitMask; //Field offset: 0x20
	internal static readonly Byte[] ExtraLengthBits; //Field offset: 0x28
	internal static readonly Byte[] ExtraDistanceBits; //Field offset: 0x30
	private static readonly Byte[] s_distLookup; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static FastEncoderStatics() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static uint BitReverse(uint code, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] CreateDistanceLookup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static int GetSlot(int pos) { }

}

