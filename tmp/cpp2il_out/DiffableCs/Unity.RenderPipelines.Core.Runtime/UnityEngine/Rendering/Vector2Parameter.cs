namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Vector2Parameter : VolumeParameter<Vector2>
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LensDistortion", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceLensFlare", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Vignette", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	public Vector2Parameter(Vector2 value, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Interp(Vector2 from, Vector2 to, float t) { }

}

