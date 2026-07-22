namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MaterialParameter : VolumeParameter<Material>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	public MaterialParameter(Material value, bool overrideState = false) { }

}

