namespace Newtonsoft.Json.Utilities;

internal sealed class MethodCall : MulticastDelegate
{

	[CallerCount(Count = 79)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public MethodCall`2(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(T target, Object[] args, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TResult EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override TResult Invoke(T target, Object[] args) { }

}

