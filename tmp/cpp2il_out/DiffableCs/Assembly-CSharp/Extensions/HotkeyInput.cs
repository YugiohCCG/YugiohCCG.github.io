namespace Extensions;

public class HotkeyInput : MonoBehaviour
{
	public TextMeshProUGUI HKName; //Field offset: 0x20
	public TextMeshProUGUI HKValue; //Field offset: 0x28
	public Button HKButton; //Field offset: 0x30
	public bool AllowLMB; //Field offset: 0x38
	private Hotkeys HKS; //Field offset: 0x3C
	private HotkeyType HKType; //Field offset: 0x40
	private int KeyValue; //Field offset: 0x44

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HotkeyInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "ReadKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<Enumerator.HotkeyType, System.Int32>)}, ReturnType = typeof(void))]
	public void OnClick() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetName(string name) { }

	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start() { }

	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(MouseButton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(Key)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateHKData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HotkeyInput), Member = "UpdateHK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HotkeyType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "GetHotkeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Hotkey), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(HotkeyInput), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "get_HasMouse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_shortDisplayName", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateData(Hotkeys hks, int defVal, HotkeyType hkt) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	public void UpdateData(Hotkeys hks = 0, MouseButton defVal = 0) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "InitKeybinding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	public void UpdateData(Hotkeys hks = 0, Key defVal = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Helper), Member = "CloseScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkey), Member = "UpdateTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateHK(HotkeyType type, int val) { }

	[CalledBy(Type = typeof(SettingsMenu), Member = "ReloadHotkeys", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hotkey), Member = "UpdateTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HotkeyInput), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys), typeof(int), typeof(HotkeyType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateHKData(HotkeyType type, int val) { }

}

