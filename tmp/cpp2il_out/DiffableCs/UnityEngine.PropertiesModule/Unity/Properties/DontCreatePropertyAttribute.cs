namespace Unity.Properties;

[AttributeUsage(AttributeTargets::Field (256))]
public class DontCreatePropertyAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DontCreatePropertyAttribute() { }

}

