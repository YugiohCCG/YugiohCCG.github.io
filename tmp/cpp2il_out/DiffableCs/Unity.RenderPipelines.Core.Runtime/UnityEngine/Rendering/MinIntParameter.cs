namespace UnityEngine.Rendering;

[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MinIntParameter : IntParameter
{
	public int min; //Field offset: 0x20

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
	[DeduplicatedMethod]
	public MinIntParameter(int value, int min, bool overrideState = false) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void set_value(int value) { }

}

