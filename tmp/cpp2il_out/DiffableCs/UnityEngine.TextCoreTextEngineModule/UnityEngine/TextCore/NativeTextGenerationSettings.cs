namespace UnityEngine.TextCore;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
[UsedByNativeCode("TextGenerationSettings")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct NativeTextGenerationSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TextSpan> <>9__20_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <get_hasLink>b__20_0(TextSpan span) { }

	}

	public IntPtr fontAsset; //Field offset: 0x0
	public IntPtr textSettings; //Field offset: 0x8
	public string text; //Field offset: 0x10
	public int screenWidth; //Field offset: 0x18
	public int screenHeight; //Field offset: 0x1C
	public WhiteSpace wordWrap; //Field offset: 0x20
	public TextOverflow overflow; //Field offset: 0x24
	public LanguageDirection languageDirection; //Field offset: 0x28
	public int vertexPadding; //Field offset: 0x2C
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal HorizontalAlignment horizontalAlignment; //Field offset: 0x30
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal VerticalAlignment verticalAlignment; //Field offset: 0x34
	public int fontSize; //Field offset: 0x38
	public FontStyles fontStyle; //Field offset: 0x3C
	public TextFontWeight fontWeight; //Field offset: 0x40
	public TextSpan[] textSpans; //Field offset: 0x48
	public Color32 color; //Field offset: 0x50
	public int characterSpacing; //Field offset: 0x54
	public int wordSpacing; //Field offset: 0x58
	public int paragraphSpacing; //Field offset: 0x5C

	public static NativeTextGenerationSettings Default
	{
		[CalledBy(Type = typeof(TextHandle), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		 get { } //Length: 79
	}

	public bool hasLink
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSpan)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSpan[]), typeof(System.Predicate`1<UnityEngine.TextCore.TextSpan>)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 290
	}

	[CallerCount(Count = 0)]
	[IsReadOnly]
	public TextSpan CreateTextSpan() { }

	[CalledBy(Type = typeof(TextHandle), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	public static NativeTextGenerationSettings get_Default() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Exists", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSpan)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextSpan[]), typeof(System.Predicate`1<UnityEngine.TextCore.TextSpan>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool get_hasLink() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(TextSpan), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public virtual string ToString() { }

}

