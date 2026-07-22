namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class object
{
	[VisibleToOtherModules]
	public static class MarshalledUnityObject
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr Marshal(T obj) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr MarshalNotNull(T obj) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public static void TryThrowEditorNullExceptionObject(object unityObj, string paramterName) { }

	}

	private const int kInstanceID_None = 0; //Field offset: 0x0
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "CreateBlitShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "Destroy", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CallerCount(Count = 57)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public string name
	{
		[CallerCount(Count = 279)]
		[Calls(Type = typeof(Object), Member = "GetName", ReturnType = typeof(string))]
		 get { } //Length: 9
		[CallerCount(Count = 91)]
		[Calls(Type = typeof(Object), Member = "SetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Object() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Object() { }

	[CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void CheckNullArgument(object arg, string message) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[CallerCount(Count = 50)]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "DestroySelf", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(object obj, float t) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Destroy_Injected(IntPtr obj, float t) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[CallerCount(Count = 39)]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "get_timerComponent", ReturnType = "UI.Dates.DatePickerTimerComponent")]
	[CalledBy(Type = "DigitalRuby.Threading.EZThread", Member = "EnsureCreated", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComponentSingleton`1", Member = "get_instance", ReturnType = "TType")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "EnableRuntime", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "get_Instance", ReturnType = "SimpleFileBrowser.FileBrowser")]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(object target) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CalledBy(Type = typeof(Object), Member = "FindFirstObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "get_timerComponent", ReturnType = "UI.Dates.DatePickerTimerComponent")]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "LogToGameScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "FindFirstObjectByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(FindObjectsInactive)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T FindFirstObjectByType() { }

	[CalledBy(Type = typeof(VisibleLight), Member = "get_light", ReturnType = typeof(Light))]
	[CalledBy(Type = typeof(VisibleReflectionProbe), Member = "get_texture", ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(VisibleReflectionProbe), Member = "get_reflectionProbe", ReturnType = typeof(ReflectionProbe))]
	[CalledBy(Type = "UnityEngine.RaycastHit", Member = "get_collider", ReturnType = "UnityEngine.Collider")]
	[CalledBy(Type = "UnityEngine.RaycastHit2D", Member = "get_collider", ReturnType = "UnityEngine.Collider2D")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr FindObjectFromInstanceID_Injected(int instanceID) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldSlot", Member = "UpdateHologramsState", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "CloseAllScreens", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "CloseAllMessageBoxes", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme", Member = "ReloadTexturizables", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "EnsureExactlyOneEventSystem", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SharedDecalEntityManager", Member = "Get", ReturnType = "UnityEngine.Rendering.Universal.DecalEntityManager")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(FindObjectsInactive), typeof(FindObjectsSortMode)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Resources), Member = "ConvertObjects", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	[CalledBy(Type = "Scenes.General.Hologram", Member = "DefineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	[CalledBy(Type = typeof(LazyLoadReference`1), Member = "get_asset", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Tilemaps.ITilemap", Member = "FindAllRefreshPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Tilemaps.ITilemap", typeof(int), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.ITilemap", Member = "GetAllTileData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Tilemaps.ITilemap", typeof(int), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr ForceLoadFromInstanceID_Injected(int instanceID) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "CreateBlitShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "Destroy", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public HideFlags get_hideFlags() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 279)]
	[Calls(Type = typeof(Object), Member = "GetName", ReturnType = typeof(string))]
	public string get_name() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	private IntPtr GetCachedPtr() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 199)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetInstanceID() { }

	[CalledBy(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = True)]
	private string GetName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[CalledBy(Type = "Extensions.AsyncExtensions+<Instantiate>d__7`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectsManager+<>c__DisplayClass54_0`1", Member = "<LoadEffect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	[CalledBy(Type = "Extensions.DragClone", Member = "MakeClone", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas", Member = "Rebuild", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerCanvas", Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+IContainer", typeof(Transform), "UnityEngine.Rendering.UI.DebugUIHandlerWidget", "UnityEngine.Rendering.UI.DebugUIHandlerWidget&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerPersistentCanvas", Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Value", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SimpleFileBrowser.IListViewAdapter.CreateItem", ReturnType = "SimpleFileBrowser.ListItem")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "AddQuickLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	[CalledBy(Type = "PooledScrollList.Pool`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Pool`1", Member = "GetNext", ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerEnumHistory", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerFoldout", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerValueTuple", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static T Instantiate(T original, Transform parent) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "get_Instance", ReturnType = "SimpleFileBrowser.FileBrowser")]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Dropdown+DropdownItem"}, ReturnType = "UnityEngine.UI.Dropdown+DropdownItem")]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateDropdownList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_Dropdown+DropdownItem"}, ReturnType = "TMPro.TMP_Dropdown+DropdownItem")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateDropdownList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "get_profile", ReturnType = "UnityEngine.Rendering.VolumeProfile")]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "CopyActionAssetAndApplyBindingOverrides", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayButton_Pool_List_Item", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_DayButton"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayButton_Pool_List", Member = "GetButton", ReturnType = "UI.Dates.DatePicker_DayButton")]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "UpdateWeekNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<DateTime>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsUsingTemplate>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "UnityEngine.InputSystem.PlayerInput")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Object), Member = "Internal_CloneSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "CheckNullArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static T Instantiate(T original) { }

	[CalledBy(Type = "Manager.Background+<LoadLiveEnv>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Transform), typeof(bool)}, ReturnType = typeof(Object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original) { }

	[CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static object Internal_CloneSingle(object data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("CloneObject")]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsNativeObjectAlive(object o) { }

	[CalledBy(Type = typeof(LazyLoadReference`1), Member = "set_asset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	internal static bool IsPersistent(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsPersistent_Injected(IntPtr obj) { }

	[CallerCount(Count = 1748)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(object x, object y) { }

	[CallerCount(Count = 258)]
	[ContainsUnimplementedInstructions]
	public static bool op_Implicit(object exists) { }

	[CallerCount(Count = 1814)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(object x, object y) { }

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_hideFlags(HideFlags value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	[CallerCount(Count = 91)]
	[Calls(Type = typeof(Object), Member = "SetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_name(string value) { }

	[CalledBy(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(object obj) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionReference", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret) { }

}

