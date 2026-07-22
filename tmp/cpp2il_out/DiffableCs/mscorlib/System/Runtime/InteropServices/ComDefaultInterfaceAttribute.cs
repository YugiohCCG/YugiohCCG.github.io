namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[ComVisible(True)]
public sealed class ComDefaultInterfaceAttribute : Attribute
{
	internal Type _val; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ComDefaultInterfaceAttribute(Type defaultInterface) { }

}

