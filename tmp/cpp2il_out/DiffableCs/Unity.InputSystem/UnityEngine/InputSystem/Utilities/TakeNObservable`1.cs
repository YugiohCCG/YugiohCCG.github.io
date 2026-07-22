namespace UnityEngine.InputSystem.Utilities;

internal class TakeNObservable : IObservable<TValue>
{
	private class Take : IObserver<TValue>
	{
		private IObserver<TValue> m_Observer; //Field offset: 0x0
		private int m_Remaining; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void OnCompleted() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void OnError(Exception error) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public override void OnNext(TValue evt) { }

	}

	private IObservable<TValue> m_Source; //Field offset: 0x0
	private int m_Count; //Field offset: 0x0

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TakeNObservable`1(IObservable<TValue> source, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override IDisposable Subscribe(IObserver<TValue> observer) { }

}

