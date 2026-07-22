namespace UnityEngine.Rendering;

public class RenderPipelineGraphicsSettingsCollection
{
	[SerializeReference]
	private List<IRenderPipelineGraphicsSettings> m_List; //Field offset: 0x10

	public List<IRenderPipelineGraphicsSettings> settingsList
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.Rendering.RenderPipelineGraphicsSettingsContainer", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public RenderPipelineGraphicsSettingsCollection() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public List<IRenderPipelineGraphicsSettings> get_settingsList() { }

}

