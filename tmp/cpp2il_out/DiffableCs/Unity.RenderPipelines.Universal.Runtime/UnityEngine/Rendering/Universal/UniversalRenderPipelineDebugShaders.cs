namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Debug Shaders", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
public class UniversalRenderPipelineDebugShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[ResourcePath("Shaders/Debug/DebugReplacement.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_DebugReplacementPS; //Field offset: 0x10
	[ResourcePath("Shaders/Debug/HDRDebugView.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_HdrDebugViewPS; //Field offset: 0x18
	[ResourcePath("Shaders/Debug/ProbeVolumeSamplingDebugPositionNormal.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	private ComputeShader m_ProbeVolumeSamplingDebugComputeShader; //Field offset: 0x20

	public Shader debugReplacementPS
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	public Shader hdrDebugViewPS
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	public ComputeShader probeVolumeSamplingDebugComputeShader
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	public override int version
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UniversalRenderPipelineDebugShaders() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Shader get_debugReplacementPS() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Shader get_hdrDebugViewPS() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ComputeShader get_probeVolumeSamplingDebugComputeShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_debugReplacementPS(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_hdrDebugViewPS(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_probeVolumeSamplingDebugComputeShader(ComputeShader value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

