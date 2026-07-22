namespace System;

public class NotImplementedException : SystemException
{

	[CallerCount(Count = 2083)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NotImplementedException() { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NotImplementedException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected NotImplementedException(SerializationInfo info, StreamingContext context) { }

}

