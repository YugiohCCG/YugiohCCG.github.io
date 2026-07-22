namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class PureAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PureAttribute() { }

}

