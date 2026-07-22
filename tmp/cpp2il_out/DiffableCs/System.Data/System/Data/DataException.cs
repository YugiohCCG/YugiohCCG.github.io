namespace System.Data;

public class DataException : SystemException
{

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DataException(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(InvalidExpressionException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EvaluateException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyntaxErrorException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DataException() { }

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DataException(string s) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public DataException(string s, Exception innerException) { }

}

