namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "Volume", Order = 0)]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
public class URPDefaultVolumeProfileSettings : IDefaultVolumeProfileSettings, IRenderPipelineGraphicsSettings
{
	public enum Version
	{
		Initial = 0,
	}

	[HideInInspector]
	[SerializeField]
	private Version m_Version; //Field offset: 0x10
	[SerializeField]
	private VolumeProfile m_VolumeProfile; //Field offset: 0x18

	public override int version
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override VolumeProfile volumeProfile
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 101
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public URPDefaultVolumeProfileSettings() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_version() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override VolumeProfile get_volumeProfile() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	public override void set_volumeProfile(VolumeProfile value) { }

}

