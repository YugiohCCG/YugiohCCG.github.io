namespace System.IO;

internal class UnexceptionalStreamWriter : StreamWriter
{

	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	public UnexceptionalStreamWriter(Stream stream, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Flush", ReturnType = typeof(void))]
	public virtual void Flush() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	public virtual void Write(char value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(void))]
	public virtual void Write(Char[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void Write(string value) { }

}

