namespace System.Drawing;

[DebuggerDisplay("{NameAndARGBValue}")]
[IsReadOnly]
public struct Color : IEquatable<Color>
{
	private readonly string name; //Field offset: 0x0
	private readonly long value; //Field offset: 0x8
	private readonly short knownColor; //Field offset: 0x10
	private readonly short state; //Field offset: 0x12

	public byte A
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
		 get { } //Length: 20
	}

	public byte B
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
		 get { } //Length: 7
	}

	public byte G
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
		 get { } //Length: 20
	}

	public bool IsKnownColor
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public string Name
	{
		[CalledBy(Type = typeof(Color), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KnownColorTable), Member = "InitColorNameTable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 247
	}

	public byte R
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
		 get { } //Length: 20
	}

	private long Value
	{
		[CalledBy(Type = typeof(Color), Member = "get_R", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(Color), Member = "get_G", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(Color), Member = "get_B", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(Color), Member = "get_A", ReturnType = typeof(byte))]
		[CalledBy(Type = typeof(Color), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(KnownColorTable), Member = "InitColorTable", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 182
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Equals(Color other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	public byte get_A() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	public byte get_B() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	public byte get_G() { }

	[CallerCount(Count = 0)]
	public bool get_IsKnownColor() { }

	[CalledBy(Type = typeof(Color), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorNameTable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	public byte get_R() { }

	[CalledBy(Type = typeof(Color), Member = "get_R", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Color), Member = "get_G", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Color), Member = "get_B", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Color), Member = "get_A", ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Color), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(KnownColorTable), Member = "InitColorTable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private long get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(short), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(Color left, Color right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "get_Value", ReturnType = typeof(long))]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Color), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

