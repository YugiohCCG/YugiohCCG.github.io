namespace UnityEngine.Rendering;

[Obsolete("ProbeTouchupVolume has been deprecated (UnityUpgradable) -> ProbeAdjustmentVolume", False)]
public class ProbeTouchupVolume : ProbeAdjustmentVolume
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbeAdjustmentVolume), Member = ".ctor", ReturnType = typeof(void))]
	public ProbeTouchupVolume() { }

}

