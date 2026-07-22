namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
public sealed class Resources
{

	[CalledBy(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	internal static T[] ConvertObjects(Object[] rawObjects) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionReference", Member = "InvalidateAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetICUAsset", ReturnType = typeof(TextAsset))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "GetICUAssetStaticFalback", ReturnType = typeof(TextAsset))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSystem", Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.IInputRuntime", "UnityEngine.InputSystem.InputSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.IInputRuntime", "UnityEngine.InputSystem.InputSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "InitializeActions", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "<RegisterDebug>g__RefreshScenarioNames|42_75", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public static T[] FindObjectsOfTypeAll() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "AssignDefaultFont", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T GetBuiltinResource(string path) { }

	[CalledBy(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object GetBuiltinResource(Type type, string path) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetBuiltinResource_Injected(Type type, ref ManagedSpanWrapper path) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference", Member = "IsLoaded", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference", Member = "Unload", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Resources_Bindings::DoesObjectWithInstanceIDExist", IsThreadSafe = True)]
	public static bool InstanceIDIsValid(int instanceId) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference", Member = "Get", ReturnType = "UnityEngine.Rendering.ProbeVolumeBakingSet")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference", Member = "Unload", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Resources_Bindings::InstanceIDToObject")]
	public static object InstanceIDToObject(int instanceID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr InstanceIDToObject_Injected(int instanceID) { }

	[CalledBy(Type = "UnityEngine.UIElements.Panel", Member = "LoadResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(float)}, ReturnType = typeof(Object))]
	[CalledBy(Type = typeof(ResourceRequest), Member = "GetResult", ReturnType = typeof(Object))]
	[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Object))]
	[CalledBy(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static object Load(string path, Type systemTypeInstance) { }

	[CalledBy(Type = "TMPro.TMP_Text", Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]", typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "LoadResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "set_displayRuntimeUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "EnsurePersistentCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_ResourceManager", Member = "GetTextSettings", ReturnType = "TMPro.TMP_Settings")]
	[CalledBy(Type = "TMPro.TMP_Settings", Member = "get_instance", ReturnType = "TMPro.TMP_Settings")]
	[CalledBy(Type = "TMPro.TMP_Settings", Member = "LoadDefaultSettings", ReturnType = "TMPro.TMP_Settings")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", typeof(int), typeof(Int32&), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo", typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.UnicodeLineBreakingRules", Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "get_Instance", ReturnType = "SimpleFileBrowser.FileBrowser")]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "get_material", ReturnType = typeof(Material))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T Load(string path) { }

	[CalledBy(Type = "DG.Tweening.DOTween", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Boolean>", "System.Nullable`1<Boolean>", "System.Nullable`1<LogBehaviour>"}, ReturnType = "DG.Tweening.IDOTweenInit")]
	[CalledBy(Type = "DG.Tweening.DOTween", Member = "AutoInit", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTween", Member = "InitCheck", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	public static object Load(string path) { }

	[CalledBy(Type = "Manager.Background+<LoadLiveEnv>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<GetAsset>d__76`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<LoadPointer>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(ResourceRequest))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ResourceRequest LoadAsync(string path) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ResourceRequest LoadAsync(string path) { }

	[CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ResourceRequest LoadAsync(string path, Type type) { }

	[CalledBy(Type = "Manager.Sound", Member = "RemoveClipFromMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSetWeakReference", Member = "Unload", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnloadAsset(object assetToUnload) { }

	[CalledBy(Type = "Manager.Helper+<CleanMemory>d__132", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	public static AsyncOperation UnloadUnusedAssets() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr UnloadUnusedAssets_Injected() { }

}

