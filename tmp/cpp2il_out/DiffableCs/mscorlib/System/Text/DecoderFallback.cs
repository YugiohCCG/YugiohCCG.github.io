namespace System.Text;

public abstract class DecoderFallback
{
	private static DecoderFallback s_replacementFallback; //Field offset: 0x0
	private static DecoderFallback s_exceptionFallback; //Field offset: 0x8

	public static DecoderFallback ExceptionFallback
	{
		[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 159
	}

	public abstract int MaxCharCount
	{
		 get { } //Length: 0
	}

	public static DecoderFallback ReplacementFallback
	{
		[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DecoderFallback() { }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static DecoderFallback get_ExceptionFallback() { }

	public abstract int get_MaxCharCount() { }

	[CalledBy(Type = typeof(ASCIIEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static DecoderFallback get_ReplacementFallback() { }

}

