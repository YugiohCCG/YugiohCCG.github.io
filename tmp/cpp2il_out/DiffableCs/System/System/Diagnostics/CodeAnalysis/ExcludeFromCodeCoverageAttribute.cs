namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(749, Inherited = False, AllowMultiple = False)]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ExcludeFromCodeCoverageAttribute() { }

}

