namespace UnityEngine.UIElements;

public struct StyleBackgroundPosition : IStyleValue<BackgroundPosition>, IEquatable<StyleBackgroundPosition>
{
	private BackgroundPosition m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0xC

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 118)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override BackgroundPosition value
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		 get { } //Length: 42
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 22
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StyleBackgroundPosition(BackgroundPosition v) { }

	[CallerCount(Count = 0)]
	public StyleBackgroundPosition(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal StyleBackgroundPosition(BackgroundPosition v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(StyleBackgroundPosition other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 118)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public override BackgroundPosition get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundPosition), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool op_Equality(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs) { }

	[CallerCount(Count = 0)]
	public static StyleBackgroundPosition op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void set_value(BackgroundPosition value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

