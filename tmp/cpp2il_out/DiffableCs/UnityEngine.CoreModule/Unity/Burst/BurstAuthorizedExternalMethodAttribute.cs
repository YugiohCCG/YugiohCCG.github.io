namespace Unity.Burst;

[AttributeUsage(AttributeTargets::Method (64))]
public class BurstAuthorizedExternalMethodAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BurstAuthorizedExternalMethodAttribute() { }

}

