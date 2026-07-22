namespace ZXing;

public sealed class PlanarYUVLuminanceSource : BaseLuminanceSource
{
	private const int THUMBNAIL_SCALE_FACTOR = 2; //Field offset: 0x0
	private readonly Byte[] yuvData; //Field offset: 0x20
	private readonly int dataWidth; //Field offset: 0x28
	private readonly int dataHeight; //Field offset: 0x2C
	private readonly int left; //Field offset: 0x30
	private readonly int top; //Field offset: 0x34

	public virtual bool CropSupported
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Byte[] Matrix
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 297
	}

	public int ThumbnailHeight
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 30
	}

	public int ThumbnailWidth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 30
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public PlanarYUVLuminanceSource(Byte[] yuvData, int dataWidth, int dataHeight, int left, int top, int width, int height, bool reverseHoriz) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private PlanarYUVLuminanceSource(Byte[] luminances, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual LuminanceSource CreateLuminanceSource(Byte[] newLuminances, int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseLuminanceSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual LuminanceSource crop(int left, int top, int width, int height) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CropSupported() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual Byte[] get_Matrix() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int get_ThumbnailHeight() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int get_ThumbnailWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Byte[] getRow(int y, Byte[] row) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Int32[] renderThumbnail() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void reverseHorizontal(int width, int height) { }

}

