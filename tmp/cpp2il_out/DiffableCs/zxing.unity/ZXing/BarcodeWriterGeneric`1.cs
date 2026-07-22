namespace ZXing;

public class BarcodeWriterGeneric : IBarcodeWriterGeneric<TOutput>
{
	private EncodingOptions options; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BarcodeFormat <Format>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Writer <Encoder>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IBarcodeRenderer<TOutput> <Renderer>k__BackingField; //Field offset: 0x0

	public Writer Encoder
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public BarcodeFormat Format
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public EncodingOptions Options
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(EncodingOptions), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EncodingOptions), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 147
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public IBarcodeRenderer<TOutput> Renderer
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BarcodeWriterGeneric`1() { }

	[CalledBy(Type = typeof(BarcodeWriter), Member = "ZXing.IBarcodeWriter.Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EncodingOptions), Member = "get_Width", ReturnType = typeof(int))]
	[Calls(Type = typeof(EncodingOptions), Member = "get_Height", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override BitMatrix Encode(string contents) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Writer get_Encoder() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BarcodeFormat get_Format() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncodingOptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingOptions), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncodingOptions), Member = "set_Width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public EncodingOptions get_Options() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IBarcodeRenderer<TOutput> get_Renderer() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Encoder(Writer value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Format(BarcodeFormat value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Options(EncodingOptions value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Renderer(IBarcodeRenderer<TOutput> value) { }

	[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BarcodeWriter), Member = "ZXing.IBarcodeWriter.Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Color32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EncodingOptions), Member = "get_Width", ReturnType = typeof(int))]
	[Calls(Type = typeof(EncodingOptions), Member = "get_Height", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override TOutput Write(string contents) { }

	[CalledBy(Type = typeof(BarcodeWriter), Member = "ZXing.IBarcodeWriter.Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(Color32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override TOutput Write(BitMatrix matrix) { }

}

