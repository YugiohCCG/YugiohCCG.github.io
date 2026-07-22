namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

	}

	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	private GUIStyleState m_Normal; //Field offset: 0x18
	private GUIStyleState m_Hover; //Field offset: 0x20
	private GUIStyleState m_Active; //Field offset: 0x28
	private GUIStyleState m_Focused; //Field offset: 0x30
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	private GUIStyleState m_OnHover; //Field offset: 0x40
	private GUIStyleState m_OnActive; //Field offset: 0x48
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	private RectOffset m_Border; //Field offset: 0x58
	private RectOffset m_Padding; //Field offset: 0x60
	private RectOffset m_Margin; //Field offset: 0x68
	private RectOffset m_Overflow; //Field offset: 0x70
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	public TextAnchor alignment
	{
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
		[CalledBy(Type = "UnityEngine.Rendering.DebugUI+Table", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 152
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	public TextClipping clipping
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	public float fixedHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	public float fixedWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	public Font font
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 165
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	public int fontSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	public FontStyle fontStyle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	public ImagePosition imagePosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_ClipOffset", False, TargetType::Field (1))]
	internal Vector2 Internal_clipOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 156
	}

	public float lineHeight
	{
		[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
		[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 284
	}

	public RectOffset margin
	{
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginLeft", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginRight", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginTop", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginBottom", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 238
	}

	public string name
	{
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 63
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 53
	}

	public static GUIStyle none
	{
		[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 177
	}

	public GUIStyleState normal
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 248
	}

	public RectOffset padding
	{
		[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 238
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	internal string rawName
	{
		[CalledBy(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(GUIStyle), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 277
		[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		internal set { } //Length: 449
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	public bool richText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	public bool stretchHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 155
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	public bool stretchWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	public bool wordWrap
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 139
	}

	[CallerCount(Count = 0)]
	private static GUIStyle() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+Table", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public GUIStyle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void EmptyManagedCache() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextAnchor get_alignment() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextClipping get_clipping() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_fixedHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_fixedWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Font get_font() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_fontSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public FontStyle get_fontStyle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public ImagePosition get_imagePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Vector2 get_Internal_clipOffset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float get_lineHeight() { }

	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginLeft", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginRight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginTop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginBottom", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RectOffset get_margin() { }

	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public string get_name() { }

	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static GUIStyle get_none() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public GUIStyleState get_normal() { }

	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RectOffset get_padding() { }

	[CalledBy(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUIStyle), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	internal string get_rawName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_richText() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_stretchHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_stretchWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_wordWrap() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	internal static Font GetDefaultFont() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetDefaultFont_Injected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[RequiredByNativeCode]
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	private IntPtr GetStyleStatePtr(int idx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	[CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+Table", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_alignment(TextAnchor value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_name(string value) { }

	[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	internal void set_rawName(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_stretchHeight(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetDefaultFont_Injected(IntPtr font) { }

	[CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

}

