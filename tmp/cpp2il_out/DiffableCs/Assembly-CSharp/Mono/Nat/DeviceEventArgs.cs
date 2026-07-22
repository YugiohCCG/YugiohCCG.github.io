namespace Mono.Nat;

public class DeviceEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly INatDevice <Device>k__BackingField; //Field offset: 0x10

	public INatDevice Device
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DeviceEventArgs(INatDevice device) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public INatDevice get_Device() { }

}

