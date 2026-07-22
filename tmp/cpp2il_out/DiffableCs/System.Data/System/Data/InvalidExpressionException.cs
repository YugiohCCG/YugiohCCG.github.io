namespace System.Data;

public class InvalidExpressionException : DataException
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected InvalidExpressionException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public InvalidExpressionException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public InvalidExpressionException(string s) { }

}

