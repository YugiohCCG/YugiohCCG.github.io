namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public class InspectorNameAttribute : PropertyAttribute
{
	public readonly string displayName; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public InspectorNameAttribute(string displayName) { }

}

