namespace ZXing;

public abstract class LuminanceSource
{
	private int width; //Field offset: 0x10
	private int height; //Field offset: 0x14

	public override bool CropSupported
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int Height
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override bool InversionSupported
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public abstract Byte[] Matrix
	{
		 get { } //Length: 0
	}

	public override bool RotateSupported
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int Width
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 79)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected LuminanceSource(int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override LuminanceSource crop(int left, int top, int width, int height) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_CropSupported() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_Height() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_InversionSupported() { }

	public abstract Byte[] get_Matrix() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_RotateSupported() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_Width() { }

	public abstract Byte[] getRow(int y, Byte[] row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override LuminanceSource invert() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override LuminanceSource rotateCounterClockwise() { }

	[CalledBy(Type = typeof(BaseLuminanceSource), Member = "rotateCounterClockwise45", ReturnType = typeof(LuminanceSource))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override LuminanceSource rotateCounterClockwise45() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	protected override void set_Height(int value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	protected override void set_Width(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

}

