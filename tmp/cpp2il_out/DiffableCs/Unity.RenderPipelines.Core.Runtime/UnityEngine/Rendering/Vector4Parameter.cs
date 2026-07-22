namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Vector4Parameter : VolumeParameter<Vector4>
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LiftGammaGain", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowsMidtonesHighlights", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public Vector4Parameter(Vector4 value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Interp(Vector4 from, Vector4 to, float t) { }

}

