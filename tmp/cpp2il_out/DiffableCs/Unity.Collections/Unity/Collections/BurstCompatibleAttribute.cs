namespace Unity.Collections;

[Obsolete("Use GenerateTestsForBurstCompatibility (UnityUpgradable) -> GenerateTestsForBurstCompatibilityAttribute", True)]
public class BurstCompatibleAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BurstCompatibleAttribute() { }

}

