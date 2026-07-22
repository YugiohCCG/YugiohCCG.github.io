namespace ZXing;

public class Color32LuminanceSource : BaseLuminanceSource
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Color32LuminanceSource(int width, int height) { }

	[CalledBy(Type = typeof(BarcodeReader), Member = "<defaultCreateLuminanceSource>m__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[]), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public Color32LuminanceSource(Color32[] color32s, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual LuminanceSource CreateLuminanceSource(Byte[] newLuminances, int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void SetPixels(Color32[] color32s) { }

}

