namespace UnityEngine.Rendering;

internal struct ProbeVolumeBakingProcessSettings
{
	public enum SettingsVersion
	{
		Initial = 0,
		ThreadedVirtualOffset = 1,
		Max = 2,
		Current = 1,
	}

	[SerializeField]
	private SettingsVersion m_Version; //Field offset: 0x0
	public ProbeDilationSettings dilationSettings; //Field offset: 0x4
	public VirtualOffsetSettings virtualOffsetSettings; //Field offset: 0x18

	internal static ProbeVolumeBakingProcessSettings Default
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 110
	}

	[CallerCount(Count = 0)]
	internal ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static ProbeVolumeBakingProcessSettings get_Default() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void SetDefaults() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Upgrade() { }

}

