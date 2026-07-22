namespace System.Runtime.ConstrainedExecution;

[AttributeUsage(1133, Inherited = False)]
public sealed class ReliabilityContractAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Cer <Cer>k__BackingField; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) { }

}

