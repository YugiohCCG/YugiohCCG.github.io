namespace System.Runtime.InteropServices;

[AttributeUsage(5597, Inherited = False)]
[ComVisible(True)]
public sealed class ComVisibleAttribute : Attribute
{
	internal bool _val; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ComVisibleAttribute(bool visibility) { }

}

