namespace System;

public sealed class InvalidProgramException : SystemException
{

	[CalledBy(Type = "System.Linq.Expressions.Error", Member = "InvalidProgram", ReturnType = typeof(Exception))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidProgramException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidProgramException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal InvalidProgramException(SerializationInfo info, StreamingContext context) { }

}

