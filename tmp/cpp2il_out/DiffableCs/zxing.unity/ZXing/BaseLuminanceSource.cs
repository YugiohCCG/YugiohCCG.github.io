namespace ZXing;

public abstract class BaseLuminanceSource : LuminanceSource
{
	protected const int RChannelWeight = 19562; //Field offset: 0x0
	protected const int GChannelWeight = 38550; //Field offset: 0x0
	protected const int BChannelWeight = 7424; //Field offset: 0x0
	protected const int ChannelWeight = 16; //Field offset: 0x0
	protected Byte[] luminances; //Field offset: 0x18

	public virtual bool CropSupported
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool InversionSupported
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Byte[] Matrix
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual bool RotateSupported
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(PlanarYUVLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Color32LuminanceSource), Member = "CreateLuminanceSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CalledBy(Type = typeof(Color32LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Color32LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = "CreateLuminanceSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(BitmapFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB565LuminanceSource), Member = "CreateLuminanceSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CalledBy(Type = typeof(RGB565LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB565LuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlanarYUVLuminanceSource), Member = "CreateLuminanceSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CalledBy(Type = typeof(PlanarYUVLuminanceSource), Member = "crop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(LuminanceSource))]
	[CalledBy(Type = typeof(PlanarYUVLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected BaseLuminanceSource(int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected BaseLuminanceSource(Byte[] luminanceArray, int width, int height) { }

	protected abstract LuminanceSource CreateLuminanceSource(Byte[] newLuminances, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public virtual LuminanceSource crop(int left, int top, int width, int height) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CropSupported() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_InversionSupported() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual Byte[] get_Matrix() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_RotateSupported() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Byte[] getRow(int y, Byte[] row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvertedLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuminanceSource)}, ReturnType = typeof(void))]
	public virtual LuminanceSource invert() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	public virtual LuminanceSource rotateCounterClockwise() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LuminanceSource), Member = "rotateCounterClockwise45", ReturnType = typeof(LuminanceSource))]
	public virtual LuminanceSource rotateCounterClockwise45() { }

}

