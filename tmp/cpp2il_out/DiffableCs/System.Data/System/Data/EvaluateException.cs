namespace System.Data;

public class EvaluateException : InvalidExpressionException
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EvaluateException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public EvaluateException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public EvaluateException(string s) { }

}

