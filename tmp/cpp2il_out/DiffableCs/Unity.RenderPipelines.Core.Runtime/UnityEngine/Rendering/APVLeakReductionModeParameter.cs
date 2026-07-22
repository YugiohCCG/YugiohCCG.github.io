namespace UnityEngine.Rendering;

public sealed class APVLeakReductionModeParameter : VolumeParameter<APVLeakReductionMode>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public APVLeakReductionModeParameter(APVLeakReductionMode value, bool overrideState = false) { }

}

