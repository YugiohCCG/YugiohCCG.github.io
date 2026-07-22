namespace UnityEngine.InputSystem.XR;

[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.19/manual/TrackedInputDevices.html#tracked-pose-driver")]
public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
{
	[Flags]
	private enum TrackingStates
	{
		None = 0,
		Position = 1,
		Rotation = 2,
	}

	internal enum TrackingType
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2,
	}

	internal enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2,
	}

	[SerializeField]
	[Tooltip("Which Transform properties to update.")]
	private TrackingType m_TrackingType; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
	private UpdateType m_UpdateType; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
	private bool m_IgnoreTrackingState; //Field offset: 0x28
	[SerializeField]
	[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
	private InputActionProperty m_PositionInput; //Field offset: 0x30
	[SerializeField]
	[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
	private InputActionProperty m_RotationInput; //Field offset: 0x48
	[SerializeField]
	[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
	private InputActionProperty m_TrackingStateInput; //Field offset: 0x60
	private Vector3 m_CurrentPosition; //Field offset: 0x78
	private Quaternion m_CurrentRotation; //Field offset: 0x84
	private TrackingStates m_CurrentTrackingState; //Field offset: 0x94
	private bool m_RotationBound; //Field offset: 0x98
	private bool m_PositionBound; //Field offset: 0x99
	private bool m_TrackingStateBound; //Field offset: 0x9A
	private bool m_IsFirstUpdate; //Field offset: 0x9B
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_PositionAction; //Field offset: 0xA0
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_RotationAction; //Field offset: 0xA8

	public bool ignoreTrackingState
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public InputAction positionAction
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 220
	}

	public InputActionProperty positionInput
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 181
	}

	public InputAction rotationAction
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 220
	}

	public InputActionProperty rotationInput
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 181
	}

	public InputActionProperty trackingStateInput
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 181
	}

	public TrackingType trackingType
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public UpdateType updateType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TrackedPoseDriver() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Awake() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	private void BindActions() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_positionInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_positionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void BindPosition() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_rotationInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_rotationAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void BindRotation() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_trackingStateInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "add_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "add_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void BindTrackingState() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ignoreTrackingState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	public InputAction get_positionAction() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_positionInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	public InputAction get_rotationAction() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_rotationInput() { }

	[CallerCount(Count = 0)]
	public InputActionProperty get_trackingStateInput() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public TrackingType get_trackingType() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public UpdateType get_updateType() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UpdateCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingStateWithoutTrackingAction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingState", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingState), Member = "get_actionIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BindingState), Member = "get_isComposite", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool HasResolvedControl(InputAction action) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnBeforeRender() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnDestroy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingStateWithoutTrackingAction", ReturnType = typeof(void))]
	private void OnDeviceChanged(InputDevice inputDevice, InputDeviceChange inputDeviceChange) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "remove_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "add_onAfterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.InputDeviceChange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnEnable() { }

	[CallerCount(Count = 0)]
	private void OnPositionCanceled(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	private void OnPositionPerformed(CallbackContext context) { }

	[CallerCount(Count = 0)]
	private void OnRotationCanceled(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	private void OnRotationPerformed(CallbackContext context) { }

	[CallerCount(Count = 0)]
	private void OnTrackingStateCanceled(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	private void OnTrackingStatePerformed(CallbackContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void PerformUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingStateWithoutTrackingAction", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	private void ReadTrackingState() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UpdateCallback", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDeviceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingState", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private void ReadTrackingStateWithoutTrackingAction() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "Rename", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void RenameAndEnable(InputAction action, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected void Reset() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ignoreTrackingState(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_positionAction(InputAction value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_positionInput(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_rotationAction(InputAction value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_rotationInput(InputActionProperty value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void set_trackingStateInput(InputActionProperty value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_trackingType(TrackingType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_updateType(UpdateType value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetLocalPositionAndRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected override void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindRotation", ReturnType = typeof(void))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "UnbindTrackingState", ReturnType = typeof(void))]
	private void UnbindActions() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_positionInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_positionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UnbindPosition() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_rotationInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_rotationAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UnbindRotation() { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "set_trackingStateInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "UnbindActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionProperty), Member = "get_reference", ReturnType = typeof(InputActionReference))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_performed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "remove_canceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.InputAction+CallbackContext>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UnbindTrackingState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionProperty), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_localRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrackedPoseDriver), Member = "ReadTrackingStateWithoutTrackingAction", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateCallback() { }

}

