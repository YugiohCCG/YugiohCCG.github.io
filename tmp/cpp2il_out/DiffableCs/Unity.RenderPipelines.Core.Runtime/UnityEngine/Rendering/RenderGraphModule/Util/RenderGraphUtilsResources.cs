namespace UnityEngine.Rendering.RenderGraphModule.Util;

[Category("Resources/Render Graph Helper Function Resources")]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
internal class RenderGraphUtilsResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	internal enum Version
	{
		Initial = 0,
		Count = 1,
		Latest = 0,
	}

	[HideInInspector]
	[SerializeField]
	private Version m_Version; //Field offset: 0x10
	[ResourcePath("Shaders/CoreCopy.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	internal Shader m_CoreCopyPS; //Field offset: 0x18

	public Shader coreCopyPS
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.version
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphUtilsResources() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Shader get_coreCopyPS() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_coreCopyPS(Shader value) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

