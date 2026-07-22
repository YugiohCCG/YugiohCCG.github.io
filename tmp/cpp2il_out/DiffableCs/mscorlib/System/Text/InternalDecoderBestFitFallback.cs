namespace System.Text;

internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	internal Encoding _encoding; //Field offset: 0x10
	internal Char[] _arrayBestFit; //Field offset: 0x18
	internal char _cReplacement; //Field offset: 0x20

	public virtual int MaxCharCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal InternalDecoderBestFitFallback(Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalDecoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalDecoderBestFitFallback)}, ReturnType = typeof(void))]
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_MaxCharCount() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

