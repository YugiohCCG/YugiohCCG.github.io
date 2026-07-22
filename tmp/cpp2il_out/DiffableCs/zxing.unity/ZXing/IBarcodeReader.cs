namespace ZXing;

public interface IBarcodeReader
{

	public event Action<Result> ResultFound
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event Action<ResultPoint> ResultPointFound
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	[Obsolete("Please use the Options.CharacterSet property instead.")]
	public string CharacterSet
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public DecodingOptions Options
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[Obsolete("Please use the Options.PossibleFormats property instead.")]
	public IList<BarcodeFormat> PossibleFormats
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[Obsolete("Please use the Options.PureBarcode property instead.")]
	public bool PureBarcode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[Obsolete("Please use the Options.TryHarder property instead.")]
	public bool TryHarder
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void add_ResultFound(Action<Result> value) { }

	public void add_ResultPointFound(Action<ResultPoint> value) { }

	public Result Decode(Byte[] rawRGB, int width, int height, BitmapFormat format) { }

	public Result Decode(LuminanceSource luminanceSource) { }

	public Result Decode(Color32[] rawColor32, int width, int height) { }

	public string get_CharacterSet() { }

	public DecodingOptions get_Options() { }

	public IList<BarcodeFormat> get_PossibleFormats() { }

	public bool get_PureBarcode() { }

	public bool get_TryHarder() { }

	public void remove_ResultFound(Action<Result> value) { }

	public void remove_ResultPointFound(Action<ResultPoint> value) { }

	public void set_CharacterSet(string value) { }

	public void set_Options(DecodingOptions value) { }

	public void set_PossibleFormats(IList<BarcodeFormat> value) { }

	public void set_PureBarcode(bool value) { }

	public void set_TryHarder(bool value) { }

}

