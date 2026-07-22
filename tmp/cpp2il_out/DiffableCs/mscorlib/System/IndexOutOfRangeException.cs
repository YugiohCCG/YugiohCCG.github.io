namespace System;

public sealed class IndexOutOfRangeException : SystemException
{

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public IndexOutOfRangeException() { }

	[CallerCount(Count = 181)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public IndexOutOfRangeException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) { }

}

