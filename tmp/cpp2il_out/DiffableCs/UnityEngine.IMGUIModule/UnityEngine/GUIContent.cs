namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public class GUIContent
{
	private static readonly GUIContent s_Text; //Field offset: 0x0
	private static readonly GUIContent s_Image; //Field offset: 0x8
	private static readonly GUIContent s_TextImage; //Field offset: 0x10
	internal static string k_ZeroWidthSpace; //Field offset: 0x18
	public static GUIContent none; //Field offset: 0x20
	[SerializeField]
	private string m_Text; //Field offset: 0x10
	[SerializeField]
	private Texture m_Image; //Field offset: 0x18
	[SerializeField]
	private string m_Tooltip; //Field offset: 0x20
	[SerializeField]
	private string m_TextWithWhitespace; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action OnTextChanged; //Field offset: 0x30

	internal event Action OnTextChanged
	{
		[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 146
	}

	public Texture image
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string text
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory", Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel", "System.Action`2<Field`1<Int32>, Int32>"}, ReturnType = "UnityEngine.Rendering.DebugUI+EnumField")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 93
	}

	internal string textWithWhitespace
	{
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		internal get { } //Length: 110
		[CalledBy(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 123
	}

	public string tooltip
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static GUIContent() { }

	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public GUIContent(string text, Texture image, string tooltip) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+Foldout", Member = "get_rowContents", ReturnType = "System.Collections.Generic.List`1<GUIContent>")]
	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
	public GUIContent(string text, string tooltip) { }

	[CalledBy(Type = "UnityEngine.Rendering.CameraSwitcher", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+Styles", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+MaskField", Member = "Fill", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "<RegisterDebug>g__RefreshScenarioNames|42_75", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory", Member = "CreateMipMapDebugSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel"}, ReturnType = "UnityEngine.Rendering.DebugUI+Widget")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
	public GUIContent(string text) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory", Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel", "System.Action`2<Field`1<Int32>, Int32>"}, ReturnType = "UnityEngine.Rendering.DebugUI+EnumField")]
	[CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public GUIContent() { }

	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void add_OnTextChanged(Action value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ClearStaticCache() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	internal string get_textWithWhitespace() { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public string get_tooltip() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal void remove_OnTextChanged(Action value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_image(Texture value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsVolume+WidgetFactory", Member = "CreateComponentSelector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsVolume+SettingsPanel", "System.Action`2<Field`1<Int32>, Int32>"}, ReturnType = "UnityEngine.Rendering.DebugUI+EnumField")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_text(string value) { }

	[CalledBy(Type = typeof(GUIContent), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIContent))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal void set_textWithWhitespace(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_tooltip(string value) { }

	[CalledBy(Type = typeof(TextEditor), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnTextChangedHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "OnContentTextChangedHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetTextWithoutNotify(string value) { }

	[CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIContent), Member = "set_textWithWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static GUIContent Temp(string t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

