namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ClampedIntParameter : IntParameter
{
	public int min; //Field offset: 0x20
	public int max; //Field offset: 0x24

	public virtual int value
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 24
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Bloom", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DepthOfField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceLensFlare", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public ClampedIntParameter(int value, int min, int max, bool overrideState = false) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(int value) { }

}

