namespace System.Drawing;

public struct RectangleF : IEquatable<RectangleF>
{
	private float x; //Field offset: 0x0
	private float y; //Field offset: 0x4
	private float width; //Field offset: 0x8
	private float height; //Field offset: 0xC

	public float Height
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public float Width
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(RectangleF other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Height() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Width() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(RectangleF left, RectangleF right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

