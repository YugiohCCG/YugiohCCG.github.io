namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(MouseState), isGenericTypeOfDevice = True)]
public class Mouse : Pointer, IInputStateCallbackReceiver
{
	[CompilerGenerated]
	private static Mouse <current>k__BackingField; //Field offset: 0x0
	internal static Mouse s_PlatformMouseDevice; //Field offset: 0x8
	[CompilerGenerated]
	private DeltaControl <scroll>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private ButtonControl <leftButton>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private ButtonControl <middleButton>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private ButtonControl <rightButton>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private ButtonControl <backButton>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private ButtonControl <forwardButton>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private IntegerControl <clickCount>k__BackingField; //Field offset: 0x1F0

	public ButtonControl backButton
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

	public IntegerControl clickCount
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

	public private static Mouse current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public ButtonControl forwardButton
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

	public ButtonControl leftButton
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ButtonControl middleButton
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

	public ButtonControl rightButton
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

	public DeltaControl scroll
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

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Mouse() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(Pointer), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_backButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_clickCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Mouse get_current() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_forwardButton() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_leftButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_middleButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_rightButton() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DeltaControl get_scroll() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_native", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnAdded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected void OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "OnRemoved", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CalledBy(Type = typeof(Mouse), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastMouse), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FastMouse), Member = "UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputControl), Member = "get_currentStatePtr", ReturnType = typeof(Void*))]
	[Calls(Type = typeof(InputControlExtensions), Member = "AccumulateValueInEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), typeof(Void*), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputEventPtr), typeof(InputUpdateType)}, ReturnType = typeof(void))]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_backButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_clickCount(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(Mouse value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_forwardButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_leftButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_middleButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_rightButton(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_scroll(DeltaControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Pointer), Member = "OnNextUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mouse), Member = "OnStateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr)}, ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "UpdateMotion", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WarpMousePositionCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(WarpMousePositionCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WarpMousePositionCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WarpMousePositionCommand&)}, ReturnType = typeof(long))]
	public void WarpCursorPosition(Vector2 position) { }

}

