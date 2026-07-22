namespace UnityEngine.InputSystem.Editor;

internal struct SampleFrequencyCalculator
{
	private double m_LastUpdateTime; //Field offset: 0x0
	private int m_SampleCount; //Field offset: 0x8
	[CompilerGenerated]
	private float <targetFrequency>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private float <frequency>k__BackingField; //Field offset: 0x10

	public private float frequency
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	public private float targetFrequency
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	[CallerCount(Count = 0)]
	public SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public float get_frequency() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public float get_targetFrequency() { }

	[CallerCount(Count = 0)]
	public void ProcessSample(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_frequency(float value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_targetFrequency(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartupAsDouble", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public bool Update() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Update(double realtimeSinceStartup) { }

}

