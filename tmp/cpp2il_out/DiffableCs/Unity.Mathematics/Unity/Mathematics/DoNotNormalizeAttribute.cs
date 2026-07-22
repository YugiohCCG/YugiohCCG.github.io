namespace Unity.Mathematics;

public class DoNotNormalizeAttribute : PropertyAttribute
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DoNotNormalizeAttribute() { }

}

