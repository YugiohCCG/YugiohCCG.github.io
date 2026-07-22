namespace ZXing.QrCode.Internal;

internal sealed class FormatInformation
{
	private const int FORMAT_INFO_MASK_QR = 21522; //Field offset: 0x0
	private static readonly Int32[][] FORMAT_INFO_DECODE_LOOKUP; //Field offset: 0x0
	private static readonly Int32[] BITS_SET_IN_HALF_BYTE; //Field offset: 0x8
	private readonly ErrorCorrectionLevel errorCorrectionLevel; //Field offset: 0x10
	private readonly byte dataMask; //Field offset: 0x18

	internal byte DataMask
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal ErrorCorrectionLevel ErrorCorrectionLevel
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 36)]
	private static FormatInformation() { }

	[CalledBy(Type = typeof(FormatInformation), Member = "doDecodeFormatInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(FormatInformation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private FormatInformation(int formatInfo) { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readFormatInformation", ReturnType = typeof(FormatInformation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FormatInformation), Member = "doDecodeFormatInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(FormatInformation))]
	internal static FormatInformation decodeFormatInformation(int maskedFormatInfo1, int maskedFormatInfo2) { }

	[CalledBy(Type = typeof(FormatInformation), Member = "decodeFormatInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(FormatInformation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormatInformation), Member = "numBitsDiffering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FormatInformation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static FormatInformation doDecodeFormatInformation(int maskedFormatInfo1, int maskedFormatInfo2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal byte get_DataMask() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal ErrorCorrectionLevel get_ErrorCorrectionLevel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(FormatInformation), Member = "doDecodeFormatInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(FormatInformation))]
	[CalledBy(Type = typeof(Version), Member = "decodeVersionInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static int numBitsDiffering(int a, int b) { }

}

