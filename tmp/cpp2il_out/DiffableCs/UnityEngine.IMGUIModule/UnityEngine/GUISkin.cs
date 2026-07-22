namespace UnityEngine;

[AssetFileNameExtension("guiskin", new IL2CPP_TYPE_STRING[] {})]
[ExecuteInEditMode]
[RequiredByNativeCode]
public sealed class GUISkin : ScriptableObject
{
	public sealed class SkinChangedDelegate : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SkinChangedDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	internal static GUIStyle ms_Error; //Field offset: 0x0
	internal static SkinChangedDelegate m_SkinChanged; //Field offset: 0x8
	internal static GUISkin current; //Field offset: 0x10
	[SerializeField]
	private Font m_Font; //Field offset: 0x18
	[SerializeField]
	private GUIStyle m_box; //Field offset: 0x20
	[SerializeField]
	private GUIStyle m_button; //Field offset: 0x28
	[SerializeField]
	private GUIStyle m_toggle; //Field offset: 0x30
	[SerializeField]
	private GUIStyle m_label; //Field offset: 0x38
	[SerializeField]
	private GUIStyle m_textField; //Field offset: 0x40
	[SerializeField]
	private GUIStyle m_textArea; //Field offset: 0x48
	[SerializeField]
	private GUIStyle m_window; //Field offset: 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; //Field offset: 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; //Field offset: 0x60
	private GUIStyle m_horizontalSliderThumbExtent; //Field offset: 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; //Field offset: 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; //Field offset: 0x78
	private GUIStyle m_verticalSliderThumbExtent; //Field offset: 0x80
	private GUIStyle m_SliderMixed; //Field offset: 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; //Field offset: 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; //Field offset: 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; //Field offset: 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; //Field offset: 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; //Field offset: 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; //Field offset: 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; //Field offset: 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; //Field offset: 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; //Field offset: 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; //Field offset: 0xD8
	[SerializeField]
	private GUISettings m_Settings; //Field offset: 0xE0
	private Dictionary<String, GUIStyle> m_Styles; //Field offset: 0xE8

	public GUIStyle box
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle button
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle[] customStyles
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	internal static GUIStyle error
	{
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 250
	}

	public Font font
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 400
	}

	public GUIStyle horizontalScrollbar
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarLeftButton
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarRightButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle horizontalScrollbarThumb
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle horizontalSlider
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle horizontalSliderThumb
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	internal GUIStyle horizontalSliderThumbExtent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 122
	}

	public GUIStyle label
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle scrollView
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUISettings settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
	}

	internal GUIStyle sliderMixed
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 128
	}

	public GUIStyle textArea
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle textField
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle toggle
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle verticalScrollbar
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarDownButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarThumb
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle verticalScrollbarUpButton
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 128
	}

	public GUIStyle verticalSlider
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	public GUIStyle verticalSliderThumb
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	internal GUIStyle verticalSliderThumbExtent
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 10
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 125
	}

	public GUIStyle window
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 122
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public GUISkin() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal void Apply() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 64)]
	private void BuildStyleCache() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void CleanupRoots() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public GUIStyle FindStyle(string styleName) { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public GUIStyle get_box() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_button() { }

	[CallerCount(Count = 0)]
	public GUIStyle[] get_customStyles() { }

	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static GUIStyle get_error() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public Font get_font() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public GUIStyle get_horizontalScrollbar() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_horizontalScrollbarRightButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_horizontalScrollbarThumb() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public GUIStyle get_horizontalSlider() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public GUIStyle get_horizontalSliderThumb() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public GUIStyle get_label() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_scrollView() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUISettings get_settings() { }

	[CallerCount(Count = 0)]
	internal GUIStyle get_sliderMixed() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public GUIStyle get_textArea() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public GUIStyle get_textField() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public GUIStyle get_toggle() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_verticalScrollbar() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_verticalScrollbarDownButton() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_verticalScrollbarThumb() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_verticalScrollbarUpButton() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_verticalSlider() { }

	[CallerCount(Count = 0)]
	public GUIStyle get_verticalSliderThumb() { }

	[CallerCount(Count = 0)]
	internal GUIStyle get_verticalSliderThumbExtent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GUIStyle get_window() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[CallsUnknownMethods(Count = 12)]
	public GUIStyle GetStyle(string styleName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_box(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_button(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_customStyles(GUIStyle[] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_font(Font value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalScrollbar(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalSlider(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_horizontalSliderThumb(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_label(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_scrollView(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_sliderMixed(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_textArea(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_textField(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_toggle(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalScrollbar(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalSlider(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_verticalSliderThumb(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_window(GUIStyle value) { }

}

