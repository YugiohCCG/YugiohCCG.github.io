namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Vector3Parameter : VolumeParameter<Vector3>
{

	[CalledBy(Type = typeof(ProbeVolumesOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(void))]
	public Vector3Parameter(Vector3 value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	public virtual void Interp(Vector3 from, Vector3 to, float t) { }

}

