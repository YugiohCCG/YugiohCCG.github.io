namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0x18
	public readonly float max; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public RangeAttribute(float min, float max) { }

}

