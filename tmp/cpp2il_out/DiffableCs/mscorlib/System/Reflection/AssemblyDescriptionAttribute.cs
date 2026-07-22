namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyDescriptionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public AssemblyDescriptionAttribute(string description) { }

}

