namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
public sealed class AssemblyDelaySignAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <DelaySign>k__BackingField; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public AssemblyDelaySignAttribute(bool delaySign) { }

}

