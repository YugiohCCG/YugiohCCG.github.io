namespace UnityEngine.UIElements;

internal class UITKTextHandle : TextHandle
{
	private static TextLib s_TextLib; //Field offset: 0x0
	internal static readonly float k_MinPadding; //Field offset: 0x8
	internal ATGTextEventHandler m_ATGTextEventHandler; //Field offset: 0xB0
	private List<ValueTuple`3<Int32, TagType, String>> m_Links; //Field offset: 0xB8
	internal Color atgHyperlinkColor; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <MeasuredSizes>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <RoundedSizes>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <ATGMeasuredSizes>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <ATGRoundedSizes>k__BackingField; //Field offset: 0xE8
	internal TextEventHandler m_TextEventHandler; //Field offset: 0xF0
	protected TextElement m_TextElement; //Field offset: 0xF8
	private bool wasAdvancedTextEnabledForElement; //Field offset: 0x100

	public Vector2 ATGMeasuredSizes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Vector2 ATGRoundedSizes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public virtual bool IsPlaceholder
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 62
	}

	private List<ValueTuple`3<Int32, TagType, String>> Links
	{
		[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
		[CalledBy(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 132
	}

	public Vector2 MeasuredSizes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Vector2 RoundedSizes
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	protected private TextLib textLib
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
		private get { } //Length: 94
	}

	[CallerCount(Count = 0)]
	private static UITKTextHandle() { }

	[CalledBy(Type = typeof(TextElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public UITKTextHandle(TextElement te) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddTextInfoToPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Create", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[Calls(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void AddTextInfoToPermanentCache() { }

	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "HyperlinkOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextEventHandler), Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal ValueTuple<TagType, String> ATGFindIntersectingLink(Vector2 point) { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextUtilities), Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement), typeof(RenderedText&), typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "MeasureText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.NativeTextGenerationSettings", typeof(IntPtr)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void ComputeNativeTextSize(in RenderedText textToMeasure, float width, float height) { }

	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "UpdateLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenTextEditorEventHandler), Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddTextInfoToTemporaryCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void ComputeSettingsAndUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_renderedText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.RenderedText"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 ComputeTextSize(in RenderedText textToMeasure, float width, float height) { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "GetVerticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.VerticalAlignment")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(LanguageDirectionExtensions), Member = "toTextCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LanguageDirection)}, ReturnType = "UnityEngine.TextCore.LanguageDirection")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "GetHorizontalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.HorizontalAlignment")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(TextSettings), Member = "get_nativeTextSettings", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
	[Calls(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal bool ConvertUssToNativeTextGenerationSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityParagraphSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_wordSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_letterSpacing", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_whiteSpace", ReturnType = typeof(WhiteSpace))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyAlignmentToNewAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.Text.TextAlignment")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextAlign", ReturnType = typeof(TextAnchor))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityFontStyleAndWeight", ReturnType = typeof(FontStyle))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_renderedText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.RenderedText"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "get_renderedText", ReturnType = "UnityEngine.TextCore.Text.RenderedText")]
	[Calls(Type = "UnityEngine.TextCore.Text.RenderedText", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(TextUtilities), Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextSettingsFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(TextSettings))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal override bool ConvertUssToTextGenerationSettings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2 get_ATGMeasuredSizes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public Vector2 get_ATGRoundedSizes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextElement), Member = "get_showPlaceholderText", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsPlaceholder() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private List<ValueTuple`3<Int32, TagType, String>> get_Links() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2 get_MeasuredSizes() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector2 get_RoundedSizes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	protected private TextLib get_textLib() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private TextAsset GetICUAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static TextAsset GetICUAssetStaticFalback() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textOverflow", ReturnType = typeof(TextOverflow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_overflow", ReturnType = typeof(OverflowInternal))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private TextOverflowMode GetTextOverflowMode() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOutlineWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_textShadow", ReturnType = typeof(TextShadow))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_fontSize", ReturnType = typeof(Length))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPadding", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal float GetVertexPadding(FontAsset fontAsset) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void HandleATag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	public void HandleLinkAndATagCallbacks() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void HandleLinkTag() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateATGTextEventHandler", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private ValueTuple<Boolean, Boolean> hasLinkAndHyperlink() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "get_textLib", ReturnType = "UnityEngine.TextCore.Text.TextLib")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UITKTextHandle), Member = "GetICUAsset", ReturnType = typeof(TextAsset))]
	[Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected private void InitTextLib() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsElided() { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessMeshInfos(NativeTextInfo textInfo) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextUtilities), Member = "IsAdvancedTextEnabledForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandlePermanentCache", Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 5)]
	internal void ReleaseResourcesIfPossible() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ATGMeasuredSizes(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ATGRoundedSizes(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_MeasuredSizes(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RoundedSizes(Vector2 value) { }

	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "OnGenerateTextOverNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextElement), Member = "UpdateVisibleText", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_unityTextOverflowPosition", ReturnType = typeof(TextOverflowPosition))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool TextLibraryCanElide() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "AddTextInfoToPermanentCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITKTextHandle), Member = "hasLinkAndHyperlink", ReturnType = typeof(System.ValueTuple`2<System.Boolean, System.Boolean>))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "RegisterLinkTagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "UnRegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = "RegisterHyperlinkCallbacks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateATGTextEventHandler() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "AddTextInfoToTemporaryCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateMesh() { }

	[CalledBy(Type = typeof(UITKTextHandle), Member = "AddTextInfoToPermanentCache", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem+GenerateTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITKTextHandle), Member = "ConvertUssToNativeTextGenerationSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UITKTextHandle), Member = "get_Links", ReturnType = typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>))]
	[Calls(Type = "UnityEngine.TextCore.RichTextTagParser", Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.NativeTextGenerationSettings", Member = "get_hasLink", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationInfo", Member = "Create", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ATGTextEventHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKTextHandle), Member = "InitTextLib", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextLib", Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.NativeTextGenerationSettings", typeof(IntPtr)}, ReturnType = "UnityEngine.TextCore.Text.NativeTextInfo")]
	[Calls(Type = typeof(System.ValueTuple`2<UnityEngine.TextCore.Text.NativeTextInfo, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public ValueTuple<NativeTextInfo, Boolean> UpdateNative(bool generateNativeSettings = true) { }

}

