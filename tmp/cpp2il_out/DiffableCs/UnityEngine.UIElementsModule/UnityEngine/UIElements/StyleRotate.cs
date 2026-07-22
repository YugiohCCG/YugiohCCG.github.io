namespace UnityEngine.UIElements;

public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
{
	private Rotate m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x18

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Rotate value
	{
		[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 353
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 24
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StyleRotate(Rotate v) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StyleRotate(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal StyleRotate(Rotate v, StyleKeyword keyword) { }

	[CalledBy(Type = typeof(StyleRotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleRotate other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleRotate), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(StyleRotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyInlineStyles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override Rotate get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public static StyleRotate op_Implicit(Rotate v) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void set_value(Rotate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

