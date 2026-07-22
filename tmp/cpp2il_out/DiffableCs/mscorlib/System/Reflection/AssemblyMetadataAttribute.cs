namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
public sealed class AssemblyMetadataAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; //Field offset: 0x18

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public AssemblyMetadataAttribute(string key, string value) { }

}

