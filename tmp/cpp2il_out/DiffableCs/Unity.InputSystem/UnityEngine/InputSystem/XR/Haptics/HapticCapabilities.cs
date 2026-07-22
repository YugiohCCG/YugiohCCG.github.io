namespace UnityEngine.InputSystem.XR.Haptics;

public struct HapticCapabilities
{
	[CompilerGenerated]
	private readonly uint <numChannels>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <supportsImpulse>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private readonly bool <supportsBuffer>k__BackingField; //Field offset: 0x5
	[CompilerGenerated]
	private readonly uint <frequencyHz>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly uint <maxBufferSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly uint <optimalBufferSize>k__BackingField; //Field offset: 0x10

	public uint frequencyHz
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public uint maxBufferSize
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public uint numChannels
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
	}

	public uint optimalBufferSize
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public bool supportsBuffer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public bool supportsImpulse
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize) { }

	[CallerCount(Count = 0)]
	public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize) { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_frequencyHz() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_maxBufferSize() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_numChannels() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_optimalBufferSize() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_supportsBuffer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_supportsImpulse() { }

}

