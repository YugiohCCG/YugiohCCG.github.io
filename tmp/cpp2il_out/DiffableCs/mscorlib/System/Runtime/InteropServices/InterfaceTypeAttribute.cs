namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Interface (1024), Inherited = False)]
[ComVisible(True)]
public sealed class InterfaceTypeAttribute : Attribute
{
	internal ComInterfaceType _val; //Field offset: 0x10

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InterfaceTypeAttribute(ComInterfaceType interfaceType) { }

}

