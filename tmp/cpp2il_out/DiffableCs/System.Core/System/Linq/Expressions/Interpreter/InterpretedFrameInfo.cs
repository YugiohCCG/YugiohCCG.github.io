namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct InterpretedFrameInfo
{
	private readonly string _methodName; //Field offset: 0x0
	private readonly DebugInfo _debugInfo; //Field offset: 0x8

	[CallerCount(Count = 68)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public InterpretedFrameInfo(string methodName, DebugInfo info) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

}

