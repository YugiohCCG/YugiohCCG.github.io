namespace UnityEngine.UIElements;

internal abstract class EventCallbackFunctorBase : IDisposable
{
	public long eventTypeId; //Field offset: 0x10
	public InvokePolicy invokePolicy; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EventCallbackFunctorBase() { }

	public abstract void Dispose() { }

	public abstract void Invoke(EventBase evt) { }

	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback) { }

	public abstract void UnregisterCallback(CallbackEventHandler target, TrickleDown useTrickleDown) { }

}

