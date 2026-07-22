namespace ZXing;

public sealed class MultiFormatWriter : Writer
{
	private static readonly IDictionary<BarcodeFormat, Func`1<Writer>> formatMap; //Field offset: 0x0

	public static ICollection<BarcodeFormat> SupportedWriters
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 116
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 2)]
	private static MultiFormatWriter() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MultiFormatWriter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__0() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UPCAWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__3() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__4() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__5() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__6() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__7() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__8() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__9() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__A() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__B() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	private static Writer <MultiFormatWriter>m__C() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiFormatWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height) { }

	[CalledBy(Type = typeof(MultiFormatWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static ICollection<BarcodeFormat> get_SupportedWriters() { }

}

