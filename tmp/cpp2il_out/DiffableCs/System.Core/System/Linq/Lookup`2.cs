namespace System.Linq;

[DefaultMember("Item")]
public class Lookup : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__12 : IEnumerator<IGrouping`2<TKey, TElement>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private IGrouping<TKey, TElement> <>2__current; //Field offset: 0x0
		public Lookup<TKey, TElement> <>4__this; //Field offset: 0x0
		private Grouping<TKey, TElement> <g>5__2; //Field offset: 0x0

		private override IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current
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
		public <GetEnumerator>d__12(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }

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

	public class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__7 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x0
			private TElement <>2__current; //Field offset: 0x0
			public Grouping<TKey, TElement> <>4__this; //Field offset: 0x0
			private int <i>5__2; //Field offset: 0x0

			private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[CallerCount(Count = 2)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 41
			}

			[CallerCount(Count = 36)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetEnumerator>d__7(int <>1__state) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private override bool MoveNext() { }

			[CallerCount(Count = 2)]
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

		internal TKey key; //Field offset: 0x0
		internal int hashCode; //Field offset: 0x0
		internal TElement[] elements; //Field offset: 0x0
		internal int count; //Field offset: 0x0
		internal Grouping<TKey, TElement> hashNext; //Field offset: 0x0
		internal Grouping<TKey, TElement> next; //Field offset: 0x0

		public override TKey Key
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		private override int System.Collections.Generic.ICollection<TElement>.Count
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			private get { } //Length: 3
		}

		private override TElement System.Collections.Generic.IList<TElement>.Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			private get { } //Length: 90
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private set { } //Length: 27
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Grouping() { }

		[CalledBy(Type = typeof(Lookup`2), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal void Add(TElement element) { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public override TKey get_Key() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IteratorStateMachine(typeof(<GetEnumerator>d__7))]
		public override IEnumerator<TElement> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TElement>.Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.ICollection<TElement>.get_Count() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "NotSupported", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private IEqualityComparer<TKey> comparer; //Field offset: 0x0
	private Grouping<TKey, TElement>[] groupings; //Field offset: 0x0
	private Grouping<TKey, TElement> lastGrouping; //Field offset: 0x0
	private int count; //Field offset: 0x0

	[CalledBy(Type = typeof(Lookup`2), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	private Lookup`2(IEqualityComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(GroupedEnumerable`3), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IGrouping`2<TKey, TElement>>")]
	[CalledBy(Type = typeof(GroupedEnumerable`3), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Lookup`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Lookup`2), Member = "GetGrouping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", typeof(bool)}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>+Grouping<TKey, TElement>")]
	[Calls(Type = typeof(Grouping), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	internal static Lookup<TKey, TElement> Create(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(GroupedEnumerable`3), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IGrouping`2<TKey, TElement>>")]
	[CalledBy(Type = typeof(GroupedEnumerable`3), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
	public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

	[CalledBy(Type = typeof(Lookup`2), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Linq.Lookup`2<TKey, TElement>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal int InternalGetHashCode(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void Resize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

