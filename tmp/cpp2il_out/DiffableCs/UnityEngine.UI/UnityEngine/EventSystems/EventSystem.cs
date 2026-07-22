namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public GameObject go; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass56_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		internal void <CreateUIToolkitPanelGameObject>b__0() { }

	}

	private struct UIToolkitOverrideConfig
	{
		public EventSystem activeEventSystem; //Field offset: 0x0
		public bool sendEvents; //Field offset: 0x8
		public bool createPanelGameObjectsOnStart; //Field offset: 0x9

	}

	private static List<EventSystem> m_EventSystems; //Field offset: 0x0
	private static readonly Comparison<RaycastResult> s_RaycastComparer; //Field offset: 0x8
	private static UIToolkitOverrideConfig s_UIToolkitOverride; //Field offset: 0x10
	private List<BaseInputModule> m_SystemInputModules; //Field offset: 0x20
	private BaseInputModule m_CurrentInputModule; //Field offset: 0x28
	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	private GameObject m_FirstSelected; //Field offset: 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; //Field offset: 0x38
	[SerializeField]
	private int m_DragThreshold; //Field offset: 0x3C
	private GameObject m_CurrentSelected; //Field offset: 0x40
	private bool m_HasFocus; //Field offset: 0x48
	private bool m_SelectionGuard; //Field offset: 0x49
	private BaseEventData m_DummyData; //Field offset: 0x50
	private bool m_Started; //Field offset: 0x58
	private bool m_IsTrackingUIToolkitPanels; //Field offset: 0x59

	public bool alreadySelecting
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private BaseEventData baseEventDataCache
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 121
	}

	private bool createUIToolkitPanelGameObjectsOnStart
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
		private get { } //Length: 104
	}

	public static EventSystem current
	{
		[CallerCount(Count = 58)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 171
		[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 385
	}

	public BaseInputModule currentInputModule
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GameObject currentSelectedGameObject
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public GameObject firstSelectedGameObject
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool isFocused
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private bool isUIToolkitActiveEventSystem
	{
		[CalledBy(Type = typeof(EventSystem), Member = "get_sendUIToolkitEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventSystem), Member = "get_createUIToolkitPanelGameObjectsOnStart", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EventSystem), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		private get { } //Length: 233
	}

	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int pixelDragThreshold
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool sendNavigationEvents
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	private bool sendUIToolkitEvents
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
		private get { } //Length: 104
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static EventSystem() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected EventSystem() { }

	[CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ChangeEventModule(BaseInputModule module) { }

	[CalledBy(Type = typeof(EventSystem), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "set_selectableGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_alreadySelecting() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private BaseEventData get_baseEventDataCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	[CallerCount(Count = 58)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static EventSystem get_current() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public BaseInputModule get_currentInputModule() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public GameObject get_currentSelectedGameObject() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public GameObject get_firstSelectedGameObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isFocused() { }

	[CalledBy(Type = typeof(EventSystem), Member = "get_sendUIToolkitEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventSystem), Member = "get_createUIToolkitPanelGameObjectsOnStart", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventSystem), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	private bool get_isUIToolkitActiveEventSystem() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public GameObject get_lastSelectedGameObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_pixelDragThreshold() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_sendNavigationEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
	private bool get_sendUIToolkitEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPointerOverGameObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsPointerOverGameObject(int pointerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
	protected override void OnApplicationFocus(bool hasFocus) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "remove_onCreatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDisable() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnEnable() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "PerformRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData"}, ReturnType = typeof(RaycastResult))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseRaycaster), Member = "get_rootRaycaster", ReturnType = typeof(BaseRaycaster))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortingGroup), Member = "get_invalidSortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SortingLayer), Member = "GetLayerValueFromID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void set_current(EventSystem value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_firstSelectedGameObject(GameObject value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_pixelDragThreshold(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_sendNavigationEvents(bool value) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "SendChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown+DropdownItem", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DropdownItem), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "Select", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "OnInputFieldEndEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void SetSelectedGameObject(GameObject selected) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ActivateModule", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ButtonState&", typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ActivateModule", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	protected virtual void Start() { }

	[CalledBy(Type = typeof(EventSystem), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventSystem), Member = "get_isUIToolkitActiveEventSystem", ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "add_onCreatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void StartTrackingUIToolkitPanels() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "remove_onCreatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void StopTrackingUIToolkitPanels() { }

	[CalledBy(Type = typeof(EventSystem), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void TickModules() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.MultiplayerEventSystem", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "ChangeEventModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInputModule)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Update() { }

	[CalledBy(Type = typeof(BaseInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateModules() { }

}

