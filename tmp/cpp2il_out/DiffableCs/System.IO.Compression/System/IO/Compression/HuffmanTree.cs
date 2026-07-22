namespace System.IO.Compression;

internal sealed class HuffmanTree
{
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticLiteralLengthTree>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticDistanceTree>k__BackingField; //Field offset: 0x8
	private readonly int _tableBits; //Field offset: 0x10
	private readonly Int16[] _table; //Field offset: 0x18
	private readonly Int16[] _left; //Field offset: 0x20
	private readonly Int16[] _right; //Field offset: 0x28
	private readonly Byte[] _codeLengthArray; //Field offset: 0x30
	private readonly int _tableMask; //Field offset: 0x38

	public static HuffmanTree StaticDistanceTree
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static HuffmanTree StaticLiteralLengthTree
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HuffmanTree), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static HuffmanTree() { }

	[CalledBy(Type = typeof(HuffmanTree), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HuffmanTree), Member = "CreateTable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public HuffmanTree(Byte[] codeLengths) { }

	[CalledBy(Type = typeof(HuffmanTree), Member = "CreateTable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private UInt32[] CalculateHuffmanCode() { }

	[CalledBy(Type = typeof(HuffmanTree), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HuffmanTree), Member = "CalculateHuffmanCode", ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private void CreateTable() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static HuffmanTree get_StaticDistanceTree() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static HuffmanTree get_StaticLiteralLengthTree() { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public int GetNextSymbol(InputBuffer input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetStaticDistanceTreeLength() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetStaticLiteralTreeLength() { }

}

