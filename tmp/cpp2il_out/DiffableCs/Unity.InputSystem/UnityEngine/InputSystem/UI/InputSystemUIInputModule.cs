namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/UISupport.html#setting-up-ui-input")]
public class InputSystemUIInputModule : BaseInputModule
{
	internal enum CursorLockBehavior
	{
		OutsideScreen = 0,
		ScreenCenter = 1,
	}

	private struct InputActionReferenceState
	{
		public int refCount; //Field offset: 0x0
		public bool enabledByInputModule; //Field offset: 0x4

	}

	private const float kClickSpeed = 0.3; //Field offset: 0x0
	private const float kSmallestScrollDeltaPerTick = 1E-05; //Field offset: 0x0
	private static DefaultInputActions defaultActions; //Field offset: 0x0
	private static Dictionary<InputAction, InputActionReferenceState> s_InputActionReferenceCounts; //Field offset: 0x8
	[FormerlySerializedAs("m_RepeatDelay")]
	[SerializeField]
	[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
	private float m_MoveRepeatDelay; //Field offset: 0x58
	[FormerlySerializedAs("m_RepeatRate")]
	[SerializeField]
	[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
	private float m_MoveRepeatRate; //Field offset: 0x5C
	[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
	private float m_TrackedDeviceDragThresholdMultiplier; //Field offset: 0x60
	[SerializeField]
	[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig's Transform.")]
	private Transform m_XRTrackingOrigin; //Field offset: 0x68
	[HideInInspector]
	[SerializeField]
	private InputActionAsset m_ActionsAsset; //Field offset: 0x70
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_PointAction; //Field offset: 0x78
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_MoveAction; //Field offset: 0x80
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_SubmitAction; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_CancelAction; //Field offset: 0x90
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_LeftClickAction; //Field offset: 0x98
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_MiddleClickAction; //Field offset: 0xA0
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_RightClickAction; //Field offset: 0xA8
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_ScrollWheelAction; //Field offset: 0xB0
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_TrackedDevicePositionAction; //Field offset: 0xB8
	[HideInInspector]
	[SerializeField]
	private InputActionReference m_TrackedDeviceOrientationAction; //Field offset: 0xC0
	[SerializeField]
	private bool m_DeselectOnBackgroundClick; //Field offset: 0xC8
	[SerializeField]
	private UIPointerBehavior m_PointerBehavior; //Field offset: 0xCC
	[HideInInspector]
	[SerializeField]
	internal CursorLockBehavior m_CursorLockBehavior; //Field offset: 0xD0
	[SerializeField]
	private float m_ScrollDeltaPerTick; //Field offset: 0xD4
	private bool m_ActionsHooked; //Field offset: 0xD8
	private bool m_NeedToPurgeStalePointers; //Field offset: 0xD9
	private Action<CallbackContext> m_OnPointDelegate; //Field offset: 0xE0
	private Action<CallbackContext> m_OnMoveDelegate; //Field offset: 0xE8
	private Action<CallbackContext> m_OnSubmitCancelDelegate; //Field offset: 0xF0
	private Action<CallbackContext> m_OnLeftClickDelegate; //Field offset: 0xF8
	private Action<CallbackContext> m_OnRightClickDelegate; //Field offset: 0x100
	private Action<CallbackContext> m_OnMiddleClickDelegate; //Field offset: 0x108
	private Action<CallbackContext> m_OnScrollWheelDelegate; //Field offset: 0x110
	private Action<CallbackContext> m_OnTrackedDevicePositionDelegate; //Field offset: 0x118
	private Action<CallbackContext> m_OnTrackedDeviceOrientationDelegate; //Field offset: 0x120
	private Action<Object> m_OnControlsChangedDelegate; //Field offset: 0x128
	private int m_CurrentPointerId; //Field offset: 0x130
	private int m_CurrentPointerIndex; //Field offset: 0x134
	internal UIPointerType m_CurrentPointerType; //Field offset: 0x138
	internal InlinedArray<Int32> m_PointerIds; //Field offset: 0x140
	internal InlinedArray<PointerModel> m_PointerStates; //Field offset: 0x150
	private NavigationModel m_NavigationState; //Field offset: 0x380
	private SubmitCancelModel m_SubmitCancelState; //Field offset: 0x3A8
	private GameObject m_LocalMultiPlayerRoot; //Field offset: 0x3B8

	public InputActionAsset actionsAsset
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(PlayerInput), Member = "set_uiInputModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSystemUIInputModule)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UnassignActions", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
		[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
		[Calls(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "HookActions", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 1717
	}

	public InputActionReference cancel
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public CursorLockBehavior cursorLockBehavior
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public bool deselectOnBackgroundClick
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	private bool explictlyIgnoreFocus
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 82
	}

	public InputActionReference leftClick
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	internal GameObject localMultiPlayerRoot
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 19
	}

	public InputActionReference middleClick
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public InputActionReference move
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public float moveRepeatDelay
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float moveRepeatRate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public InputActionReference point
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 50
	}

	public UIPointerBehavior pointerBehavior
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	[Obsolete("'repeatDelay' has been obsoleted; use 'moveRepeatDelay' instead. (UnityUpgradable) -> moveRepeatDelay", False)]
	public float repeatDelay
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[Obsolete("'repeatRate' has been obsoleted; use 'moveRepeatRate' instead. (UnityUpgradable) -> moveRepeatRate", False)]
	public float repeatRate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public InputActionReference rightClick
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public float scrollDeltaPerTick
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public InputActionReference scrollWheel
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	internal bool sendPointerHoverToParent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	private bool shouldIgnoreFocus
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 166
	}

	public InputActionReference submit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public float trackedDeviceDragThresholdMultiplier
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public InputActionReference trackedDeviceOrientation
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	public InputActionReference trackedDevicePosition
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
		 set { } //Length: 53
	}

	[Obsolete("'trackedDeviceSelect' has been obsoleted; use 'leftClick' instead.", True)]
	public InputActionReference trackedDeviceSelect
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public Transform xrTrackingOrigin
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static InputSystemUIInputModule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = ".ctor", ReturnType = typeof(void))]
	public InputSystemUIInputModule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ActivateModule() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Capacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Int32>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PointerModel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, InputControl touchControl = null) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIActions), Member = "get_TrackedDevicePosition", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_TrackedDeviceOrientation", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_ScrollWheel", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_Point", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_MiddleClick", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_RightClick", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_Click", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(UIActions), Member = "get_Navigate", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(UIActions), Member = "get_Cancel", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultInputActions), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	public void AssignDefaultActions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_canceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool CheckForRemovedDevice(ref CallbackContext context) { }

	[CallerCount(Count = 0)]
	public virtual Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "ConvertUIToolkitPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(int))]
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
	private void DisableAllActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	private void EnableAllActions() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "EnableAllActions", ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.UI.InputSystemUIInputModule+InputActionReferenceState>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionReferenceState)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.UI.InputSystemUIInputModule+InputActionReferenceState>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionReferenceState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnableInputAction(InputActionReference inputActionReference) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExtendedPointerEventData), Member = "ReadDeviceState", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerModel), Member = "CopyTouchOrPenStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SendPointerExitEventsAndRemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void FilterPointerStatesByType() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public InputActionAsset get_actionsAsset() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public InputActionReference get_cancel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CursorLockBehavior get_cursorLockBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_deselectOnBackgroundClick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_explictlyIgnoreFocus() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionReference get_leftClick() { }

	[CallerCount(Count = 0)]
	internal GameObject get_localMultiPlayerRoot() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public InputActionReference get_middleClick() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionReference get_move() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_moveRepeatDelay() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_moveRepeatRate() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public InputActionReference get_point() { }

	[CallerCount(Count = 0)]
	public UIPointerBehavior get_pointerBehavior() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_repeatDelay() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_repeatRate() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public InputActionReference get_rightClick() { }

	[CallerCount(Count = 0)]
	public float get_scrollDeltaPerTick() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public InputActionReference get_scrollWheel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_sendPointerHoverToParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 2)]
	private bool get_shouldIgnoreFocus() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InputActionReference get_submit() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_trackedDeviceDragThresholdMultiplier() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public InputActionReference get_trackedDeviceOrientation() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public InputActionReference get_trackedDevicePosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public InputActionReference get_trackedDeviceSelect() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public Transform get_xrTrackingOrigin() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private int GetDisplayIndexFor(InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[CallsUnknownMethods(Count = 1)]
	public RaycastResult GetLastRaycastResult(int pointerOrTouchId) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private PointerModel GetPointerStateForIndex(int index) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "IsPointerOverGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetLastRaycastResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RaycastResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[CallsUnknownMethods(Count = 1)]
	private int GetPointerStateIndexFor(int pointerOrTouchId) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(InputAction), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(PointerModel), Member = "set_screenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "AllocatePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(UIPointerType), typeof(InputControl), typeof(InputDevice), typeof(InputControl)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel&))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector2>), Member = "get_value", ReturnType = typeof(Vector2&))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "get_value", ReturnType = typeof(Int32&))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnLeftClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnRightClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnMiddleClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnScrollCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnTrackedDeviceOrientationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnTrackedDevicePositionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CallbackContext), Member = "get_canceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_phase", ReturnType = typeof(InputActionPhase))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private int GetPointerStateIndexFor(ref CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[ContainsUnimplementedInstructions]
	private bool HasNoActions() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "PurgeStalePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_controls", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControl>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	private void HookActions() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnLeftClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnRightClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnMiddleClickCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(CallbackContext), Member = "get_canceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IgnoreNextClick(ref CallbackContext context, bool wasPressed) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationModel&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsMoveAllowed(AxisEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_isProcessingEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool IsPointerOverGameObject(int pointerOrTouchId) { }

	[CallerCount(Count = 0)]
	private void OnControlsChanged(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ResetPointers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "UnassignActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ResetPointers", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "HookActions", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "IgnoreNextClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private void OnLeftClickCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "IgnoreNextClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private void OnMiddleClickCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[CallsUnknownMethods(Count = 2)]
	private void OnMoveCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_canceled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel&))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(PointerModel), Member = "set_screenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetDisplayIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPointCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "IgnoreNextClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private void OnRightClickCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(InputSystem), Member = "get_scrollWheelDeltaPerTick", ReturnType = typeof(float))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnScrollCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[CallsUnknownMethods(Count = 2)]
	private void OnSubmitCancelCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnTrackedDeviceOrientationCallback(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadValue", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnTrackedDevicePositionCallback(CallbackContext context) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedDeviceRaycaster), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(RaycastResult))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private RaycastResult PerformRaycast(ExtendedPointerEventData eventData) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ButtonState&), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool PointerShouldIgnoreTransform(Transform t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SendPointerExitEventsAndRemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationModel&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "FilterPointerStatesByType", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "RemovePointerAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerModel), Member = "OnFrameFinished", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual void Process() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AxisEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "IsMoveAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisEventData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "WasPerformedThisDynamicUpdate", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	internal void ProcessNavigation(ref NavigationModel navigationState) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ButtonState&), typeof(ExtendedPointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ButtonState&), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ButtonState), Member = "CopyPressStateTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RaycastResult), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData)}, ReturnType = typeof(RaycastResult))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessPointer(ref PointerModel state) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "PointerShouldIgnoreTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ButtonState), Member = "CopyPressStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private void ProcessPointerButton(ref ButtonState button, PointerEventData eventData) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PointerEventData), Member = "IsPointerMoving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ButtonState), Member = "CopyPressStateFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void ProcessPointerButtonDrag(ref ButtonState button, ExtendedPointerEventData eventData) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ResetPointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SendPointerExitEventsAndRemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "PointerShouldIgnoreTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindCommonRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "IsPointerMoving", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[CallsUnknownMethods(Count = 2)]
	private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "HaveControlForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputActionReference)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SendPointerExitEventsAndRemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private void PurgeStalePointers() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ResetPointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SendPointerExitEventsAndRemovePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Int32>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private bool RemovePointerAtIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultInputActions), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void ResetDefaultActions() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "RemovePointerAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void ResetPointers() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "PurgeStalePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "FilterPointerStatesByType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerModel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtendedPointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "RemovePointerAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool SendPointerExitEventsAndRemovePointer(int index) { }

	[CalledBy(Type = typeof(PlayerInput), Member = "set_uiInputModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputSystemUIInputModule)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerInput), Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UnassignActions", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "HookActions", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void set_actionsAsset(InputActionAsset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_cancel(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_cursorLockBehavior(CursorLockBehavior value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_deselectOnBackgroundClick(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_leftClick(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_localMultiPlayerRoot(GameObject value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_middleClick(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_move(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_moveRepeatDelay(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_moveRepeatRate(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_point(InputActionReference value) { }

	[CallerCount(Count = 0)]
	public void set_pointerBehavior(UIPointerBehavior value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_repeatDelay(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_repeatRate(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_rightClick(InputActionReference value) { }

	[CallerCount(Count = 0)]
	public void set_scrollDeltaPerTick(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_scrollWheel(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_sendPointerHoverToParent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_submit(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_trackedDeviceDragThresholdMultiplier(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_trackedDeviceOrientation(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	public void set_trackedDevicePosition(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_trackedDeviceSelect(InputActionReference value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_xrTrackingOrigin(Transform value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void SetActionCallback(InputActionReference actionReference, Action<CallbackContext> callback, bool install) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "HookActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UnhookActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetActionCallbacks(bool install) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AssignDefaultActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_trackedDevicePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_trackedDeviceOrientation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_submit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "UnassignActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_rightClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_middleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_leftClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_scrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "set_move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "TryDisableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "EnableInputAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<CallbackContext> actionCallback) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "DisableAllActions", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.InputSystem.UI.InputSystemUIInputModule+InputActionReferenceState>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(InputActionReferenceState)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultInputActions), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "set_actionsAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SwapAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionReference&), typeof(InputActionReference), typeof(bool), typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UnassignActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemUIInputModule), Member = "SetActionCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void UnhookActions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionReference), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionReference), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(InputActionReference))]
	[CallsUnknownMethods(Count = 1)]
	private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference) { }

}

