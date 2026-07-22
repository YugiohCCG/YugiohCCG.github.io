namespace UnityEngine.Rendering;

public interface IRenderPipelineGraphicsSettings
{

	public bool isAvailableInPlayerBuild
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int version
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_isAvailableInPlayerBuild() { }

	public int get_version() { }

}

