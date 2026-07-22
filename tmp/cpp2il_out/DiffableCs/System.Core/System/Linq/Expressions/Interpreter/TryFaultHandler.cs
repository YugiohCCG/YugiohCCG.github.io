namespace System.Linq.Expressions.Interpreter;

internal sealed class TryFaultHandler
{
	internal readonly int TryStartIndex; //Field offset: 0x10
	internal readonly int TryEndIndex; //Field offset: 0x14
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	internal readonly int FinallyEndIndex; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }

}

