namespace ZXing;

public class RGBLuminanceSource : BaseLuminanceSource
{
	internal enum BitmapFormat
	{
		Unknown = 0,
		Gray8 = 1,
		RGB24 = 2,
		RGB32 = 3,
		ARGB32 = 4,
		BGR24 = 5,
		BGR32 = 6,
		BGRA32 = 7,
		RGB565 = 8,
		RGBA32 = 9,
	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected RGBLuminanceSource(int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBLuminanceSource), Member = "CalculateLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	public RGBLuminanceSource(Byte[] rgbRawBytes, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBLuminanceSource), Member = "CalculateLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	[Obsolete("Use RGBLuminanceSource(luminanceArray, width, height, BitmapFormat.Gray8)")]
	public RGBLuminanceSource(Byte[] luminanceArray, int width, int height, bool is8Bit) { }

	[CalledBy(Type = typeof(BarcodeReaderGeneric`1), Member = "<defaultCreateRGBLuminanceSource>m__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(LuminanceSource))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBLuminanceSource), Member = "CalculateLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	public RGBLuminanceSource(Byte[] rgbRawBytes, int width, int height, BitmapFormat bitmapFormat) { }

	[CalledBy(Type = typeof(RGB565LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	protected void CalculateLuminance(Byte[] rgbRawBytes, BitmapFormat bitmapFormat) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceARGB32(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceBGR24(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceBGR32(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceBGRA32(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceRGB24(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceRGB32(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceRGB565(Byte[] rgb565RawData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void CalculateLuminanceRGBA32(Byte[] rgbRawBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual LuminanceSource CreateLuminanceSource(Byte[] newLuminances, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static BitmapFormat DetermineBitmapFormat(Byte[] rgbRawBytes, int width, int height) { }

}

