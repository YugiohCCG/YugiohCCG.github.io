namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpClampedIntParameter : VolumeParameter<Int32>
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(int value) { }

}

