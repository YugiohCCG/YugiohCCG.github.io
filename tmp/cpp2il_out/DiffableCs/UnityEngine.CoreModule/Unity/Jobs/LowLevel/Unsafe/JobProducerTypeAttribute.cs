namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Interface (1024))]
public sealed class JobProducerTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Type <ProducerType>k__BackingField; //Field offset: 0x10

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public JobProducerTypeAttribute(Type producerType) { }

}

