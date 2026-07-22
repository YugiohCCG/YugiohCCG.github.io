namespace UnityEngine.InputSystem.UI;

internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData
{
	[CompilerGenerated]
	private InputDevice <device>k__BackingField; //Field offset: 0x20

	public override InputDevice device
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExtendedSubmitCancelEventData(EventSystem eventSystem) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override InputDevice get_device() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_device(InputDevice value) { }

}

