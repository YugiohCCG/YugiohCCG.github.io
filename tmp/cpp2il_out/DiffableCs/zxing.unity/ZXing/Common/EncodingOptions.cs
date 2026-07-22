namespace ZXing.Common;

public class EncodingOptions
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IDictionary<EncodeHintType, Object> <Hints>k__BackingField; //Field offset: 0x10

	public int Height
	{
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TOutput")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 165
		[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
		[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "get_Options", ReturnType = typeof(EncodingOptions))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 117
	}

	[Browsable(False)]
	public private IDictionary<EncodeHintType, Object> Hints
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public int Margin
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 165
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 120
	}

	public bool PureBarcode
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 164
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 122
	}

	public int Width
	{
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TOutput")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 159
		[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
		[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "get_Options", ReturnType = typeof(EncodingOptions))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 117
	}

	[CalledBy(Type = typeof(AztecEncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "get_Options", ReturnType = typeof(EncodingOptions))]
	[CalledBy(Type = typeof(DatamatrixEncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Code128EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PDF417EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QrCodeEncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public EncodingOptions() { }

	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TOutput")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int get_Height() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IDictionary<EncodeHintType, Object> get_Hints() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public int get_Margin() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool get_PureBarcode() { }

	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TOutput")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int get_Width() { }

	[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "get_Options", ReturnType = typeof(EncodingOptions))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Height(int value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Hints(IDictionary<EncodeHintType, Object> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Margin(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void set_PureBarcode(bool value) { }

	[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeWriterGeneric`1), Member = "get_Options", ReturnType = typeof(EncodingOptions))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Width(int value) { }

}

