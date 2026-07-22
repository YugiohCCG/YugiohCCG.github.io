namespace System.Linq;

internal abstract class OrderedEnumerable : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TElement <>2__current; //Field offset: 0x0
		public OrderedEnumerable<TElement> <>4__this; //Field offset: 0x0
		private Buffer<TElement> <buffer>5__2; //Field offset: 0x0
		private Int32[] <map>5__3; //Field offset: 0x0
		private int <i>5__4; //Field offset: 0x0

		private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 43
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetEnumerator>d__1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Buffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EnumerableSorter`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement[]", typeof(int)}, ReturnType = typeof(Int32[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	internal IEnumerable<TElement> source; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected OrderedEnumerable`1() { }

	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
	public override IEnumerator<TElement> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

