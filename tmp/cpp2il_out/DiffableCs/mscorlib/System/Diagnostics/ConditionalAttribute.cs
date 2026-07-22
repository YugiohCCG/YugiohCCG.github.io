namespace System.Diagnostics;

[AttributeUsage(68, AllowMultiple = True)]
public sealed class ConditionalAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <ConditionString>k__BackingField; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ConditionalAttribute(string conditionString) { }

}

