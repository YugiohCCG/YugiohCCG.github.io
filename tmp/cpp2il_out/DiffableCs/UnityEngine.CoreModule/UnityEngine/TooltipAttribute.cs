namespace UnityEngine;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
public class TooltipAttribute : PropertyAttribute
{
	public readonly string tooltip; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TooltipAttribute(string tooltip) { }

}

