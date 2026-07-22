namespace System.Drawing;

public struct Rectangle : IEquatable<Rectangle>
{
	private int x; //Field offset: 0x0
	private int y; //Field offset: 0x4
	private int width; //Field offset: 0x8
	private int height; //Field offset: 0xC

	public int Height
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int Width
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int X
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int Y
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Rectangle other) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_Height() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Width() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_X() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Y() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Rectangle left, Rectangle right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

