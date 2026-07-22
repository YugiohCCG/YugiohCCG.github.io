namespace UnityEngine.Rendering;

public interface IDefaultVolumeProfileSettings : IRenderPipelineGraphicsSettings
{

	private bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	public VolumeProfile volumeProfile
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public VolumeProfile get_volumeProfile() { }

	public void set_volumeProfile(VolumeProfile value) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

