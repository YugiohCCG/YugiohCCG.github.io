namespace System.Net.NetworkInformation;

public abstract class IPGlobalProperties
{

	public abstract string DomainName
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IPGlobalProperties() { }

	public abstract string get_DomainName() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static IPGlobalProperties GetIPGlobalProperties() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

}

