namespace Newtonsoft.Json.Utilities;

internal sealed class Creator : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Creator`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override T EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override T Invoke() { }

}

