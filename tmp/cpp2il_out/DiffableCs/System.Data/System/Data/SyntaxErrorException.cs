namespace System.Data;

public class SyntaxErrorException : InvalidExpressionException
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected SyntaxErrorException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SyntaxErrorException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SyntaxErrorException(string s) { }

}

