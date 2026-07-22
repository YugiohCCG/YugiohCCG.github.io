namespace UnityEngine.UIElements;

public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
{
	private Color m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x10

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Color value
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor&)}, ReturnType = typeof(Color32))]
		[CallerCount(Count = 3)]
		 get { } //Length: 62
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 14
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public StyleColor(Color v) { }

	[CallerCount(Count = 0)]
	public StyleColor(StyleKeyword keyword) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal StyleColor(Color v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleColor other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 59)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleColor)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor&)}, ReturnType = typeof(Color32))]
	[CallerCount(Count = 3)]
	public override Color get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	[CallerCount(Count = 0)]
	public static StyleColor op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public static StyleColor op_Implicit(Color v) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override void set_value(Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

