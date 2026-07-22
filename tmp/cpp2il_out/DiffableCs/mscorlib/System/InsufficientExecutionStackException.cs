namespace System;

public sealed class InsufficientExecutionStackException : SystemException
{

	[CalledBy(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.StackGuard", Member = "TryEnterOnCurrentStack", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InsufficientExecutionStackException() { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) { }

}

