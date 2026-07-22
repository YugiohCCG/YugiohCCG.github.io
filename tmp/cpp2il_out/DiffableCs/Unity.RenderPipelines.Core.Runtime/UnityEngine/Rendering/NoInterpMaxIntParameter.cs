namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpMaxIntParameter : VolumeParameter<Int32>
{
	public int max; //Field offset: 0x20

	public virtual int value
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 12
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeParameter`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(void))]
	public NoInterpMaxIntParameter(int value, int max, bool overrideState = false) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(int value) { }

}

