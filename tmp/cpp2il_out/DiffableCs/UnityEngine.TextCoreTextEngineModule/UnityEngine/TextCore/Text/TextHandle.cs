namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("{settings.text}")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextHandle
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TextGenerationSettings> <>9__4_0; //Field offset: 0x8
		public static Func<TextGenerator> <>9__4_1; //Field offset: 0x10
		public static Func<TextInfo> <>9__4_2; //Field offset: 0x18
		public static Func<TextGenerationSettings> <>9__7_0; //Field offset: 0x20
		public static Func<TextGenerator> <>9__10_0; //Field offset: 0x28
		public static Func<TextInfo> <>9__13_0; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		internal TextGenerator <get_generators>b__10_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextGenerationSettings), Member = ".ctor", ReturnType = typeof(void))]
		internal TextGenerationSettings <get_settingsArray>b__7_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
		internal TextInfo <get_textInfosCommon>b__13_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextGenerationSettings), Member = ".ctor", ReturnType = typeof(void))]
		internal TextGenerationSettings <InitThreadArrays>b__4_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		internal TextGenerator <InitThreadArrays>b__4_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", ReturnType = typeof(void))]
		internal TextInfo <InitThreadArrays>b__4_2() { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandleTemporaryCache s_TemporaryCache; //Field offset: 0x0
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static TextHandlePermanentCache s_PermanentCache; //Field offset: 0x8
	private static TextGenerationSettings[] s_Settings; //Field offset: 0x10
	private static TextGenerator[] s_Generators; //Field offset: 0x18
	private static TextInfo[] s_TextInfosCommon; //Field offset: 0x20
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal NativeTextGenerationSettings nativeSettings; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <preferredSize>k__BackingField; //Field offset: 0x70
	private Rect m_ScreenRect; //Field offset: 0x78
	private float m_LineHeightDefault; //Field offset: 0x88
	private bool m_IsPlaceholder; //Field offset: 0x8C
	protected bool m_IsEllided; //Field offset: 0x8D
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal IntPtr textGenerationInfo; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LinkedListNode<TextInfo> <TextInfoNode>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsCachedPermanent>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <IsCachedTemporary>k__BackingField; //Field offset: 0xA1
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal int m_PreviousGenerationSettingsHash; //Field offset: 0xA4
	protected bool isDirty; //Field offset: 0xA8

	internal int characterCount
	{
		[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_m_CharacterCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_characterCount", ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 64
	}

	private static TextGenerator generator
	{
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private get { } //Length: 519
	}

	internal static TextGenerator[] generators
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 455
	}

	internal bool IsCachedPermanent
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal bool IsCachedTemporary
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	public override bool IsPlaceholder
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Vector2 preferredSize
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 19
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 5
	}

	internal static TextGenerationSettings settings
	{
		[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = "UnityEngine.IMGUITextHandle")]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUIStyle", Member = "get_lineHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
		[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(RenderedText&), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 519
	}

	internal static TextGenerationSettings[] settingsArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 455
	}

	internal TextInfo textInfo
	{
		[CallerCount(Count = 65)]
		[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 110
	}

	internal static TextInfo textInfoCommon
	{
		[CalledBy(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 519
	}

	internal LinkedListNode<TextInfo> TextInfoNode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal static TextInfo[] textInfosCommon
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 455
	}

	internal bool useAdvancedText
	{
		[CallerCount(Count = 82)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
		internal get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private static TextHandle() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeTextGenerationSettings), Member = "get_Default", ReturnType = typeof(NativeTextGenerationSettings))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TextHandle() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "AddTextInfoToPermanentCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override void AddTextInfoToPermanentCache() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddTextInfoToTemporaryCache(int hashCode) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetVertexPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasPadding", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "RemoveTextInfoFromTemporaryCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandlePermanentCache), Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "LinkTagOnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerMoveEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "FindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_m_CharacterCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_characterCount", ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal int get_characterCount() { }

	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static TextGenerator get_generator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static TextGenerator[] get_generators() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsCachedPermanent() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_IsCachedTemporary() { }

	[CallerCount(Count = 0)]
	public override bool get_IsPlaceholder() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Vector2 get_preferredSize() { }

	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(RenderedText&), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextHandle), Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "get_lineHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect), "UnityEngine.TextCore.Text.MeshInfoBindings[]&", typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle", typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static TextGenerationSettings get_settings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static TextGenerationSettings[] get_settingsArray() { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo get_textInfo() { }

	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal static TextInfo get_textInfoCommon() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal LinkedListNode<TextInfo> get_TextInfoNode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static TextInfo[] get_textInfosCommon() { }

	[CallerCount(Count = 82)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool get_useAdvancedText() { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetCharacterHeightFromIndex(int index) { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "get_stringCursorIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "get_stringSelectIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteWordBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteWordForward", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "Delete", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "Backspace", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteSelection", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetCorrespondingStringIndex(int index) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveCursorToPosition_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "GetCursorIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.get_cursorPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetEndOfPreviousWord(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetFirstCharacterIndexOnLine(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectionService), Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "GetGraphicalLineEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetLastCharacterIndexOnLine(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetLineHeight(int lineNumber) { }

	[CalledBy(Type = "UnityEngine.GUIStyle", Member = "get_lineHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUIStyle"}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "DeleteLineBack", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public int GetLineNumber(int index) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetStartOfNextWord(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "IndexOfEndOfLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public int IndexOf(char value, int startIndex) { }

	[CalledBy(Type = typeof(TextHandle), Member = "InitThreadArrays", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_settingsArray", ReturnType = typeof(TextGenerationSettings[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_generators", ReturnType = typeof(TextGenerator[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfosCommon", ReturnType = typeof(TextInfo[]))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[CalledBy(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(JobsUtility), Member = "get_ThreadIndexCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static void InitArray(ref T[] array, Func<T> createInstance) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "InitArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", "System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void InitThreadArrays() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal override bool IsAdvancedTextEnabledForElement() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsDirty(int hashCode) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public int LastIndexOf(char value, int startIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectOp"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectDown", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveDown", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "LineDownCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int LineDownCharacterPosition(int originalLogicalPos) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextSelectOp"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectUp", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveUp", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextInfo), Member = "LineUpCharacterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public int LineUpCharacterPosition(int originalLogicalPos) { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "Delete", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveWordRight", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindNextSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindStartOfNextWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.TextSelectingUtilities+Direction"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "NextCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int NextCodePointIndex(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem+PrepareTextJobData", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "PrepareFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool PrepareFontAsset() { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveLeft", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindPrevSeperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfPreviousWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "FindEndOfClassification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.TextSelectingUtilities+Direction"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "PreviousCodePointIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int PreviousCodePointIndex(int currentIndex) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "HandleATag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "HandleLinkTag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEditingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "HandleLinkTag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "HandleATag", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "OnDetachFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DetachFromPanelEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(TextHandlePermanentCache), Member = "RemoveTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveTextInfoFromPermanentCache() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "OnDetachFromPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DetachFromPanelEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveTextInfoFromTemporaryCache() { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentParagraph", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectCurrentWord", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToEndOfParagraph(ref int cursorIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphForward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphForward", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToNextParagraph(ref int cursorIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectParagraphBackward", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "MoveParagraphBackward", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToPreviousParagraph(ref int cursorIndex) { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "SelectToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectToStartOfParagraph(ref int cursorIndex) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_IsCachedPermanent(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_IsCachedTemporary(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_preferredSize(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_TextInfoNode(LinkedListNode<TextInfo> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetDirty() { }

	[CalledBy(Type = "UnityEngine.TextSelectingUtilities", Member = "get_selectedText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSelectionService), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public string Substring(int startIndex, int length) { }

	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo Update() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "PrepareTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateCurrentFrame() { }

	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal void UpdatePreferredSize() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "MeasureVisualElementTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(RenderedText&), typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfoCommon", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeSettingsAndUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandle), Member = "Update", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandlePermanentCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextHandleTemporaryCache), Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextHandle), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(bool), typeof(Boolean&)}, ReturnType = "UnityEngine.IMGUITextHandle")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextHandle), Member = "get_textInfo", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(TextHandle), Member = "get_generator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.Character>))]
	[Calls(Type = typeof(TextHandle), Member = "get_settings", ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(FontAsset), Member = "get_faceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TextGenerator), Member = "get_isTextTruncated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal TextInfo UpdateWithHash(int hashCode) { }

}

