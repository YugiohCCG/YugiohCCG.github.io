namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Input/Virtual Mouse")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/UISupport.html#virtual-mouse-cursor-control")]
public class VirtualMouseInput : MonoBehaviour
{
	internal enum CursorMode
	{
		SoftwareCursor = 0,
		HardwareCursorIfAvailable = 1,
	}

	[Header("Cursor")]
	[SerializeField]
	[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
	private CursorMode m_CursorMode; //Field offset: 0x20
	[SerializeField]
	[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
	private Graphic m_CursorGraphic; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
	private RectTransform m_CursorTransform; //Field offset: 0x30
	[Header("Motion")]
	[SerializeField]
	[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
	private float m_CursorSpeed; //Field offset: 0x38
	[SerializeField]
	[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
	private float m_ScrollSpeed; //Field offset: 0x3C
	[SerializeField]
	[Space(10)]
	[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
	private InputActionProperty m_StickAction; //Field offset: 0x40
	[SerializeField]
	[Tooltip("Button action that triggers a left-click on the mouse.")]
	private InputActionProperty m_LeftButtonAction; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Button action that triggers a middle-click on the mouse.")]
	private InputActionProperty m_MiddleButtonAction; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Button action that triggers a right-click on the mouse.")]
	private InputActionProperty m_RightButtonAction; //Field offset: 0x88
	[SerializeField]
	[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
	private InputActionProperty m_ForwardButtonAction; //Field offset: 0xA0
	[SerializeField]
	[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
	private InputActionProperty m_BackButtonAction; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
	private InputActionProperty m_ScrollWheelAction; //Field offset: 0xD0
	private Canvas m_Canvas; //Field offset: 0xE8
	private CanvasScaler m_CanvasScaler; //Field offset: 0xF0
	private Mouse m_VirtualMouse; //Field offset: 0xF8
	private Mouse m_SystemMouse; //Field offset: 0x100
	private Action m_AfterInputUpdateDelegate; //Field offset: 0x108
	private Action<CallbackContext> m_ButtonActionTriggeredDelegate; //Field offset: 0x110
	private double m_LastTime; //Field offset: 0x118
	private Vector2 m_LastStickValue; //Field offset: 0x120

	public InputActionProperty backButtonAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 268
	}

	public Graphic cursorGraphic
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualMouseInput), Member = "TryFindCanvas", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 37
	}

	public CursorMode cursorMode
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 258
	}

	public float cursorSpeed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public RectTransform cursorTransform
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public InputActionProperty forwardButtonAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 268
	}

	public InputActionProperty leftButtonAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 253
	}

	public InputActionProperty middleButtonAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 24
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 259
	}

	public InputActionProperty rightButtonAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 268
	}

	public float scrollSpeed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public InputActionProperty scrollWheelAction
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		 set { } //Length: 48
	}

	public InputActionProperty stickAction
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
		 set { } //Length: 45
	}

	public Mouse virtualMouse
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public VirtualMouseInput() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_backButtonAction() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Graphic get_cursorGraphic() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CursorMode get_cursorMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_cursorSpeed() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public RectTransform get_cursorTransform() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_forwardButtonAction() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_leftButtonAction() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_middleButtonAction() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_rightButtonAction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_scrollSpeed() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_scrollWheelAction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionProperty get_stickAction() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Mouse get_virtualMouse() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualMouseInput), Member = "UpdateMotion", ReturnType = typeof(void))]
	private void OnAfterInputUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CopyState", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TState&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(MouseState), Member = "WithButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButton), typeof(bool)}, ReturnType = typeof(MouseState))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(MouseState), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnButtonActionTriggered(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mouse), Member = "WarpCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "TryFindCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputDevice))]
	[Calls(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	protected void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_backButtonAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualMouseInput), Member = "TryFindCanvas", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_cursorGraphic(Graphic value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "EnableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "TryEnableHardwareCursor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_cursorMode(CursorMode value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_cursorSpeed(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_cursorTransform(RectTransform value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_forwardButtonAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_leftButtonAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_middleButtonAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_rightButtonAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_scrollSpeed(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	public void set_scrollWheelAction(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualMouseInput), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty&), typeof(InputActionProperty)}, ReturnType = typeof(void))]
	public void set_stickAction(InputActionProperty value) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_stickAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_leftButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_rightButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_middleButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_forwardButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_backButtonAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_scrollWheelAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetAction(ref InputActionProperty field, InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_started", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	private static void SetActionCallback(InputActionProperty field, Action<CallbackContext> callback, bool install = true) { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_cursorMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputDevice), Member = "get_native", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "DisableDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "get_value", ReturnType = typeof(Vector2&))]
	[Calls(Type = typeof(Mouse), Member = "WarpCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void TryEnableHardwareCursor() { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "set_cursorGraphic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Graphic)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	private void TryFindCanvas() { }

	[CalledBy(Type = typeof(VirtualMouseInput), Member = "OnAfterInputUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "get_value", ReturnType = typeof(Vector2&))]
	[Calls(Type = typeof(InputState), Member = "Change", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Vector2), typeof(InputUpdateType), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mouse), Member = "WarpCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void UpdateMotion() { }

}

