namespace UnityEngine.UIElements;

public struct StyleBackground : IStyleValue<Background>, IEquatable<StyleBackground>
{
	private Background m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x20

	public override StyleKeyword keyword
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override Background value
	{
		[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Sprite))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(VectorImage))]
		[CallerCount(Count = 16)]
		 get { } //Length: 41
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 43
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleBackground(Texture2D v, StyleKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public StyleBackground(Background v) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	public StyleBackground(Texture2D v) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	public StyleBackground(Sprite v) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage&)}, ReturnType = typeof(StyleBackground))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "FromVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	public StyleBackground(VectorImage v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public StyleBackground(StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal StyleBackground(Background v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleBackground(Sprite v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "FromVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(Background))]
	[CallsUnknownMethods(Count = 1)]
	internal StyleBackground(VectorImage v, StyleKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	public override bool Equals(StyleBackground other) { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public override StyleKeyword get_keyword() { }

	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackground)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty+<>c", Member = "<.ctor>b__0_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground&)}, ReturnType = typeof(VectorImage))]
	[CallerCount(Count = 16)]
	public override Background get_value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	public static bool op_Equality(StyleBackground lhs, StyleBackground rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static StyleBackground op_Implicit(StyleKeyword keyword) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override void set_keyword(StyleKeyword value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_value(Background value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleValueExtensions), Member = "DebugString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IStyleValue`1<T>"}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

