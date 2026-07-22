namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpFloatParameter : VolumeParameter<Single>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpFloatParameter(float value, bool overrideState = false) { }

}

