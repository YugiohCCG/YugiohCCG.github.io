namespace System;

public class AccessViolationException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public AccessViolationException() { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected AccessViolationException(SerializationInfo info, StreamingContext context) { }

}

