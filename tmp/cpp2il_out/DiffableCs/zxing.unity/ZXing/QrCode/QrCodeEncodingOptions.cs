namespace ZXing.QrCode;

public class QrCodeEncodingOptions : EncodingOptions
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

	public bool DisableECI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 122
	}

	public ErrorCorrectionLevel ErrorCorrection
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 158
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public QrCodeEncodingOptions() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public string get_CharacterSet() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_DisableECI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public ErrorCorrectionLevel get_ErrorCorrection() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void set_CharacterSet(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_DisableECI(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void set_ErrorCorrection(ErrorCorrectionLevel value) { }

}

