namespace UnityEngine.InputSystem;

[InputControlLayout(isGenericTypeOfDevice = True)]
public class Sensor : InputDevice
{

	public float samplingFrequency
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(QuerySamplingFrequencyCommand), Member = "Create", ReturnType = typeof(QuerySamplingFrequencyCommand))]
		[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySamplingFrequencyCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySamplingFrequencyCommand&)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 213
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SetSamplingFrequencyCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(SetSamplingFrequencyCommand))]
		[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetSamplingFrequencyCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetSamplingFrequencyCommand&)}, ReturnType = typeof(long))]
		 set { } //Length: 120
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Sensor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuerySamplingFrequencyCommand), Member = "Create", ReturnType = typeof(QuerySamplingFrequencyCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySamplingFrequencyCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySamplingFrequencyCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public float get_samplingFrequency() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetSamplingFrequencyCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(SetSamplingFrequencyCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetSamplingFrequencyCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetSamplingFrequencyCommand&)}, ReturnType = typeof(long))]
	public void set_samplingFrequency(float value) { }

}

