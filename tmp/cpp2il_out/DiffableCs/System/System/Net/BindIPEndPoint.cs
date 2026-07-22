namespace System.Net;

public sealed class BindIPEndPoint : MulticastDelegate
{

	[CalledBy(Type = "Mono.Nat.Upnp.UpnpNatDevice+<SendMessageAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BindIPEndPoint(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

}

