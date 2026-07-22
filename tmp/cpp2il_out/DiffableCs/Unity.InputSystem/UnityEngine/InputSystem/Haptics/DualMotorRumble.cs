namespace UnityEngine.InputSystem.Haptics;

internal struct DualMotorRumble
{
	[CompilerGenerated]
	private float <lowFrequencyMotorSpeed>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <highFrequencyMotorSpeed>k__BackingField; //Field offset: 0x4

	public private float highFrequencyMotorSpeed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	public bool isRumbling
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 60
	}

	public private float lowFrequencyMotorSpeed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public float get_highFrequencyMotorSpeed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_isRumbling() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public float get_lowFrequencyMotorSpeed() { }

	[CalledBy(Type = typeof(Gamepad), Member = "PauseHaptics", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualMotorRumbleCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualMotorRumbleCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void PauseHaptics(InputDevice device) { }

	[CalledBy(Type = typeof(Gamepad), Member = "ResetHaptics", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DualMotorRumble), Member = "SetMotorSpeeds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void ResetHaptics(InputDevice device) { }

	[CalledBy(Type = typeof(Gamepad), Member = "ResumeHaptics", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DualMotorRumble), Member = "SetMotorSpeeds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void ResumeHaptics(InputDevice device) { }

	[CallerCount(Count = 14)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_highFrequencyMotorSpeed(float value) { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_lowFrequencyMotorSpeed(float value) { }

	[CalledBy(Type = typeof(Gamepad), Member = "SetMotorSpeeds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualMotorRumble), Member = "ResumeHaptics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DualMotorRumble), Member = "ResetHaptics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualMotorRumbleCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DualMotorRumbleCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency) { }

}

