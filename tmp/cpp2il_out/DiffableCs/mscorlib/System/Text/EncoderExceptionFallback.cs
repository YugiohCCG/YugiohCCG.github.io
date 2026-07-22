namespace System.Text;

public sealed class EncoderExceptionFallback : EncoderFallback
{

	public virtual int MaxCharCount
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EncoderExceptionFallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual int get_MaxCharCount() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

}

