namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(KeyboardState), isGenericTypeOfDevice = True)]
public class Keyboard : InputDevice, ITextInputReceiver, IEventPreProcessor
{
	public const int KeyCount = 110; //Field offset: 0x0
	internal const int ExtendedKeyCount = 126; //Field offset: 0x0
	[CompilerGenerated]
	private static Keyboard <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AnyKeyControl <anyKey>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private ButtonControl <shiftKey>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private ButtonControl <ctrlKey>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private ButtonControl <altKey>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private ButtonControl <imeSelected>k__BackingField; //Field offset: 0x1B0
	private InlinedArray<Action`1<Char>> m_TextInputListeners; //Field offset: 0x1B8
	private string m_KeyboardLayoutName; //Field offset: 0x1D0
	private KeyControl[] m_Keys; //Field offset: 0x1D8
	private InlinedArray<Action`1<IMECompositionString>> m_ImeCompositionListeners; //Field offset: 0x1E0

	public event Action<IMECompositionString> onIMECompositionChange
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 216
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public event Action<Char> onTextInput
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 add { } //Length: 216
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 remove { } //Length: 76
	}

	public KeyControl aKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public ReadOnlyArray<KeyControl> allKeys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
		 get { } //Length: 86
	}

	public ButtonControl altKey
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public AnyKeyControl anyKey
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public KeyControl backquoteKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl backslashKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl backspaceKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl bKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl capsLockKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl cKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl commaKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl contextMenuKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public ButtonControl ctrlKey
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public private static Keyboard current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public KeyControl deleteKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit0Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit1Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit2Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit3Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit4Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit5Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit6Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit7Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit8Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl digit9Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl dKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl downArrowKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl eKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl endKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl enterKey
	{
		[CalledBy(Type = "Scenes.General.TextBox", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl equalsKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl escapeKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f10Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f11Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f12Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f13Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f14Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f15Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f16Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f17Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f18Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f19Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f1Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f20Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f21Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f22Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f23Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f24Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f2Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f3Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f4Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f5Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f6Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f7Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f8Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl f9Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl fKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl gKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl hKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl homeKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl iKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public ButtonControl imeSelected
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public KeyControl insertKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl Item
	{
		[CallerCount(Count = 143)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 233
	}

	public KeyControl jKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public string keyboardLayout
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "RefreshConfigurationIfNeeded", ReturnType = typeof(void))]
		 get { } //Length: 29
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	protected KeyControl[] keys
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public KeyControl kKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftAltKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftAppleKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl leftArrowKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftBracketKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftCommandKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl leftCtrlKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftMetaKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl leftShiftKey
	{
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "UpdateInputs", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl leftWindowsKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl lKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl mediaForward
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl mediaPlayPause
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl mediaRewind
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl minusKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl mKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl nKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numLockKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad0Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad1Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad2Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad3Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad4Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad5Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad6Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad7Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad8Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpad9Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadDivideKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadEnterKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadEqualsKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadMinusKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadMultiplyKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadPeriodKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl numpadPlusKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oem1Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oem2Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oem3Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oem4Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oem5Key
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl oKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl pageDownKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl pageUpKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl pauseKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl periodKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl pKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl printScreenKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl qKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl quoteKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightAltKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightAppleKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl rightArrowKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightBracketKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightCommandKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl rightCtrlKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightMetaKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl rightShiftKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl rightWindowsKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		[DeduplicatedMethod]
		 get { } //Length: 13
	}

	public KeyControl rKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl scrollLockKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl semicolonKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public ButtonControl shiftKey
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public KeyControl sKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl slashKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl spaceKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl tabKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl tKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl uKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl upArrowKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl vKey
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl wKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl xKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl yKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	public KeyControl zKey
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
		 get { } //Length: 13
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Keyboard() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onIMECompositionChange(Action<IMECompositionString> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void add_onTextInput(Action<Char> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputControl), Member = "get_displayName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public KeyControl FindKeyOnCurrentKeyboardLayout(string displayName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 140)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_aKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	public ReadOnlyArray<KeyControl> get_allKeys() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_altKey() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AnyKeyControl get_anyKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_backquoteKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_backslashKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_backspaceKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_bKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_capsLockKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_cKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_commaKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_contextMenuKey() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_ctrlKey() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Keyboard get_current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_deleteKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit0Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit1Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit2Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit3Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit4Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit5Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit6Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit7Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit8Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_digit9Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_dKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_downArrowKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_eKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_endKey() { }

	[CalledBy(Type = "Scenes.General.TextBox", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_enterKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_equalsKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_escapeKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f10Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f11Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f12Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f13Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f14Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f15Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f16Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f17Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f18Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f19Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f1Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f20Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f21Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f22Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f23Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f24Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f2Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f3Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f4Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f5Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f6Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f7Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f8Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_f9Key() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_fKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_gKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_hKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_homeKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_iKey() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_imeSelected() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_insertKey() { }

	[CallerCount(Count = 143)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public KeyControl get_Item(Key key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_jKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "RefreshConfigurationIfNeeded", ReturnType = typeof(void))]
	public string get_keyboardLayout() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected KeyControl[] get_keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_kKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_leftAltKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_leftAppleKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_leftArrowKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_leftBracketKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_leftCommandKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_leftCtrlKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_leftMetaKey() { }

	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "UpdateInputs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_leftShiftKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_leftWindowsKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_lKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_mediaForward() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_mediaPlayPause() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_mediaRewind() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_minusKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_mKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_nKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numLockKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad0Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad1Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad2Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad3Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad4Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad5Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad6Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad7Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad8Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpad9Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadDivideKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadEnterKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadEqualsKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadMinusKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadMultiplyKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadPeriodKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_numpadPlusKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oem1Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oem2Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oem3Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oem4Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oem5Key() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_oKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_pageDownKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_pageUpKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_pauseKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_periodKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_pKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_printScreenKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_qKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_quoteKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rightAltKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_rightAppleKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rightArrowKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rightBracketKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_rightCommandKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rightCtrlKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_rightMetaKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rightShiftKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	[DeduplicatedMethod]
	public KeyControl get_rightWindowsKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_rKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_scrollLockKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_semicolonKey() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_shiftKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_sKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_slashKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_spaceKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_tabKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_tKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_uKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_upArrowKey() { }

	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_vKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_wKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_xKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_yKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Keyboard), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(KeyControl))]
	public KeyControl get_zKey() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnIMECompositionChanged(IMECompositionString compositionString) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnTextInput(char character) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryKeyboardLayoutCommand), Member = "Create", ReturnType = typeof(QueryKeyboardLayoutCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryKeyboardLayoutCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryKeyboardLayoutCommand&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void RefreshConfiguration() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public void remove_onIMECompositionChange(Action<IMECompositionString> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public void remove_onTextInput(Action<Char> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_altKey(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_anyKey(AnyKeyControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_ctrlKey(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(Keyboard value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_imeSelected(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void set_keyboardLayout(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void set_keys(KeyControl[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_shiftKey(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetIMECursorPositionCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(SetIMECursorPositionCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetIMECursorPositionCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetIMECursorPositionCommand&)}, ReturnType = typeof(long))]
	public void SetIMECursorPosition(Vector2 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnableIMECompositionCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(EnableIMECompositionCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EnableIMECompositionCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EnableIMECompositionCommand&)}, ReturnType = typeof(long))]
	public void SetIMEEnabled(bool enabled) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(KeyboardState), Member = "get_Format", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(KeyboardState), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardState), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private override bool UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(InputEventPtr currentEventPtr) { }

}

