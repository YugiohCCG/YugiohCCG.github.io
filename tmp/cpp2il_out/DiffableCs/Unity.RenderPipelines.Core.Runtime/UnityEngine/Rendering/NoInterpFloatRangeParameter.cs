namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
{
	public float min; //Field offset: 0x20
	public float max; //Field offset: 0x24

	public virtual Vector2 value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 38
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.VolumeParameter`1<UnityEngine.Vector2>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual Vector2 get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(Vector2 value) { }

}

