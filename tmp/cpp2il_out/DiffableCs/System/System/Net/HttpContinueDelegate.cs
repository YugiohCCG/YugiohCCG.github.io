namespace System.Net;

public sealed class HttpContinueDelegate : MulticastDelegate
{

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public HttpContinueDelegate(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

}

