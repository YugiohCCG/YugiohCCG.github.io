namespace UnityEngine.UIElements;

public struct StyleList : IStyleValue<List`1<T>>, IEquatable<StyleList`1<T>>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private List<T> m_Value; //Field offset: 0x0

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public override List<T> value
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 13
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 34
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public StyleList`1(StyleKeyword keyword) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal StyleList`1(List<T> v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(StyleList<T> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), "UnityEngine.UIElements.StyleList`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public override List<T> get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.EasingFunction>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.EasingFunction>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EasingFunction)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static bool op_Equality(StyleList<T> lhs, StyleList<T> rhs) { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "GetStyleList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = "UnityEngine.UIElements.StyleList`1<T>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static StyleList<T> op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_value(List<T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Object>)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

