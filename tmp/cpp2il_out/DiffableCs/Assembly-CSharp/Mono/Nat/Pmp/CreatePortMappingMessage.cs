namespace Mono.Nat.Pmp;

internal class CreatePortMappingMessage : PortMappingMessage
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CreatePortMappingMessage(Mapping mapping) { }

}

