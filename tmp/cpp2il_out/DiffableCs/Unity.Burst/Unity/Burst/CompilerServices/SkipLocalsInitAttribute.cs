namespace Unity.Burst.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64))]
public class SkipLocalsInitAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SkipLocalsInitAttribute() { }

}

