namespace UnityEngine.UIElements;

public struct StyleInt : IStyleValue<Int32>, IEquatable<StyleInt>
{
	private int m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x4

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override int value
	{
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		 get { } //Length: 12
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 10
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public StyleInt(StyleKeyword keyword) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	internal StyleInt(int v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleInt other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	public override int get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override void set_value(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

