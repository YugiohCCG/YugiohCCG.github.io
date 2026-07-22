namespace UnityEngine.InputSystem.Utilities;

internal class Observer : IObserver<TValue>
{
	private Action<TValue> m_OnNext; //Field offset: 0x0
	private Action m_OnCompleted; //Field offset: 0x0

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Observer`1(Action<TValue> onNext, Action onCompleted = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnCompleted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void OnError(Exception error) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void OnNext(TValue evt) { }

}

