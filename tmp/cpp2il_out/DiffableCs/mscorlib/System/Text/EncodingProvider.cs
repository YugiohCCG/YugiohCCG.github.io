namespace System.Text;

public abstract class EncodingProvider
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private static EncodingProvider[] s_providers; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static EncodingProvider() { }

	public abstract Encoding GetEncoding(string name) { }

	public abstract Encoding GetEncoding(int codepage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "set_EncoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderFallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "set_DecoderFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderFallback)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

}

