namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeClass(null)]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class ScriptableObject : object
{

	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ScriptableObject() { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "EvaluateVolumeDefaultState", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeProfile", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = "UnityEngine.Rendering.VolumeComponent")]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeStack", Member = "Reload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Type[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "CreateScriptableObjectInstance", ReturnType = "T")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public static ScriptableObject CreateInstance(Type type) { }

	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "Spine.Unity.AtlasAssetBase", typeof(bool), typeof(float)}, ReturnType = "Spine.Unity.SkeletonDataAsset")]
	[CalledBy(Type = "UnityEngine.RuntimeTextSettings", Member = "get_defaultTextSettings", ReturnType = "UnityEngine.RuntimeTextSettings")]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas), "UnityEngine.Material[]", typeof(bool)}, ReturnType = "Spine.Unity.SpineSpriteAtlasAsset")]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "UnityEngine.Texture2D[]", typeof(Material), typeof(bool)}, ReturnType = "Spine.Unity.SpineAtlasAsset")]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "UnityEngine.Material[]", typeof(bool)}, ReturnType = "Spine.Unity.SpineAtlasAsset")]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "Spine.Unity.AtlasAssetBase[]", typeof(bool), typeof(float)}, ReturnType = "Spine.Unity.SkeletonDataAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = typeof(PlayerConnection), Member = "get_instance", ReturnType = typeof(PlayerConnection))]
	[CalledBy(Type = "UnityEngine.Rendering.Volume", Member = "get_profile", ReturnType = "UnityEngine.Rendering.VolumeProfile")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputSystem", Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.IInputRuntime", "UnityEngine.InputSystem.InputSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionReference", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction"}, ReturnType = "UnityEngine.InputSystem.InputActionReference")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionAsset", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputActionAsset")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelTextSettings", Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "CreateInstance", ReturnType = typeof(PlayerConnection))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ScriptableObject))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T CreateInstance() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	private static void CreateScriptableObject(ScriptableObject self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }

}

