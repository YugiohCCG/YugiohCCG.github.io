namespace UnityEngine.InputSystem.LowLevel;

public struct InputMetrics
{
	[CompilerGenerated]
	private int <maxNumDevices>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <currentNumDevices>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <maxStateSizeInBytes>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <currentStateSizeInBytes>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <currentControlCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <currentLayoutCount>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <totalEventBytes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <totalEventCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <totalUpdateCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private double <totalEventProcessingTime>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private double <totalEventLagTime>k__BackingField; //Field offset: 0x30

	public float averageEventBytesPerFrame
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 21
	}

	public double averageLagTimePerEvent
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 19
	}

	public double averageProcessingTimePerEvent
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 19
	}

	public int currentControlCount
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int currentLayoutCount
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int currentNumDevices
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int currentStateSizeInBytes
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int maxNumDevices
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public int maxStateSizeInBytes
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int totalEventBytes
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int totalEventCount
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public double totalEventLagTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public double totalEventProcessingTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public int totalUpdateCount
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	public float get_averageEventBytesPerFrame() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double get_averageLagTimePerEvent() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public double get_averageProcessingTimePerEvent() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_currentControlCount() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_currentLayoutCount() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_currentNumDevices() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_currentStateSizeInBytes() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_maxNumDevices() { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_maxStateSizeInBytes() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_totalEventBytes() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_totalEventCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public double get_totalEventLagTime() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public double get_totalEventProcessingTime() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_totalUpdateCount() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_currentControlCount(int value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_currentLayoutCount(int value) { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_currentNumDevices(int value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_currentStateSizeInBytes(int value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_maxNumDevices(int value) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_maxStateSizeInBytes(int value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_totalEventBytes(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_totalEventCount(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_totalEventLagTime(double value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_totalEventProcessingTime(double value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_totalUpdateCount(int value) { }

}

