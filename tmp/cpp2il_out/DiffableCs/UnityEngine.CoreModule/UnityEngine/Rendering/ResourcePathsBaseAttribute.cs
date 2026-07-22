namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True)]
public abstract class ResourcePathsBaseAttribute : Attribute
{

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ResourcePathsBaseAttribute(String[] paths, bool isField, SearchType location) { }

}

