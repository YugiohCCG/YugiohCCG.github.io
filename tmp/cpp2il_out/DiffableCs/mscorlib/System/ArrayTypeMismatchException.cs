namespace System;

public class ArrayTypeMismatchException : SystemException
{

	[CalledBy(Type = typeof(ThrowHelper), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Array), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(ArrayTypeMismatchException))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ArrayTypeMismatchException() { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) { }

}

