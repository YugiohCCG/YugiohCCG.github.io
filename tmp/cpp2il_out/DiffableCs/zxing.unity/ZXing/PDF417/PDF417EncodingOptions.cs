namespace ZXing.PDF417;

public class PDF417EncodingOptions : EncodingOptions
{

	public string CharacterSet
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 149
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 161
	}

	public bool Compact
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 122
	}

	public Compaction Compaction
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 177
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 132
	}

	public Dimensions Dimensions
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 97
	}

	public bool DisableECI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 122
	}

	public PDF417ErrorCorrectionLevel ErrorCorrection
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 405
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 132
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public PDF417EncodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public string get_CharacterSet() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_Compact() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Compaction get_Compaction() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public Dimensions get_Dimensions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_DisableECI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public PDF417ErrorCorrectionLevel get_ErrorCorrection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void set_CharacterSet(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Compact(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Compaction(Compaction value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Dimensions(Dimensions value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_DisableECI(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_ErrorCorrection(PDF417ErrorCorrectionLevel value) { }

}

