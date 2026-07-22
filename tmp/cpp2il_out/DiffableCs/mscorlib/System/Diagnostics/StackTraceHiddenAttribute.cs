namespace System.Diagnostics;

[AttributeUsage(108, Inherited = False)]
internal sealed class StackTraceHiddenAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StackTraceHiddenAttribute() { }

}

