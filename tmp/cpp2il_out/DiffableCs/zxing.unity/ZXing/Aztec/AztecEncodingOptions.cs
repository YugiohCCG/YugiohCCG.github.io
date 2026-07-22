namespace ZXing.Aztec;

public class AztecEncodingOptions : EncodingOptions
{

	public Nullable<Int32> ErrorCorrection
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 221
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 252
	}

	public Nullable<Int32> Layers
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 221
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 252
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public AztecEncodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Nullable<Int32> get_ErrorCorrection() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public Nullable<Int32> get_Layers() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_ErrorCorrection(Nullable<Int32> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void set_Layers(Nullable<Int32> value) { }

}

