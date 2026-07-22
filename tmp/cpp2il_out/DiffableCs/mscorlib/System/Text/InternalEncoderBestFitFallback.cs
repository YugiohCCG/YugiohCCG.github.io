namespace System.Text;

internal class InternalEncoderBestFitFallback : EncoderFallback
{
	internal Encoding _encoding; //Field offset: 0x10
	internal Char[] _arrayBestFit; //Field offset: 0x18

	public virtual int MaxCharCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal InternalEncoderBestFitFallback(Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalEncoderBestFitFallbackBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalEncoderBestFitFallback)}, ReturnType = typeof(void))]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

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

