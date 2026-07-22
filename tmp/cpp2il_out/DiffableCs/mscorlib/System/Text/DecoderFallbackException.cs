namespace System.Text;

public sealed class DecoderFallbackException : ArgumentException
{
	private Byte[] _bytesUnknown; //Field offset: 0x98
	private int _index; //Field offset: 0xA0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DecoderFallbackException() { }

	[CalledBy(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public DecoderFallbackException(string message, Byte[] bytesUnknown, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

