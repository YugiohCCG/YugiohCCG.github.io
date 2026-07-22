namespace ZXing;

public class BarcodeReaderGeneric : IBarcodeReaderGeneric<T>, IMultipleBarcodeReaderGeneric<T>
{
	private static readonly Func<LuminanceSource, Binarizer> defaultCreateBinarizer; //Field offset: 0x0
	protected static readonly Func<Byte[], Int32, Int32, BitmapFormat, LuminanceSource> defaultCreateRGBLuminanceSource; //Field offset: 0x0
	private Reader reader; //Field offset: 0x0
	private readonly Func<Byte[], Int32, Int32, BitmapFormat, LuminanceSource> createRGBLuminanceSource; //Field offset: 0x0
	private readonly Func<T, Int32, Int32, LuminanceSource> createLuminanceSource; //Field offset: 0x0
	private readonly Func<LuminanceSource, Binarizer> createBinarizer; //Field offset: 0x0
	private bool usePreviousState; //Field offset: 0x0
	private DecodingOptions options; //Field offset: 0x0
	private Action<ResultPoint> explicitResultPointFound; //Field offset: 0x0
	private Action<Result> ResultFound; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <AutoRotate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <TryInverted>k__BackingField; //Field offset: 0x0

	private event Action<ResultPoint> explicitResultPointFound
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private add { } //Length: 161
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private remove { } //Length: 161
	}

	public override event Action<Result> ResultFound
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 add { } //Length: 161
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 remove { } //Length: 161
	}

	public override event Action<ResultPoint> ResultPointFound
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		 add { } //Length: 423
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 remove { } //Length: 280
	}

	public bool AutoRotate
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Obsolete("Please use the Options.CharacterSet property instead.")]
	public override string CharacterSet
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_CharacterSet", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_CharacterSet", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "get_CharacterSet", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 58
	}

	protected Func<LuminanceSource, Binarizer> CreateBinarizer
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 123
	}

	protected Func<T, Int32, Int32, LuminanceSource> CreateLuminanceSource
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override DecodingOptions Options
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_Options", ReturnType = typeof(DecodingOptions))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_Options", ReturnType = typeof(DecodingOptions))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 106
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[Obsolete("Please use the Options.PossibleFormats property instead.")]
	public override IList<BarcodeFormat> PossibleFormats
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 58
	}

	[Obsolete("Please use the Options.PureBarcode property instead.")]
	public override bool PureBarcode
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_PureBarcode", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_PureBarcode", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "get_PureBarcode", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 58
	}

	protected Reader Reader
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 106
	}

	[Obsolete("Please use the Options.TryHarder property instead.")]
	public override bool TryHarder
	{
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_TryHarder", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_TryHarder", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "get_TryHarder", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecodingOptions), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 58
	}

	public bool TryInverted
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private static BarcodeReaderGeneric`1() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public BarcodeReaderGeneric`1() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), typeof(System.Func`4<Color32[], System.Int32, System.Int32, ZXing.LuminanceSource>), typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public BarcodeReaderGeneric`1(Reader reader, Func<T, Int32, Int32, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), typeof(System.Func`4<Color32[], System.Int32, System.Int32, ZXing.LuminanceSource>), typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>), typeof(System.Func`5<Byte[], System.Int32, System.Int32, ZXing.RGBLuminanceSource+BitmapFormat, ZXing.LuminanceSource>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecodingOptions), Member = "add_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Object, System.EventArgs>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public BarcodeReaderGeneric`1(Reader reader, Func<T, Int32, Int32, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer, Func<Byte[], Int32, Int32, BitmapFormat, LuminanceSource> createRGBLuminanceSource) { }

	[CallerCount(Count = 13)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void <BarcodeReaderGeneric>m__0(object o, EventArgs args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HybridBinarizer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private static Binarizer <defaultCreateBinarizer>m__1(LuminanceSource luminanceSource) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private static LuminanceSource <defaultCreateRGBLuminanceSource>m__2(Byte[] rawBytes, int width, int height, BitmapFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void add_explicitResultPointFound(Action<ResultPoint> value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void add_ResultFound(Action<Result> value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public override void add_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binarizer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiFormatReader), Member = "decodeWithState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap)}, ReturnType = typeof(Result))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override Result Decode(LuminanceSource luminanceSource) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[]), typeof(int), typeof(int)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override Result Decode(T rawRGB, int width, int height) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override Result Decode(Byte[] rawRGB, int width, int height, BitmapFormat format) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override Result[] DecodeMultiple(Byte[] rawRGB, int width, int height, BitmapFormat format) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[]), typeof(int), typeof(int)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override Result[] DecodeMultiple(T rawRGB, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryBitmap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binarizer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DecodingOptions), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	[Calls(Type = typeof(QRCodeMultiReader), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Result), Member = "putMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultMetadataType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "OnResultsFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<ZXing.Result>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override Result[] DecodeMultiple(LuminanceSource luminanceSource) { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_AutoRotate() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_CharacterSet", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_CharacterSet", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "get_CharacterSet", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override string get_CharacterSet() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected Func<LuminanceSource, Binarizer> get_CreateBinarizer() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected Func<T, Int32, Int32, LuminanceSource> get_CreateLuminanceSource() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_Options", ReturnType = typeof(DecodingOptions))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_Options", ReturnType = typeof(DecodingOptions))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override DecodingOptions get_Options() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IList<BarcodeFormat> get_PossibleFormats() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_PureBarcode", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_PureBarcode", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "get_PureBarcode", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool get_PureBarcode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Reader get_Reader() { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.get_TryHarder", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.get_TryHarder", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "get_TryHarder", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool get_TryHarder() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_TryInverted() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void OnResultFound(Result result) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void OnResultPointFound(ResultPoint resultPoint) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(Result[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	protected void OnResultsFound(IEnumerable<Result> results) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void remove_explicitResultPointFound(Action<ResultPoint> value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void remove_ResultFound(Action<Result> value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override void remove_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_AutoRotate(bool value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_CharacterSet(string value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Options(DecodingOptions value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_PossibleFormats(IList<BarcodeFormat> value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_PureBarcode(bool value) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IBarcodeReader.set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeReader), Member = "ZXing.IMultipleBarcodeReader.set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecodingOptions), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_TryHarder(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_TryInverted(bool value) { }

}

