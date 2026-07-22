namespace System.Diagnostics.Tracing;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class NonEventAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NonEventAttribute() { }

}

