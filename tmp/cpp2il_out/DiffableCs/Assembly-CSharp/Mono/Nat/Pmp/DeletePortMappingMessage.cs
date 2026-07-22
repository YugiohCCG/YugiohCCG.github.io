namespace Mono.Nat.Pmp;

internal class DeletePortMappingMessage : PortMappingMessage
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DeletePortMappingMessage(Mapping mapping) { }

}

