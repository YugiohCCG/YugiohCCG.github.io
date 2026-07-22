namespace UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour
{
	protected List<RaycastResult> m_RaycastResultCache; //Field offset: 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; //Field offset: 0x28
	private AxisEventData m_AxisEventData; //Field offset: 0x30
	private EventSystem m_EventSystem; //Field offset: 0x38
	private BaseEventData m_BaseEventData; //Field offset: 0x40
	protected BaseInput m_InputOverride; //Field offset: 0x48
	private BaseInput m_DefaultInput; //Field offset: 0x50

	protected EventSystem eventSystem
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public BaseInput input
	{
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 534
	}

	public BaseInput inputOverride
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	protected private bool sendPointerHoverToParent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected BaseInputModule() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ActivateModule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ConvertUIToolkitPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void DeactivateModule() { }

	[CalledBy(Type = typeof(BaseInputModule), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(MoveDirection))]
	[CalledBy(Type = typeof(BaseInputModule), Member = "GetAxisEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AxisEventData))]
	[CallerCount(Count = 2)]
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(MoveDirection))]
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(RaycastResult))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	protected EventSystem get_eventSystem() { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public BaseInput get_input() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public BaseInput get_inputOverride() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private bool get_sendPointerHoverToParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "DetermineMoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(MoveDirection))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override BaseEventData GetBaseEventData() { }

	[CalledBy(Type = typeof(PointerInputModule), Member = "ProcessMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool IsModuleSupported() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool IsPointerOverGameObject(int pointerId) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSystem), Member = "UpdateModules", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(EventSystem), Member = "UpdateModules", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnEnable() { }

	public abstract void Process() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_inputOverride(BaseInput value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private void set_sendPointerHoverToParent(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool ShouldActivateModule() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UpdateModule() { }

}

