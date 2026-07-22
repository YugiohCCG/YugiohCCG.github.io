namespace TMPro;

public struct TMP_Offset
{
	private static readonly TMP_Offset k_ZeroOffset; //Field offset: 0x0
	private float m_Left; //Field offset: 0x0
	private float m_Right; //Field offset: 0x4
	private float m_Top; //Field offset: 0x8
	private float m_Bottom; //Field offset: 0xC

	public float bottom
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float horizontal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 10
	}

	public float left
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float right
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float top
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float vertical
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	public static TMP_Offset zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 90
	}

	[CallerCount(Count = 0)]
	private static TMP_Offset() { }

	[CallerCount(Count = 0)]
	public TMP_Offset(float horizontal, float vertical) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public TMP_Offset(float left, float right, float top, float bottom) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Equals(TMP_Offset other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_bottom() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_horizontal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_left() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_right() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_top() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_vertical() { }

	[CallerCount(Count = 0)]
	public static TMP_Offset get_zero() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	[CallerCount(Count = 33)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_bottom(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_horizontal(float value) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_left(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_right(float value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_top(float value) { }

	[CallerCount(Count = 0)]
	public void set_vertical(float value) { }

}

