namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[ComVisible(True)]
public sealed class ComCompatibleVersionAttribute : Attribute
{
	internal int _major; //Field offset: 0x10
	internal int _minor; //Field offset: 0x14
	internal int _build; //Field offset: 0x18
	internal int _revision; //Field offset: 0x1C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) { }

}

