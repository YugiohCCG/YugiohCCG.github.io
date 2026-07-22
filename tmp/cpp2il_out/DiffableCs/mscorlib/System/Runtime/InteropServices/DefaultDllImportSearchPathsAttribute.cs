namespace System.Runtime.InteropServices;

[AttributeUsage(65, AllowMultiple = False)]
[ComVisible(False)]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute
{
	internal DllImportSearchPath _paths; //Field offset: 0x10

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths) { }

}

