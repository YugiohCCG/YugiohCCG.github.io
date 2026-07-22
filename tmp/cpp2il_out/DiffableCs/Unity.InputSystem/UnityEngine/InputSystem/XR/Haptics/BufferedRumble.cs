namespace UnityEngine.InputSystem.XR.Haptics;

public struct BufferedRumble
{
	[CompilerGenerated]
	private HapticCapabilities <capabilities>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x18

	public private HapticCapabilities capabilities
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 16
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private InputDevice device
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		private get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetHapticCapabilitiesCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetHapticCapabilitiesCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BufferedRumble(InputDevice device) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendBufferedHapticCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendBufferedHapticCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void EnqueueRumble(Byte[] samples) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[IsReadOnly]
	public HapticCapabilities get_capabilities() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	private InputDevice get_device() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_capabilities(HapticCapabilities value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_device(InputDevice value) { }

}

