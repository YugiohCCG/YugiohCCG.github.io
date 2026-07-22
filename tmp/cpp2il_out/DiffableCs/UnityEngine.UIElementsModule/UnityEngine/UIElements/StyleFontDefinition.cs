namespace UnityEngine.UIElements;

public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition>
{
	private StyleKeyword m_Keyword; //Field offset: 0x0
	private FontDefinition m_Value; //Field offset: 0x8

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public override FontDefinition value
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(Font))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(FontAsset))]
		[CallerCount(Count = 8)]
		 get { } //Length: 26
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(FontDefinition))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleFontDefinition(object obj, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal StyleFontDefinition(FontDefinition f, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleFontDefinition(FontDefinition f) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset&)}, ReturnType = typeof(StyleFontDefinition))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontDefinition), Member = "FromSDFFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(FontDefinition))]
	[CallsUnknownMethods(Count = 1)]
	public StyleFontDefinition(FontAsset f) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font&)}, ReturnType = typeof(StyleFontDefinition))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontDefinition), Member = "FromFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontDefinition))]
	[CallsUnknownMethods(Count = 1)]
	public StyleFontDefinition(Font f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleFontDefinition(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromSDFFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(FontDefinition))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleFontDefinition(FontAsset f, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "FromFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontDefinition))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleFontDefinition(Font f, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(StyleFontDefinition other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleFontDefinition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(Font))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition&)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 8)]
	public override FontDefinition get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontDefinition), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleFontDefinition op_Implicit(StyleKeyword keyword) { }

	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_value(FontDefinition value) { }

}

