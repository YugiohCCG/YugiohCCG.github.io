namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpVector3Parameter : VolumeParameter<Vector3>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpVector3Parameter(Vector3 value, bool overrideState = false) { }

}

