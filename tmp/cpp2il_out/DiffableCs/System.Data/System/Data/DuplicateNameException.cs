namespace System.Data;

public class DuplicateNameException : DataException
{

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected DuplicateNameException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DuplicateNameException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DuplicateNameException(string s) { }

}

