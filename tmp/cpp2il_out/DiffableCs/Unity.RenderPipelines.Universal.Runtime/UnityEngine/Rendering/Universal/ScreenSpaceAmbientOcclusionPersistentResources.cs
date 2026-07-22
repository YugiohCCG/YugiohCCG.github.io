namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: SSAO Shader", Order = 1000)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
internal class ScreenSpaceAmbientOcclusionPersistentResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[ResourcePath("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_Shader; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x18

	public override bool isAvailableInPlayerBuild
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Shader Shader
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	public override int version
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ScreenSpaceAmbientOcclusionPersistentResources() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_isAvailableInPlayerBuild() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Shader get_Shader() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_Shader(Shader value) { }

}

