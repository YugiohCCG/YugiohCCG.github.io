namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class IntParameter : VolumeParameter<Int32>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public IntParameter(int value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual void Interp(int from, int to, float t) { }

}

