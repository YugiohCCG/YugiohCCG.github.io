namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class DelayedAttribute : PropertyAttribute
{

	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DelayedAttribute() { }

}

