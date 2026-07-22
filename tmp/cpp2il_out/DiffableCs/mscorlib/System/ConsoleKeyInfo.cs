namespace System;

[IsReadOnly]
public struct ConsoleKeyInfo
{
	private readonly char _keyChar; //Field offset: 0x0
	private readonly ConsoleKey _key; //Field offset: 0x4
	private readonly ConsoleModifiers _mods; //Field offset: 0x8

	public ConsoleKey Key
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public char KeyChar
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(NullConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConsoleKeyInfo))]
	[CallerCount(Count = 64)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Equals(ConsoleKeyInfo obj) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ConsoleKey get_Key() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public char get_KeyChar() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

}

