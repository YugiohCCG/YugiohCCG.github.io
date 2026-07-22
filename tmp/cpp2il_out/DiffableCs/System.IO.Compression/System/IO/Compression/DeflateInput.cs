namespace System.IO.Compression;

internal sealed class DeflateInput
{
	[IsReadOnly]
	public struct InputState
	{
		internal readonly int _count; //Field offset: 0x0
		internal readonly int _startIndex; //Field offset: 0x4

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		internal InputState(int count, int startIndex) { }

	}

	[CompilerGenerated]
	private Byte[] <Buffer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <StartIndex>k__BackingField; //Field offset: 0x1C

	internal Byte[] Buffer
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int Count
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int StartIndex
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DeflateInput() { }

	[CallerCount(Count = 0)]
	internal void ConsumeBytes(int n) { }

	[CallerCount(Count = 0)]
	internal InputState DumpState() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Byte[] get_Buffer() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_Count() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_StartIndex() { }

	[CallerCount(Count = 0)]
	internal void RestoreState(InputState state) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_Buffer(Byte[] value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_Count(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_StartIndex(int value) { }

}

