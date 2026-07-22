namespace UnityEngine.InputForUI;

internal struct PointerState
{
	private static readonly DiscreteTime kClickDelay; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Button <LastPressedButton>k__BackingField; //Field offset: 0x0
	private ButtonsState _buttonsState; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DiscreteTime <NextPressTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <ClickCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <LastPosition>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <LastDisplayIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <LastPositionValid>k__BackingField; //Field offset: 0x20

	public ButtonsState ButtonsState
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public private int ClickCount
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private int LastDisplayIndex
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private Vector2 LastPosition
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 19
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	public bool LastPositionValid
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public private Button LastPressedButton
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	public private DiscreteTime NextPressTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "GetDoubleClickTime", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static PointerState() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ButtonsState get_ButtonsState() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_ClickCount() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_LastDisplayIndex() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public Vector2 get_LastPosition() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_LastPositionValid() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public Button get_LastPressedButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public DiscreteTime get_NextPressTime() { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnClickPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext", typeof(EventSource), typeof(Button)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PointerState), Member = "OnButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	public void OnButtonChange(DiscreteTime currentTime, Button button, bool previousState, bool newState) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	public void OnButtonDown(DiscreteTime currentTime, Button button) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerState), Member = "OnButtonChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(Button), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void OnButtonUp(DiscreteTime currentTime, Button button) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckPenEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(PenData&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "CheckMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	[CalledBy(Type = typeof(InputManagerProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	public void Reset() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_ClickCount(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LastDisplayIndex(int value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LastPosition(Vector2 value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_LastPositionValid(bool value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LastPressedButton(Button value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_NextPressTime(DiscreteTime value) { }

}

