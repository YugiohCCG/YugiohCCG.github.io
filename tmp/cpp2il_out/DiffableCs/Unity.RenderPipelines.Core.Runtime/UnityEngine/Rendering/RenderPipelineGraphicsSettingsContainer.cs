namespace UnityEngine.Rendering;

public class RenderPipelineGraphicsSettingsContainer : ISerializationCallbackReceiver
{
	[HideInInspector]
	[SerializeField]
	private RenderPipelineGraphicsSettingsCollection m_RuntimeSettings; //Field offset: 0x10

	public List<IRenderPipelineGraphicsSettings> settingsList
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RenderPipelineGraphicsSettingsContainer() { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

}

