namespace System.Linq.Expressions.Interpreter;

internal sealed class RethrowException : Exception
{

	[CalledBy(Type = typeof(ThrowInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public RethrowException() { }

}

