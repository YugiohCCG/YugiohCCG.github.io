namespace System.IO.Compression;

internal sealed class InflaterManaged
{
	private static readonly Byte[] s_extraLengthBits; //Field offset: 0x0
	private static readonly Int32[] s_lengthBase; //Field offset: 0x8
	private static readonly Int32[] s_distanceBasePosition; //Field offset: 0x10
	private static readonly Byte[] s_codeOrder; //Field offset: 0x18
	private static readonly Byte[] s_staticDistanceTreeTable; //Field offset: 0x20
	private readonly OutputWindow _output; //Field offset: 0x10
	private readonly InputBuffer _input; //Field offset: 0x18
	private HuffmanTree _literalLengthTree; //Field offset: 0x20
	private HuffmanTree _distanceTree; //Field offset: 0x28
	private InflaterState _state; //Field offset: 0x30
	private bool _hasFormatReader; //Field offset: 0x34
	private int _bfinal; //Field offset: 0x38
	private BlockType _blockType; //Field offset: 0x3C
	private readonly Byte[] _blockLengthBuffer; //Field offset: 0x40
	private int _blockLength; //Field offset: 0x48
	private int _length; //Field offset: 0x4C
	private int _distanceCode; //Field offset: 0x50
	private int _extraBits; //Field offset: 0x54
	private int _loopCounter; //Field offset: 0x58
	private int _literalLengthCodeCount; //Field offset: 0x5C
	private int _distanceCodeCount; //Field offset: 0x60
	private int _codeLengthCodeCount; //Field offset: 0x64
	private int _codeArraySize; //Field offset: 0x68
	private int _lengthCode; //Field offset: 0x6C
	private readonly Byte[] _codeList; //Field offset: 0x70
	private readonly Byte[] _codeLengthTreeCodeLength; //Field offset: 0x78
	private readonly bool _deflate64; //Field offset: 0x80
	private HuffmanTree _codeLengthTree; //Field offset: 0x88
	private IFileFormatReader _formatReader; //Field offset: 0x90

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static InflaterManaged() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	internal InflaterManaged(IFileFormatReader reader, bool deflate64) { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Inflate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputBuffer), Member = "EnsureBitsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBuffer), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InflaterManaged), Member = "DecodeUncompressedBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InflaterManaged), Member = "DecodeBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InflaterManaged), Member = "DecodeDynamicBlockHeader", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	private bool Decode() { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HuffmanTree), Member = "GetNextSymbol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBuffer)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputBuffer), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OutputWindow), Member = "WriteLengthDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutputWindow), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private bool DecodeBlock(out bool end_of_block_code_seen) { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private bool DecodeDynamicBlockHeader() { }

	[CalledBy(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputBuffer), Member = "EnsureBitsAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OutputWindow), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBuffer), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidDataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	private bool DecodeUncompressedBlock(out bool end_of_block) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Finished() { }

	[CalledBy(Type = "System.IO.Compression.DeflateManagedStream+<ReadAsyncCore>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeflateManagedStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DeflateManagedStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InflaterManaged), Member = "Decode", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int Inflate(Byte[] bytes, int offset, int length) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetInput(Byte[] inputBytes, int offset, int length) { }

}

