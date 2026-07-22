namespace UnityEngine.UIElements;

public struct StyleBackgroundRepeat : IStyleValue<BackgroundRepeat>, IEquatable<StyleBackgroundRepeat>
{
	private BackgroundRepeat m_Value; //Field offset: 0x0
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

	public override BackgroundRepeat value
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 13
		[CallerCount(Count = 0)]
		 set { } //Length: 11
	}

	[CallerCount(Count = 0)]
	public StyleBackgroundRepeat(BackgroundRepeat v) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public StyleBackgroundRepeat(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	internal StyleBackgroundRepeat(BackgroundRepeat v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	public override bool Equals(StyleBackgroundRepeat other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override BackgroundRepeat get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	public static bool op_Equality(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public static StyleBackgroundRepeat op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	public override void set_value(BackgroundRepeat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

