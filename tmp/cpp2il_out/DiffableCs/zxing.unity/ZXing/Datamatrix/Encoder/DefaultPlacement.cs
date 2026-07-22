namespace ZXing.Datamatrix.Encoder;

public class DefaultPlacement
{
	private readonly string codewords; //Field offset: 0x10
	private readonly int numrows; //Field offset: 0x18
	private readonly int numcols; //Field offset: 0x1C
	private readonly Byte[] bits; //Field offset: 0x20

	public Byte[] Bits
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Numcols
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Numrows
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SupportClass), Member = "Fill", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DefaultPlacement(string codewords, int numcols, int numrows) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void corner1(int pos) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void corner2(int pos) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void corner3(int pos) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DefaultPlacement), Member = "module", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void corner4(int pos) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Byte[] get_Bits() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Numcols() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Numrows() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool getBit(int col, int row) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool hasBit(int col, int row) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "utah", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultPlacement), Member = "corner4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void module(int row, int col, int pos, int bit) { }

	[CalledBy(Type = typeof(DataMatrixWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultPlacement), Member = "corner1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultPlacement), Member = "corner2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultPlacement), Member = "corner3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultPlacement), Member = "corner4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultPlacement), Member = "utah", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void place() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void setBit(int col, int row, bool bit) { }

	[CalledBy(Type = typeof(DefaultPlacement), Member = "place", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DefaultPlacement), Member = "module", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private void utah(int row, int col, int pos) { }

}

