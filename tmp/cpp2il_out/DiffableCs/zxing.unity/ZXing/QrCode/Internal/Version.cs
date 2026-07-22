namespace ZXing.QrCode.Internal;

public sealed class Version
{
	internal sealed class ECB
	{
		private readonly int count; //Field offset: 0x10
		private readonly int dataCodewords; //Field offset: 0x14

		public int Count
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int DataCodewords
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 79)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ECB(int count, int dataCodewords) { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public int get_Count() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public int get_DataCodewords() { }

	}

	internal sealed class ECBlocks
	{
		private readonly int ecCodewordsPerBlock; //Field offset: 0x10
		private readonly ECB[] ecBlocks; //Field offset: 0x18

		public int ECCodewordsPerBlock
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int NumBlocks
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 76
		}

		public int TotalECCodewords
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 89
		}

		[CallerCount(Count = 157)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ECBlocks(int ecCodewordsPerBlock, ECB[] ecBlocks) { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public int get_ECCodewordsPerBlock() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public int get_NumBlocks() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public int get_TotalECCodewords() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public ECB[] getECBlocks() { }

	}

	private static readonly Int32[] VERSION_DECODE_INFO; //Field offset: 0x0
	private static readonly Version[] VERSIONS; //Field offset: 0x8
	private readonly int versionNumber; //Field offset: 0x10
	private readonly Int32[] alignmentPatternCenters; //Field offset: 0x18
	private readonly ECBlocks[] ecBlocks; //Field offset: 0x20
	private readonly int totalCodewords; //Field offset: 0x28

	public Int32[] AlignmentPatternCenters
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int DimensionForVersion
	{
		[CalledBy(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
		[CallerCount(Count = 2)]
		 get { } //Length: 11
	}

	public int TotalCodewords
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int VersionNumber
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Version), Member = "buildVersions", ReturnType = typeof(Version[]))]
	[CallsUnknownMethods(Count = 2)]
	private static Version() { }

	[CalledBy(Type = typeof(Version), Member = "buildVersions", ReturnType = typeof(Version[]))]
	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Version(int versionNumber, Int32[] alignmentPatternCenters, ECBlocks[] ecBlocks) { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readCodewords", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "setRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal BitMatrix buildFunctionPattern() { }

	[CalledBy(Type = typeof(Version), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32[]), typeof(ECBlocks[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 448)]
	[CallsUnknownMethods(Count = 600)]
	private static Version[] buildVersions() { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FormatInformation), Member = "numBitsDiffering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Version), Member = "getVersionForNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[CallsUnknownMethods(Count = 2)]
	internal static Version decodeVersionInformation(int versionBits) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Int32[] get_AlignmentPatternCenters() { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
	[CallerCount(Count = 2)]
	public int get_DimensionForVersion() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_TotalCodewords() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_VersionNumber() { }

	[CalledBy(Type = typeof(DataBlock), Member = "getDataBlocks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Version), typeof(ErrorCorrectionLevel)}, ReturnType = typeof(DataBlock[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ECBlocks getECBlocksForLevel(ErrorCorrectionLevel ecLevel) { }

	[CalledBy(Type = typeof(Detector), Member = "processFinderPatternInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FinderPatternInfo)}, ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Version), Member = "getVersionForNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	public static Version getProvisionalVersionForDimension(int dimension) { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readVersion", ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(Version), Member = "getProvisionalVersionForDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(Version), Member = "decodeVersionInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(Encoder), Member = "chooseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCorrectionLevel)}, ReturnType = typeof(Version))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Version getVersionForNumber(int versionNumber) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

