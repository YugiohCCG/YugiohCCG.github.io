namespace UnityEngine.Rendering;

[CategoryInfo(Name = "H: RP Assets Inclusion", Order = 990)]
[HideInInspector]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
public class IncludeAdditionalRPAssets : IRenderPipelineGraphicsSettings
{
	private enum Version
	{
		Initial = 0,
		Count = 1,
		Last = 0,
	}

	[HideInInspector]
	[SerializeField]
	private Version m_version; //Field offset: 0x10
	[SerializeField]
	private bool m_IncludeReferencedInScenes; //Field offset: 0x14
	[SerializeField]
	private bool m_IncludeAssetsByLabel; //Field offset: 0x15
	[SerializeField]
	private string m_LabelToInclude; //Field offset: 0x18

	public bool includeAssetsByLabel
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 102
	}

	public bool includeReferencedInScenes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 102
	}

	public string labelToInclude
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
	public IncludeAdditionalRPAssets() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_includeAssetsByLabel() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_includeReferencedInScenes() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_labelToInclude() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_includeAssetsByLabel(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_includeReferencedInScenes(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public void set_labelToInclude(string value) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	private override int UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_version() { }

}

