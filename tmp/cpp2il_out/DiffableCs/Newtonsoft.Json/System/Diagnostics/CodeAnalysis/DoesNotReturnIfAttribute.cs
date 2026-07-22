namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
internal class DoesNotReturnIfAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ParameterValue>k__BackingField; //Field offset: 0x10

	public bool ParameterValue
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DoesNotReturnIfAttribute(bool parameterValue) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ParameterValue() { }

}

