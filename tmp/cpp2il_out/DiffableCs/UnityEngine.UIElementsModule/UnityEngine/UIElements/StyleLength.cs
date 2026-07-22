namespace UnityEngine.UIElements;

public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
{
	private Length m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		 set { } //Length: 73
	}

	public override Length value
	{
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		 set { } //Length: 51
	}

	[CalledBy(Type = typeof(AbstractProgressBar), Member = "CalculateOppositeProgressWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(StyleLength))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(StyleLength))]
	[CallerCount(Count = 3)]
	public StyleLength(float v) { }

	[CallerCount(Count = 0)]
	public StyleLength(Length v) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public StyleLength(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	internal StyleLength(Length v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleLength other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	public override Length get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 156)]
	public static StyleLength op_Implicit(float v) { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = "UpdateFill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	public static StyleLength op_Implicit(Length v) { }

	[CallerCount(Count = 0)]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	public override void set_value(Length value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

