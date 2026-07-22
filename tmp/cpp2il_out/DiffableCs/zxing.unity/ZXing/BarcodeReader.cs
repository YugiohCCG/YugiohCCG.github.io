namespace ZXing;

public class BarcodeReader : BarcodeReaderGeneric<Color32[]>, IBarcodeReader, IMultipleBarcodeReader
{
	private static readonly Func<Color32[], Int32, Int32, LuminanceSource> defaultCreateLuminanceSource; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Int32, System.Int32, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static BarcodeReader() { }

	[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), "System.Func`4<T, Int32, Int32, LuminanceSource>", typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public BarcodeReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), "System.Func`4<T, Int32, Int32, LuminanceSource>", typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>)}, ReturnType = typeof(void))]
	public BarcodeReader(Reader reader, Func<Color32[], Int32, Int32, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Reader), "System.Func`4<T, Int32, Int32, LuminanceSource>", typeof(System.Func`2<ZXing.LuminanceSource, ZXing.Binarizer>), typeof(System.Func`5<Byte[], System.Int32, System.Int32, ZXing.RGBLuminanceSource+BitmapFormat, ZXing.LuminanceSource>)}, ReturnType = typeof(void))]
	public BarcodeReader(Reader reader, Func<Color32[], Int32, Int32, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer, Func<Byte[], Int32, Int32, BitmapFormat, LuminanceSource> createRGBLuminanceSource) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color32LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	private static LuminanceSource <defaultCreateLuminanceSource>m__0(Color32[] rawColor32, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.add_ResultFound(Action<Result> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.add_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(Result))]
	private override Result ZXing.IBarcodeReader.Decode(Byte[] rawRGB, int width, int height, BitmapFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int)}, ReturnType = typeof(Result))]
	private override Result ZXing.IBarcodeReader.Decode(Color32[] rawColor32, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_CharacterSet", ReturnType = typeof(string))]
	private override string ZXing.IBarcodeReader.get_CharacterSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_Options", ReturnType = typeof(DecodingOptions))]
	private override DecodingOptions ZXing.IBarcodeReader.get_Options() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	private override IList<BarcodeFormat> ZXing.IBarcodeReader.get_PossibleFormats() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PureBarcode", ReturnType = typeof(bool))]
	private override bool ZXing.IBarcodeReader.get_PureBarcode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_TryHarder", ReturnType = typeof(bool))]
	private override bool ZXing.IBarcodeReader.get_TryHarder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.remove_ResultFound(Action<Result> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.remove_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.set_CharacterSet(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override void ZXing.IBarcodeReader.set_Options(DecodingOptions value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.set_PossibleFormats(IList<BarcodeFormat> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.set_PureBarcode(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override void ZXing.IBarcodeReader.set_TryHarder(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "add_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.add_ResultFound(Action<Result> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "add_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.add_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(Result[]))]
	private override Result[] ZXing.IMultipleBarcodeReader.DecodeMultiple(Byte[] rawRGB, int width, int height, BitmapFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "DecodeMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(int)}, ReturnType = typeof(Result[]))]
	private override Result[] ZXing.IMultipleBarcodeReader.DecodeMultiple(Color32[] rawColor32, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_CharacterSet", ReturnType = typeof(string))]
	private override string ZXing.IMultipleBarcodeReader.get_CharacterSet() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_Options", ReturnType = typeof(DecodingOptions))]
	private override DecodingOptions ZXing.IMultipleBarcodeReader.get_Options() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PossibleFormats", ReturnType = typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>))]
	private override IList<BarcodeFormat> ZXing.IMultipleBarcodeReader.get_PossibleFormats() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_PureBarcode", ReturnType = typeof(bool))]
	private override bool ZXing.IMultipleBarcodeReader.get_PureBarcode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "get_TryHarder", ReturnType = typeof(bool))]
	private override bool ZXing.IMultipleBarcodeReader.get_TryHarder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "remove_ResultFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.Result>)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.remove_ResultFound(Action<Result> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "remove_ResultPointFound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<ZXing.ResultPoint>)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.remove_ResultPointFound(Action<ResultPoint> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_CharacterSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.set_CharacterSet(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override void ZXing.IMultipleBarcodeReader.set_Options(DecodingOptions value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PossibleFormats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<ZXing.BarcodeFormat>)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.set_PossibleFormats(IList<BarcodeFormat> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_PureBarcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.set_PureBarcode(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeReaderGeneric`1), Member = "set_TryHarder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private override void ZXing.IMultipleBarcodeReader.set_TryHarder(bool value) { }

}

