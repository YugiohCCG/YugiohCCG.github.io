namespace System.Data;

internal abstract class AutoIncrementValue
{
	[CompilerGenerated]
	private bool <Auto>k__BackingField; //Field offset: 0x10

	internal bool Auto
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 370
	}

	internal abstract object Current
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal abstract Type DataType
	{
		internal get { } //Length: 0
	}

	internal abstract long Seed
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal abstract long Step
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AutoIncrementValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AutoIncrementBigInteger), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	internal AutoIncrementValue Clone() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_Auto() { }

	internal abstract object get_Current() { }

	internal abstract Type get_DataType() { }

	internal abstract long get_Seed() { }

	internal abstract long get_Step() { }

	internal abstract void MoveAfter() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_Auto(bool value) { }

	internal abstract void set_Current(object value) { }

	internal abstract void set_Seed(long value) { }

	internal abstract void set_Step(long value) { }

	internal abstract void SetCurrent(object value, IFormatProvider formatProvider) { }

	internal abstract void SetCurrentAndIncrement(object value) { }

}

