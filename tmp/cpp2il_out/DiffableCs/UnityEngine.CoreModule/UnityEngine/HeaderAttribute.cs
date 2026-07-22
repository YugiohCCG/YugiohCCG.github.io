namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = True)]
public class HeaderAttribute : PropertyAttribute
{
	public readonly string header; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public HeaderAttribute(string header) { }

}

