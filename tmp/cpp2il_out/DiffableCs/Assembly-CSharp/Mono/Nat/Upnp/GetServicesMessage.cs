namespace Mono.Nat.Upnp;

internal class GetServicesMessage : IRequestMessage
{
	[CompilerGenerated]
	private readonly Uri <DeviceServiceUri>k__BackingField; //Field offset: 0x10

	private Uri DeviceServiceUri
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public GetServicesMessage(Uri deviceServiceUri) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public override HttpWebRequest Encode(out Byte[] body) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private Uri get_DeviceServiceUri() { }

}

