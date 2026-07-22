namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
[SupportedOnRenderer(typeof(UniversalRendererData))]
[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
public class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
{
	internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT"; //Field offset: 0x0
	internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE"; //Field offset: 0x0
	internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC"; //Field offset: 0x0
	internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW"; //Field offset: 0x0
	internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM"; //Field offset: 0x0
	internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH"; //Field offset: 0x0
	internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS"; //Field offset: 0x0
	internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW"; //Field offset: 0x0
	internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM"; //Field offset: 0x0
	internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH"; //Field offset: 0x0
	[SerializeField]
	private ScreenSpaceAmbientOcclusionSettings m_Settings; //Field offset: 0x20
	private Material m_Material; //Field offset: 0x28
	private ScreenSpaceAmbientOcclusionPass m_SSAOPass; //Field offset: 0x30
	private Shader m_Shader; //Field offset: 0x38
	private Texture2D[] m_BlueNoise256Textures; //Field offset: 0x40

	internal ScreenSpaceAmbientOcclusionSettings settings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ScreenSpaceAmbientOcclusion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalRenderer), Member = "IsOffscreenDepthTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "TryPrepareResources", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScreenSpaceAmbientOcclusionSettings&), typeof(ScriptableRenderer&), typeof(Material&), typeof(Texture2D[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "EnqueuePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderPass)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScreenSpaceAmbientOcclusionPass), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal ScreenSpaceAmbientOcclusionSettings get_settings() { }

	[CalledBy(Type = typeof(ScreenSpaceAmbientOcclusion), Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool TryPrepareResources() { }

}

