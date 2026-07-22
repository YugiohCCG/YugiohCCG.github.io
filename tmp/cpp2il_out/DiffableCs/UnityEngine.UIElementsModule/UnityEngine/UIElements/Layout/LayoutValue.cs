namespace UnityEngine.UIElements.Layout;

internal struct LayoutValue
{
	private float value; //Field offset: 0x0
	private LayoutUnit unit; //Field offset: 0x4

	public LayoutUnit Unit
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public float Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[CallerCount(Count = 1)]
	public static LayoutValue Auto() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public bool Equals(LayoutValue other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public LayoutUnit get_Unit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static LayoutValue op_Implicit(float value) { }

	[CalledBy(Type = typeof(StyleValueExtensions), Member = "ToLayoutValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(LayoutValue))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static LayoutValue Percent(float value) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static LayoutValue Point(float value) { }

	[CallerCount(Count = 0)]
	public static LayoutValue Undefined() { }

}

