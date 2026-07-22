namespace ZXing.OneD;

public class Code128EncodingOptions : EncodingOptions
{

	public bool ForceCodesetB
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 122
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Code128EncodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_ForceCodesetB() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_ForceCodesetB(bool value) { }

}

