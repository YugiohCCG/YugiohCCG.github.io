namespace UnityEngine.Rendering;

internal class LogarithmicAttribute : PropertyAttribute
{
	public int min; //Field offset: 0x18
	public int max; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LogarithmicAttribute(int min, int max) { }

}

