namespace UnityEngine.UIElements;

public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	private Font m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Font value
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 13
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 30
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleFont(Font v) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public StyleFont(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal StyleFont(Font v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool Equals(StyleFont other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override Font get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleFont op_Implicit(StyleKeyword keyword) { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleFont op_Implicit(Font v) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_value(Font value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Object>)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

