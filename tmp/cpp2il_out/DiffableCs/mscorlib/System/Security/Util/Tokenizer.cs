namespace System.Security.Util;

internal sealed class Tokenizer
{
	public interface ITokenReader
	{

		public int Read() { }

	}

	public class StreamTokenReader : ITokenReader
	{
		internal StreamReader _in; //Field offset: 0x10
		internal int _numCharRead; //Field offset: 0x18

		internal int NumCharEncountered
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal StreamTokenReader(StreamReader input) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal int get_NumCharEncountered() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override int Read() { }

	}

	public sealed class StringMaker
	{
		private String[] aStrings; //Field offset: 0x10
		private uint cStringsMax; //Field offset: 0x18
		private uint cStringsUsed; //Field offset: 0x1C
		public StringBuilder _outStringBuilder; //Field offset: 0x20
		public Char[] _outChars; //Field offset: 0x28
		public int _outIndex; //Field offset: 0x30

		[CalledBy(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public StringMaker() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 2)]
		private bool CompareStringAndChars(string str, Char[] a, int l) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static uint HashCharArray(Char[] a, int l) { }

		[CalledBy(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		private static uint HashString(string str) { }

		[CalledBy(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Tokenizer), Member = "GetStringToken", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(StringMaker), Member = "HashString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		public string MakeString() { }

	}

	private enum TokenSource
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6,
	}

	public int LineNo; //Field offset: 0x10
	private int _inProcessingTag; //Field offset: 0x14
	private Byte[] _inBytes; //Field offset: 0x18
	private Char[] _inChars; //Field offset: 0x20
	private string _inString; //Field offset: 0x28
	private int _inIndex; //Field offset: 0x30
	private int _inSize; //Field offset: 0x34
	private int _inSavedCharacter; //Field offset: 0x38
	private TokenSource _inTokenSource; //Field offset: 0x3C
	private ITokenReader _inTokenReader; //Field offset: 0x40
	private StringMaker _maker; //Field offset: 0x48
	private String[] _searchStrings; //Field offset: 0x50
	private String[] _replaceStrings; //Field offset: 0x58
	private int _inNestedIndex; //Field offset: 0x60
	private int _inNestedSize; //Field offset: 0x64
	private string _inNestedString; //Field offset: 0x68

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Tokenizer(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[CallsUnknownMethods(Count = 1)]
	internal void BasicInitialization() { }

	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal void ChangeFormat(Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string GetStringToken() { }

	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TokenizerStream), Member = "AddToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringMaker), Member = "MakeString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TokenizerStream), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 28)]
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringMaker&)}, ReturnType = typeof(void))]
	public void Recycle() { }

}

