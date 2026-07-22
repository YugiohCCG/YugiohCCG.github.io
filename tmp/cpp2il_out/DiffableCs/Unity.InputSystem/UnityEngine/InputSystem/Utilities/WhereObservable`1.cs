namespace UnityEngine.InputSystem.Utilities;

internal class WhereObservable : IObservable<TValue>
{
	private class Where : IObserver<TValue>
	{
		private WhereObservable<TValue> m_Observable; //Field offset: 0x0
		private readonly IObserver<TValue> m_Observer; //Field offset: 0x0

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public Where(WhereObservable<TValue> observable, IObserver<TValue> observer) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void OnCompleted() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void OnError(Exception error) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void OnNext(TValue evt) { }

	}

	private readonly IObservable<TValue> m_Source; //Field offset: 0x0
	private readonly Func<TValue, Boolean> m_Predicate; //Field offset: 0x0

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public WhereObservable`1(IObservable<TValue> source, Func<TValue, Boolean> predicate) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override IDisposable Subscribe(IObserver<TValue> observer) { }

}

