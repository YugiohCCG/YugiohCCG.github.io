namespace DG.Tweening.Core;

public sealed class DOSetter : MulticastDelegate
{

	[CallerCount(Count = 178)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public DOSetter`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(T pNewValue, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(T pNewValue) { }

}

