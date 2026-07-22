namespace ZXing.Datamatrix.Internal;

public sealed class Version
{
	public sealed class ECB
	{
		private readonly int count; //Field offset: 0x10
		private readonly int dataCodewords; //Field offset: 0x14

		internal int Count
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		internal int DataCodewords
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CallerCount(Count = 79)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ECB(int count, int dataCodewords) { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal int get_Count() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal int get_DataCodewords() { }

	}

	public sealed class ECBlocks
	{
		private readonly int ecCodewords; //Field offset: 0x10
		private readonly ECB[] _ecBlocksValue; //Field offset: 0x18

		internal ECB[] ECBlocksValue
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			internal get { } //Length: 5
		}

		internal int ECCodewords
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CalledBy(Type = typeof(Version), Member = "buildVersions", ReturnType = typeof(Version[]))]
		[CallerCount(Count = 29)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal ECBlocks(int ecCodewords, ECB ecBlocks) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal ECBlocks(int ecCodewords, ECB ecBlocks1, ECB ecBlocks2) { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal ECB[] get_ECBlocksValue() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal int get_ECCodewords() { }

	}

	private static readonly Version[] VERSIONS; //Field offset: 0x0
	private readonly int versionNumber; //Field offset: 0x10
	private readonly int symbolSizeRows; //Field offset: 0x14
	private readonly int symbolSizeColumns; //Field offset: 0x18
	private readonly int dataRegionSizeRows; //Field offset: 0x1C
	private readonly int dataRegionSizeColumns; //Field offset: 0x20
	private readonly ECBlocks ecBlocks; //Field offset: 0x28
	private readonly int totalCodewords; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "buildVersions", ReturnType = typeof(Version[]))]
	[CallsUnknownMethods(Count = 1)]
	private static Version() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Version(int versionNumber, int symbolSizeRows, int symbolSizeColumns, int dataRegionSizeRows, int dataRegionSizeColumns, ECBlocks ecBlocks) { }

	[CalledBy(Type = typeof(Version), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ECBlocks), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ECB)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 62)]
	[CallsUnknownMethods(Count = 65)]
	private static Version[] buildVersions() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int getDataRegionSizeColumns() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int getDataRegionSizeRows() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal ECBlocks getECBlocks() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int getSymbolSizeColumns() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int getSymbolSizeRows() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int getTotalCodewords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Version getVersionForDimensions(int numRows, int numColumns) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int getVersionNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

