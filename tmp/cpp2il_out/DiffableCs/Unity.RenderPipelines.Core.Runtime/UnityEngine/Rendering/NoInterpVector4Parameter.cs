namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpVector4Parameter : VolumeParameter<Vector4>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpVector4Parameter(Vector4 value, bool overrideState = false) { }

}

