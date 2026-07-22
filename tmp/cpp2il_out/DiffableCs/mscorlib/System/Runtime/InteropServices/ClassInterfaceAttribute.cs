namespace System.Runtime.InteropServices;

[AttributeUsage(5, Inherited = False)]
[ComVisible(True)]
public sealed class ClassInterfaceAttribute : Attribute
{
	internal ClassInterfaceType _val; //Field offset: 0x10

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType) { }

}

