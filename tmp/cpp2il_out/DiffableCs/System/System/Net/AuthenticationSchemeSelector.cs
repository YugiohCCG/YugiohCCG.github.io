namespace System.Net;

public sealed class AuthenticationSchemeSelector : MulticastDelegate
{

	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public AuthenticationSchemeSelector(object object, IntPtr method) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override AuthenticationSchemes Invoke(HttpListenerRequest httpRequest) { }

}

