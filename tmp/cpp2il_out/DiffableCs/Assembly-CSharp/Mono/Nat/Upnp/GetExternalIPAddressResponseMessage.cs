namespace Mono.Nat.Upnp;

internal class GetExternalIPAddressResponseMessage : ResponseMessage
{
	[CompilerGenerated]
	private readonly IPAddress <ExternalIPAddress>k__BackingField; //Field offset: 0x10

	public IPAddress ExternalIPAddress
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public GetExternalIPAddressResponseMessage(XmlNode node) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IPAddress get_ExternalIPAddress() { }

}

