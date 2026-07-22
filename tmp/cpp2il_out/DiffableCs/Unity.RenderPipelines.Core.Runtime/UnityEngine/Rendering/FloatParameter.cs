namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class FloatParameter : VolumeParameter<Single>
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorAdjustments", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceLensFlare", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public FloatParameter(float value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	public virtual void Interp(float from, float to, float t) { }

}

