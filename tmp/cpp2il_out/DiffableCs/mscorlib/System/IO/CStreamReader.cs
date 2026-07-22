namespace System.IO;

internal class CStreamReader : StreamReader
{
	private TermInfoDriver driver; //Field offset: 0x60

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public CStreamReader(Stream stream, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int Peek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Console), Member = "ReadKey", ReturnType = typeof(ConsoleKeyInfo))]
	public virtual int Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public virtual int Read(out Char[] dest, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadLine", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ReadToEnd() { }

}

