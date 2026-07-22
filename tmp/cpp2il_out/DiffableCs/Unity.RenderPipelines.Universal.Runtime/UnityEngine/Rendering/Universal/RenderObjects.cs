namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", null, null)]
[Tooltip("Render Objects simplifies the injection of additional render passes by exposing a selection of commonly used settings.")]
public class RenderObjects : ScriptableRendererFeature
{
	internal class CustomCameraSettings
	{
		public bool overrideCamera; //Field offset: 0x10
		public bool restoreCamera; //Field offset: 0x11
		public Vector4 offset; //Field offset: 0x14
		public float cameraFieldOfView; //Field offset: 0x24

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public CustomCameraSettings() { }

	}

	internal class FilterSettings
	{
		public RenderQueueType RenderQueueType; //Field offset: 0x10
		public LayerMask LayerMask; //Field offset: 0x14
		public String[] PassNames; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		public FilterSettings() { }

	}

	internal class RenderObjectsSettings
	{
		internal enum OverrideMaterialMode
		{
			None = 0,
			Material = 1,
			Shader = 2,
		}

		public string passTag; //Field offset: 0x10
		public RenderPassEvent Event; //Field offset: 0x18
		public FilterSettings filterSettings; //Field offset: 0x20
		public Material overrideMaterial; //Field offset: 0x28
		public int overrideMaterialPassIndex; //Field offset: 0x30
		public Shader overrideShader; //Field offset: 0x38
		public int overrideShaderPassIndex; //Field offset: 0x40
		public OverrideMaterialMode overrideMode; //Field offset: 0x44
		public bool overrideDepthState; //Field offset: 0x48
		public CompareFunction depthCompareFunction; //Field offset: 0x4C
		public bool enableWrite; //Field offset: 0x50
		public StencilStateData stencilSettings; //Field offset: 0x58
		public CustomCameraSettings cameraSettings; //Field offset: 0x60

		[CalledBy(Type = typeof(RenderObjects), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StencilStateData), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		public RenderObjectsSettings() { }

	}

	public RenderObjectsSettings settings; //Field offset: 0x20
	private RenderObjectsPass renderObjectsPass; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectsSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRendererFeature), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public RenderObjects() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraType", ReturnType = typeof(CameraType&))]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsOffscreenDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderObjectsPass), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(String[]), typeof(RenderQueueType), typeof(int), typeof(CustomCameraSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "get_defaultValue", ReturnType = typeof(StencilState))]
	[Calls(Type = typeof(StencilState), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetCompareFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetPassOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "SetZFailOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderStateBlock), Member = "set_stencilState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilState)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	public virtual void Create() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool SupportsNativeRenderPass() { }

}

