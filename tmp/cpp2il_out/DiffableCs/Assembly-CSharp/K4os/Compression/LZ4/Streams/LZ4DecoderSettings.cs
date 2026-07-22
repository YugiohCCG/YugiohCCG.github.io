namespace K4os.Compression.LZ4.Streams;

public class LZ4DecoderSettings
{
	[CompilerGenerated]
	private static readonly LZ4DecoderSettings <Default>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <ExtraMemory>k__BackingField; //Field offset: 0x10

	internal static LZ4DecoderSettings Default
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 78
	}

	public int ExtraMemory
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static LZ4DecoderSettings() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LZ4DecoderSettings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static LZ4DecoderSettings get_Default() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_ExtraMemory() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ExtraMemory(int value) { }

}

