namespace ZXing;

[Obsolete("Use RGBLuminanceSource with the argument BitmapFormat.RGB565")]
public class RGB565LuminanceSource : RGBLuminanceSource
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected RGB565LuminanceSource(int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBLuminanceSource), Member = "CalculateLuminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	public RGB565LuminanceSource(Byte[] rgb565RawData, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual LuminanceSource CreateLuminanceSource(Byte[] newLuminances, int width, int height) { }

}

