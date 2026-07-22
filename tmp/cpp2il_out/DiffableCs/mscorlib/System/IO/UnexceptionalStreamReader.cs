namespace System.IO;

internal class UnexceptionalStreamReader : StreamReader
{
	private static Boolean[] newline; //Field offset: 0x0
	private static char newlineChar; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	private static UnexceptionalStreamReader() { }

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	public UnexceptionalStreamReader(Stream stream, Encoding encoding) { }

	[CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool CheckEOL(char current) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int Peek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
	public virtual int Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnexceptionalStreamReader), Member = "CheckEOL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public virtual int Read(out Char[] dest_buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "ReadLine", ReturnType = typeof(string))]
	public virtual string ReadLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
	public virtual string ReadToEnd() { }

}

