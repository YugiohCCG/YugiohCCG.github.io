namespace Mono.Net.Security;

internal class AsyncHandshakeRequest : AsyncProtocolRequest
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncProtocolRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(bool)}, ReturnType = typeof(void))]
	public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncOperationStatus), typeof(bool)}, ReturnType = typeof(AsyncOperationStatus))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

