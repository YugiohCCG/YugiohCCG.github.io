namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets::Method (64))]
public sealed class MustUseReturnValueAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MustUseReturnValueAttribute() { }

}

