namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class RenderingLayerMaskParameter : VolumeParameter<RenderingLayerMask>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public RenderingLayerMaskParameter(RenderingLayerMask value, bool overrideState = false) { }

}

