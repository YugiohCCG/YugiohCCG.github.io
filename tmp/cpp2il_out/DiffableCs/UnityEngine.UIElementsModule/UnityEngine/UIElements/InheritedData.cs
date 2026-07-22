namespace UnityEngine.UIElements;

internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
{
	public Color color; //Field offset: 0x0
	public Length fontSize; //Field offset: 0x10
	public Length letterSpacing; //Field offset: 0x18
	public TextShadow textShadow; //Field offset: 0x20
	public EditorTextRenderingMode unityEditorTextRenderingMode; //Field offset: 0x3C
	public Font unityFont; //Field offset: 0x40
	public FontDefinition unityFontDefinition; //Field offset: 0x48
	public FontStyle unityFontStyleAndWeight; //Field offset: 0x58
	public Length unityParagraphSpacing; //Field offset: 0x5C
	public TextAnchor unityTextAlign; //Field offset: 0x64
	public TextGeneratorType unityTextGenerator; //Field offset: 0x68
	public Color unityTextOutlineColor; //Field offset: 0x6C
	public float unityTextOutlineWidth; //Field offset: 0x7C
	public Visibility visibility; //Field offset: 0x80
	public WhiteSpace whiteSpace; //Field offset: 0x84
	public Length wordSpacing; //Field offset: 0x88

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override InheritedData Copy() { }

	[CalledBy(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void CopyFrom(ref InheritedData other) { }

	[CalledBy(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>", "UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InheritedData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData), typeof(InheritedData)}, ReturnType = typeof(bool))]
	public override bool Equals(InheritedData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(StyleDataRef`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextShadow), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontDefinition), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

}

