namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView`1))]
public class ConcurrentQueue : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[CompilerGenerated]
	private sealed class <Enumerate>d__28 : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public Segment<T> head; //Field offset: 0x0
		public Segment<T> tail; //Field offset: 0x0
		public int tailTail; //Field offset: 0x0
		public int headHead; //Field offset: 0x0
		public ConcurrentQueue<T> <>4__this; //Field offset: 0x0
		private int <headTail>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0
		private Segment<T> <s>5__4; //Field offset: 0x0
		private int <i>5__5; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <Enumerate>d__28(int <>1__state) { }

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[CallerCount(Count = 31)]
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

	[DebuggerDisplay("Capacity = {Capacity}")]
	public sealed class Segment
	{
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		public struct Slot
		{
			public T Item; //Field offset: 0x0
			public int SequenceNumber; //Field offset: 0x0

		}

		internal readonly Slot<T>[] _slots; //Field offset: 0x0
		internal readonly int _slotsMask; //Field offset: 0x0
		internal PaddedHeadAndTail _headAndTail; //Field offset: 0x0
		internal bool _preservedForObservation; //Field offset: 0x0
		internal bool _frozenForEnqueues; //Field offset: 0x0
		internal Segment<T> _nextSegment; //Field offset: 0x0

		internal int Capacity
		{
			[CallerCount(Count = 36)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 26
		}

		internal int FreezeOffset
		{
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
			[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 28
		}

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public Segment(int boundedLength) { }

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void EnsureFrozenForEnqueues() { }

		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int get_Capacity() { }

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int), "System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int get_FreezeOffset() { }

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		public bool TryDequeue(out T item) { }

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public bool TryEnqueue(T item) { }

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Interlocked), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public bool TryPeek(out T result, bool resultUsed) { }

	}

	private object _crossSegmentLock; //Field offset: 0x0
	private Segment<T> _tail; //Field offset: 0x0
	private Segment<T> _head; //Field offset: 0x0

	public override int Count
	{
		[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1<Object>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
		[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<SelectManyIterator>d__17`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<SelectManyIterator>d__19`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<TakeIterator>d__25`1<UInt16>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<TakeIterator>d__25`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<SkipIterator>d__31`1<Object>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<SkipIterator>d__31`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1<Int32>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "Newtonsoft.Json.Linq.Extensions+<Values>d__11`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 3987
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 73
	}

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public ConcurrentQueue`1() { }

	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 26)]
	[DeduplicatedMethod]
	public override void CopyTo(T[] array, int index) { }

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "RunOnUnityScheduler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "EnqueueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Enqueue(T item) { }

	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Segment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private void EnqueueSlow(T item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<Enumerate>d__28))]
	private IEnumerator<T> Enumerate(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "Newtonsoft.Json.Linq.Extensions+<Values>d__11`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1<Int32>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<SkipIterator>d__31`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<SkipIterator>d__31`1<Object>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<TakeIterator>d__25`1", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<SelectManyIterator>d__19`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<SelectManyIterator>d__17`2", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<UnionIterator>d__71`1<Object>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = "System.Linq.Enumerable+<TakeIterator>d__25`1<UInt16>", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 62)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static int GetCount(Segment<T> s, int head, int tail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static long GetCount(Segment<T> head, int headHead, Segment<T> tail, int tailTail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private T GetItemWhenAvailable(Segment<T> segment, int i) { }

	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private void SnapForObservation(out Segment<T> head, out int headHead, out Segment<T> tail, out int tailTail) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "SnapForObservation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Segment<T>&", typeof(Int32&), "Segment<T>&", typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Segment), Member = "get_FreezeOffset", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	public override T[] ToArray() { }

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "TryDequeueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool TryDequeue(out T result) { }

	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private bool TryDequeueSlow(out T item) { }

	[CalledBy(Type = "Utilities.Async.AwaiterExtensions", Member = "DeferredPostCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Segment), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public bool TryPeek(out T result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Segment), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private bool TryPeek(out T result, bool resultUsed) { }

}

