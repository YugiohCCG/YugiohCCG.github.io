namespace ZXing.Rendering;

public class SvgRenderer : IBarcodeRenderer<SvgImage>
{
	internal class SvgImage
	{
		private readonly StringBuilder content; //Field offset: 0x10

		public string Content
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 39
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
			[CallsUnknownMethods(Count = 1)]
			 set { } //Length: 76
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public SvgImage() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public SvgImage(string content) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		internal void AddEnd() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		internal void AddHeader() { }

		[CalledBy(Type = typeof(SvgRenderer), Member = "AppendDarkCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 18)]
		internal void AddRec(int posX, int posY, int width, int height) { }

		[CalledBy(Type = typeof(SvgRenderer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
		[Calls(Type = typeof(SvgImage), Member = "GetColorRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SvgImage), Member = "ConvertAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(double))]
		[Calls(Type = typeof(SvgImage), Member = "GetBackgroundStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 68)]
		internal void AddTag(int displaysizeX, int displaysizeY, int viewboxSizeX, int viewboxSizeY, Color background, Color fill) { }

		[CalledBy(Type = typeof(SvgImage), Member = "AddTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SvgImage), Member = "GetBackgroundStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SvgImage), Member = "GetColorRgba", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		internal static double ConvertAlpha(Color32 alpha) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public string get_Content() { }

		[CalledBy(Type = typeof(SvgImage), Member = "AddTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SvgImage), Member = "ConvertAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(double))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 18)]
		internal static string GetBackgroundStyle(Color32 color) { }

		[CalledBy(Type = typeof(SvgImage), Member = "AddTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 22)]
		internal static string GetColorRgb(Color32 color) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SvgImage), Member = "ConvertAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(double))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 30)]
		internal static string GetColorRgba(Color32 color) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		public void set_Content(string value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual string ToString() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Color32 <Foreground>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Color32 <Background>k__BackingField; //Field offset: 0x14

	public Color32 Background
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Color32 Foreground
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(BarcodeWriterSvg), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[CallsDeduplicatedMethods(Count = 1)]
	public SvgRenderer() { }

	[CalledBy(Type = typeof(SvgRenderer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SvgImage), Member = "AddRec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void AppendDarkCell(SvgImage image, BitMatrix matrix, int offsetX, int offSetY) { }

	[CalledBy(Type = typeof(SvgRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BarcodeFormat), typeof(string)}, ReturnType = typeof(SvgImage))]
	[CalledBy(Type = typeof(SvgRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(SvgImage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SvgImage), Member = "AddTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SvgRenderer), Member = "AppendDarkCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Create(SvgImage image, BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void FindMaximumRectangle(BitMatrix matrix, BitMatrix processed, int startPosX, int startPosY, int endPosY, out int endPosX) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Color32 get_Background() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Color32 get_Foreground() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SvgRenderer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override SvgImage Render(BitMatrix matrix, BarcodeFormat format, string content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SvgRenderer), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SvgImage), typeof(BitMatrix), typeof(BarcodeFormat), typeof(string), typeof(EncodingOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override SvgImage Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Background(Color32 value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Foreground(Color32 value) { }

}

