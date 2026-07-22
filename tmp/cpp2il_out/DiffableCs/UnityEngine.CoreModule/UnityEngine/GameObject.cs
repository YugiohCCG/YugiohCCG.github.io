namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : object
{

	public bool activeInHierarchy
	{
		[CallerCount(Count = 120)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 118
	}

	public bool activeSelf
	{
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod(Name = "IsSelfActive")]
		 get { } //Length: 118
	}

	public GameObject gameObject
	{
		[CallerCount(Count = 207)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int layer
	{
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetParentAndAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "SetParentAndAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "UpdatePriority", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "UpdateLayer", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "IsLensFlareSRPHidden", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.LensFlareComponentSRP", "UnityEngine.Rendering.LensFlareDataSRP"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeCollection", Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = "System.Collections.Generic.List`1<Volume>")]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "SetLayerRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetLayerRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public Scene scene
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryGetPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.ProbeVolumePerSceneData&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
		 get { } //Length: 135
	}

	public ulong sceneCullingMask
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public Transform transform
	{
		[CallerCount(Count = 176)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		 get { } //Length: 144
	}

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "SpawnBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Bone", typeof(Transform), "Spine.Unity.SkeletonUtilityBone+Mode", typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "GetBoneRoot", ReturnType = typeof(Transform))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.BoundingBoxAttachment", "Spine.Slot", typeof(Transform), typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "NewSpineGameObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonDataAsset", typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "NewSkeletonGraphicGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonDataAsset", typeof(Transform), typeof(Material)}, ReturnType = "Spine.Unity.SkeletonGraphic")]
	[CalledBy(Type = "DG.Tweening.Core.DOTweenComponent", Member = "Create", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateUIObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateUIElementRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector2)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.Rendering.ComponentSingleton`1", Member = "get_instance", ReturnType = "TType")]
	[CalledBy(Type = "DigitalRuby.Threading.EZThread", Member = "EnsureCreated", ReturnType = typeof(void))]
	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "CreateSpaceElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.ScrollRect", typeof(float)}, ReturnType = "UnityEngine.UI.LayoutElement")]
	[CalledBy(Type = "PooledScrollList.Pool`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UI.Dates.DatePickerTimer", Member = "get_timerComponent", ReturnType = "UI.Dates.DatePickerTimerComponent")]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(GameObject), Member = "Internal_CreateGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObject(string name) { }

	[CalledBy(Type = "UnityEngine.InputSystem.EnhancedTouch.TouchSimulation", Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUpdater", Member = "EnableRuntime", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "Internal_CreateGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObject() { }

	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "NewPartsRendererGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = "Spine.Unity.SkeletonPartsRenderer")]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "EnsureSeparatorPartCount", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "EnsureCanvasRendererCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "CreateUIToolkitPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls+DefaultRuntimeFactory", Member = "CreateGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Type[]"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateTextArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_DayButton_Pool", Member = "get_poolRect", ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "Internal_CreateGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public GameObject(string name, Type[] components) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	[CallerCount(Count = 117)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T AddComponent() { }

	[CalledBy(Type = "Extensions.DeckTrunk", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Find_Injected(ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 120)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "IsActive")]
	public bool get_activeInHierarchy() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "IsSelfActive")]
	public bool get_activeSelf() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 207)]
	[DeduplicatedMethod]
	public GameObject get_gameObject() { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeCollection", Member = "GrabVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = "System.Collections.Generic.List`1<Volume>")]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Volume"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "IsLensFlareSRPHidden", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.LensFlareComponentSRP", "UnityEngine.Rendering.LensFlareDataSRP"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "UpdateLayer", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "UpdatePriority", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "SetParentAndAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetParentAndAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_layer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_layer_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryGetPerSceneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.ProbeVolumePerSceneData&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "UpdateDecalEntityData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntity", "UnityEngine.Rendering.Universal.DecalProjector"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	public ulong get_sceneCullingMask() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 176)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	public Transform get_transform() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 154)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentFastPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T GetComponent() { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	[CalledBy(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[CalledBy(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[CalledBy(Type = "Scenes.Menu.MainMenu", Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInput", Member = "DoInstantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = "UnityEngine.InputSystem.PlayerInput")]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "IsDeviceUsableWithPlayerActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputDevice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T GetComponentInChildren(bool includeInactive) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointerMovement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.ExtendedPointerEventData", typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	public T GetComponentInParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Component))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T GetComponentInParent(bool includeInactive) { }

	[CalledBy(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T[] GetComponents() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "AssignPanelToComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "GetEventList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "System.Collections.Generic.IList`1<IEventSystemHandler>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void GetComponents(List<T> results) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	[CalledBy(Type = "Spine.Unity.ActivateBasedOnFlipDirection", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public T[] GetComponentsInChildren() { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T[] GetComponentsInChildren(bool includeInactive) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvas", ReturnType = "UnityEngine.Canvas")]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "CacheCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.IClippable"}, ReturnType = "UnityEngine.UI.RectMask2D")]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_Canvas", ReturnType = "UnityEngine.Canvas")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[CalledBy(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(object)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T[] GetComponentsInParent(bool includeInactive) { }

	[CalledBy(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	[CalledBy(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name) { }

	[CalledBy(Type = "UnityEngine.SendMouseEvents+HitInfo", Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "SendEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.SendMouseEvents+HitInfo"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "GetCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "SetLayerRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshPro", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMesh")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TextMeshProUGUI", "TMPro.MaterialReference"}, ReturnType = "TMPro.TMP_SubMeshUI")]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetLayerRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_layer(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	[CallerCount(Count = 655)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool TryGetComponent(Type type, out Component component) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponentFastPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TryGetComponent(out T component) { }

	[CalledBy(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

}

