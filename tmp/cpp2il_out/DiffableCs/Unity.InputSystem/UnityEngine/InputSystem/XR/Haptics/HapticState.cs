namespace UnityEngine.InputSystem.XR.Haptics;

public struct HapticState
{
	[CompilerGenerated]
	private uint <samplesQueued>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private uint <samplesAvailable>k__BackingField; //Field offset: 0x4

	public private uint samplesAvailable
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public private uint samplesQueued
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public HapticState(uint samplesQueued, uint samplesAvailable) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_samplesAvailable() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_samplesQueued() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_samplesAvailable(uint value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_samplesQueued(uint value) { }

}

