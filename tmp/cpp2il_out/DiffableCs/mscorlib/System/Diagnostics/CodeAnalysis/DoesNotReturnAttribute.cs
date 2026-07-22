namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
public sealed class DoesNotReturnAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DoesNotReturnAttribute() { }

}

