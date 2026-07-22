namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
{

	public virtual LayerMask selectedCameraLayerMask
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 226
	}

	public virtual Vector3 selectedCameraPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 250
	}

	public virtual VolumeStack selectedCameraVolumeStack
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 299
	}

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(23.2)", False)]
	public virtual Type targetRenderPipeline
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		 get { } //Length: 77
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = ".ctor", ReturnType = typeof(void))]
	public UniversalRenderPipelineVolumeDebugSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual LayerMask get_selectedCameraLayerMask() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector3 get_selectedCameraPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeDebugSettings`1), Member = "get_selectedCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[CallsUnknownMethods(Count = 1)]
	public virtual VolumeStack get_selectedCameraVolumeStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	public virtual Type get_targetRenderPipeline() { }

}

