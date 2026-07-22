namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[CallerCount(Count = 1078)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		 get { } //Length: 144
	}

	public Transform transform
	{
		[CallerCount(Count = 833)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		 get { } //Length: 144
	}

	[CallerCount(Count = 262)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Component() { }

	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleDeviceLost", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleDeviceRegained", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleControlsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "NotifyPlayerJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.PlayerInput"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "NotifyPlayerLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.PlayerInput"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

	[CallerCount(Count = 1078)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	public GameObject get_gameObject() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 833)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	public Transform get_transform() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 346)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponentFastPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T GetComponent() { }

	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "get_isRootLayoutGroup", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.CyclicDropdown", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPanel", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T GetComponentInChildren(bool includeInactive) { }

	[CallerCount(Count = 232)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T GetComponentInParent() { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetComponents(Type type, List<Component> results) { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.VolumeStack", typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.MaskableGraphic", typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_materialForRendering", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "UpdateModules", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void GetComponents(List<T> results) { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "ComputeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "get_input", ReturnType = "UnityEngine.EventSystems.BaseInput")]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollower", Member = "DisposeExcessCollidersAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BoundingBoxFollowerGraphic", Member = "DisposeExcessCollidersAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T[] GetComponents() { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }

	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "Notify2DMaskStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "NotifyStencilStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void GetComponentsInChildren(List<T> results) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "get_Rows", ReturnType = "System.Collections.Generic.List`1<TableRow>")]
	[CalledBy(Type = "UI.Tables.TableRow", Member = "get_Cells", ReturnType = "System.Collections.Generic.List`1<TableCell>")]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "ClearWeekDayHeaders", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePickerDayButtonType"}, ReturnType = "System.Collections.Generic.List`1<DatePicker_DayButton>")]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayButtons", ReturnType = "System.Collections.Generic.List`1<DatePicker_DayButton>")]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "GetDayButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = "UI.Dates.DatePicker_DayButton")]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas", Member = "GetWidgetFromPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.Rendering.UI.DebugUIHandlerWidget")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T[] GetComponentsInChildren() { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T[] GetComponentsInChildren(bool includeInactive) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseRaycaster", Member = "get_rootRaycaster", ReturnType = "UnityEngine.EventSystems.BaseRaycaster")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T[] GetComponentsInParent() { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "FindUIDocumentParent", ReturnType = "UnityEngine.UIElements.UIDocument")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T[] GetComponentsInParent(bool includeInactive) { }

	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "OnActionTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleDeviceLost", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleDeviceRegained", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "HandleControlsChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "NotifyPlayerJoined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.PlayerInput"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "NotifyPlayerLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.PlayerInput"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("SendMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutCalculation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), "UnityEngine.Events.UnityAction`1<Component>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryGetComponent(out T component) { }

}

