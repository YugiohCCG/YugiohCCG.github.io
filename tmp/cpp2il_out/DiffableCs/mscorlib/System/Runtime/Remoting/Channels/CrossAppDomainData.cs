namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainData
{
	private object _ContextID; //Field offset: 0x10
	private int _DomainID; //Field offset: 0x18
	private string _processGuid; //Field offset: 0x20

	internal int DomainID
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal string ProcessID
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "GetProcessGuid", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal CrossAppDomainData(int domainId) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_DomainID() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_ProcessID() { }

}

