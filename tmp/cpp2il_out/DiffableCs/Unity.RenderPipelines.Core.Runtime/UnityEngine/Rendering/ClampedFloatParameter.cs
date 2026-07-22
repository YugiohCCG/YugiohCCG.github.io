namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ClampedFloatParameter : FloatParameter
{
	public float min; //Field offset: 0x20
	public float max; //Field offset: 0x24

	public virtual float value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 35
	}

	[CalledBy(Type = typeof(ProbeVolumesOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.WhiteBalance", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Vignette", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Tonemapping", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SplitToning", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceLensFlare", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PaniniProjection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionBlur", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LensDistortion", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FilmGrain", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DepthOfField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorLookup", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ColorAdjustments", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ChromaticAberration", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ChannelMixer", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Bloom", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	public ClampedFloatParameter(float value, float min, float max, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual float get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(float value) { }

}

