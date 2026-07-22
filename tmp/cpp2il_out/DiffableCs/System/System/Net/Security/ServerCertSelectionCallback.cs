namespace System.Net.Security;

internal sealed class ServerCertSelectionCallback : MulticastDelegate
{

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ServerCertSelectionCallback(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override X509Certificate Invoke(string hostName) { }

}

