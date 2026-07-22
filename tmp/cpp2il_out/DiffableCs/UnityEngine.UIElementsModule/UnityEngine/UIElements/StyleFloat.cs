namespace UnityEngine.UIElements;

public struct StyleFloat : IStyleValue<Single>, IEquatable<StyleFloat>
{
	private float m_Value; //Field offset: 0x0
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

	public override float value
	{
		[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMinDimension", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMinDimension", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat&)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
		[CallerCount(Count = 12)]
		 get { } //Length: 15
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 12
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public StyleFloat(float v) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public StyleFloat(StyleKeyword keyword) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	internal StyleFloat(float v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleFloat other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_fixedPaneMinDimension", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "get_flexedPaneMinDimension", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFloat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	public override float get_value() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(BaseSlider`1), Member = "AdjustDragElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public static StyleFloat op_Implicit(float v) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public override void set_value(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.IStyleValue`1<System.Single>)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

