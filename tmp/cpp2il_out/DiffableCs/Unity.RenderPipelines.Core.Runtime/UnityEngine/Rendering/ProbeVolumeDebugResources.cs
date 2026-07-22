namespace UnityEngine.Rendering;

[CategoryInfo(Name = "R: Adaptive Probe Volumes", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
internal class ProbeVolumeDebugResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x10
	[Header("Debug")]
	[ResourcePath("Runtime/Debug/ProbeVolumeDebug.shader", SearchType::ProjectPath (0))]
	public Shader probeVolumeDebugShader; //Field offset: 0x18
	[ResourcePath("Runtime/Debug/ProbeVolumeFragmentationDebug.shader", SearchType::ProjectPath (0))]
	public Shader probeVolumeFragmentationDebugShader; //Field offset: 0x20
	[ResourcePath("Runtime/Debug/ProbeVolumeSamplingDebug.shader", SearchType::ProjectPath (0))]
	public Shader probeVolumeSamplingDebugShader; //Field offset: 0x28
	[ResourcePath("Runtime/Debug/ProbeVolumeOffsetDebug.shader", SearchType::ProjectPath (0))]
	public Shader probeVolumeOffsetDebugShader; //Field offset: 0x30
	[ResourcePath("Runtime/Debug/ProbeSamplingDebugMesh.fbx", SearchType::ProjectPath (0))]
	public Mesh probeSamplingDebugMesh; //Field offset: 0x38
	[ResourcePath("Runtime/Debug/ProbeVolumeNumbersDisplayTex.png", SearchType::ProjectPath (0))]
	public Texture2D numbersDisplayTex; //Field offset: 0x40

	public override int version
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ProbeVolumeDebugResources() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_version() { }

}

