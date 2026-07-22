namespace UnityEngine.Rendering.Universal;

[Extension]
public static class CameraExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "set_volumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void DestroyVolumeStack(Camera camera) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "set_volumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void DestroyVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

	[CalledBy(Type = "Scenes.Battle.DuelField", Member = "SetupCamera", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(Camera camera) { }

	[CalledBy(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	internal static void GetVolumeLayerMaskAndTrigger(Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_requiresVolumeFrameworkUpdate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static void SetVolumeFrameworkUpdateMode(Camera camera, VolumeFrameworkUpdateMode mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void UpdateVolumeStack(Camera camera) { }

	[CalledBy(Type = typeof(CameraExtensions), Member = "SetVolumeFrameworkUpdateMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(VolumeFrameworkUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraExtensions), Member = "UpdateVolumeStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateVolumeFramework", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "get_requiresVolumeFrameworkUpdate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalAdditionalCameraData), Member = "GetOrCreateVolumeStack", ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraExtensions), Member = "GetVolumeLayerMaskAndTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(LayerMask&), typeof(Transform&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VolumeManager), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VolumeStack), typeof(Transform), typeof(LayerMask)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void UpdateVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

}

