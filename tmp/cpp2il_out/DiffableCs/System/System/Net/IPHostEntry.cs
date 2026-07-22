namespace System.Net;

public class IPHostEntry
{
	private string hostName; //Field offset: 0x10
	private String[] aliases; //Field offset: 0x18
	private IPAddress[] addressList; //Field offset: 0x20
	internal bool isTrustedHost; //Field offset: 0x28

	public IPAddress[] AddressList
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public String[] Aliases
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string HostName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public IPHostEntry() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public IPAddress[] get_AddressList() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_HostName() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AddressList(IPAddress[] value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Aliases(String[] value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_HostName(string value) { }

}

