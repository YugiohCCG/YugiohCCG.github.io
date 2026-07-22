namespace Internal.Runtime.Augments;

internal class ReflectionExecutionDomainCallbacks
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReflectionExecutionDomainCallbacks() { }

	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissingMetadataException), Member = ".ctor", ReturnType = typeof(void))]
	internal Exception CreateMissingMetadataException(Type attributeType) { }

}

