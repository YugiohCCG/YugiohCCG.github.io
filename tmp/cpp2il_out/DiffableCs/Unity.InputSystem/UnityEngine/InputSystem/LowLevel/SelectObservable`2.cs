namespace UnityEngine.InputSystem.LowLevel;

internal class SelectObservable : IObservable<TResult>
{
	private class Select : IObserver<TSource>
	{
		private SelectObservable<TSource, TResult> m_Observable; //Field offset: 0x0
		private readonly IObserver<TResult> m_Observer; //Field offset: 0x0

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer) { }

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
		public override void OnNext(TSource evt) { }

	}

	private readonly IObservable<TSource> m_Source; //Field offset: 0x0
	private readonly Func<TSource, TResult> m_Filter; //Field offset: 0x0

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public SelectObservable`2(IObservable<TSource> source, Func<TSource, TResult> filter) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override IDisposable Subscribe(IObserver<TResult> observer) { }

}

