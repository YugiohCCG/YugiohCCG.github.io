namespace System.Runtime.InteropServices;

[AttributeUsage(5149, Inherited = False)]
[ComVisible(True)]
public sealed class GuidAttribute : Attribute
{
	internal string _val; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public GuidAttribute(string guid) { }

}

