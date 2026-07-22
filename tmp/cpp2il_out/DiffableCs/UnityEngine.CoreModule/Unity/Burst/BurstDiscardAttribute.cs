namespace Unity.Burst;

[AttributeUsage(192)]
public class BurstDiscardAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BurstDiscardAttribute() { }

}

