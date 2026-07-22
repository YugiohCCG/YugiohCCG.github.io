namespace System.Linq;

[Extension]
public static class Enumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Func<TSource, Boolean> predicate1; //Field offset: 0x0
		public Func<TSource, Boolean> predicate2; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass6_0`1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <CombinePredicates>b__0(TSource x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Func<TMiddle, TResult> selector2; //Field offset: 0x0
		public Func<TSource, TMiddle> selector1; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass7_0`3() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal TResult <CombineSelectors>b__0(TSource x) { }

	}

	[CompilerGenerated]
	private sealed class <CastIterator>d__99 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 43
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <CastIterator>d__99`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ConcatIterator>d__59 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> first; //Field offset: 0x0
		public IEnumerable<TSource> <>3__first; //Field offset: 0x0
		private IEnumerable<TSource> second; //Field offset: 0x0
		public IEnumerable<TSource> <>3__second; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ConcatIterator>d__59`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 24)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <DistinctIterator>d__68 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Set<TSource> <set>5__2; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <DistinctIterator>d__68`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Linq.Set`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Linq.Set`1<System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <IntersectIterator>d__74 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		private IEnumerable<TSource> second; //Field offset: 0x0
		public IEnumerable<TSource> <>3__second; //Field offset: 0x0
		private IEnumerable<TSource> first; //Field offset: 0x0
		public IEnumerable<TSource> <>3__first; //Field offset: 0x0
		private Set<TSource> <set>5__2; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <IntersectIterator>d__74`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Linq.Set`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Int32>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Linq.Set`1<System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Linq.Set`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 28)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OfTypeIterator>d__97 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable source; //Field offset: 0x0
		public IEnumerable <>3__source; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <OfTypeIterator>d__97`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 20)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass9_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <RangeIterator>d__115 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private int start; //Field offset: 0x1C
		public int <>3__start; //Field offset: 0x20
		private int count; //Field offset: 0x24
		public int <>3__count; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x2C

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(TryCatchFinallyHandler), Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 6)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 1078
		}

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <RangeIterator>d__115(int <>1__state) { }

		[CallerCount(Count = 0)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TryCatchFinallyHandler), Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ReverseIterator>d__79 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Buffer<TSource> <buffer>5__2; //Field offset: 0x0
		private int <i>5__3; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <ReverseIterator>d__79`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Linq.Buffer`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	[CompilerGenerated]
	private sealed class <SelectManyIterator>d__17 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Func<TSource, IEnumerable`1<TResult>> selector; //Field offset: 0x0
		public Func<TSource, IEnumerable`1<TResult>> <>3__selector; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0
		private IEnumerator<TResult> <>7__wrap2; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <SelectManyIterator>d__17`2(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 26)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <SelectManyIterator>d__19 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TResult <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private Func<TSource, Int32, IEnumerable`1<TResult>> selector; //Field offset: 0x0
		public Func<TSource, Int32, IEnumerable`1<TResult>> <>3__selector; //Field offset: 0x0
		private int <index>5__2; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0
		private IEnumerator<TResult> <>7__wrap3; //Field offset: 0x0

		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
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

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <SelectManyIterator>d__19`2(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 28)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <SkipIterator>d__31 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private IEnumerator<TSource> <e>5__2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 43
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <SkipIterator>d__31`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <TakeIterator>d__25 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private int count; //Field offset: 0x0
		public int <>3__count; //Field offset: 0x0
		private IEnumerable<TSource> source; //Field offset: 0x0
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <TakeIterator>d__25`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 14)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <UnionIterator>d__71 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x0
		private TSource <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		private IEnumerable<TSource> first; //Field offset: 0x0
		public IEnumerable<TSource> <>3__first; //Field offset: 0x0
		private IEnumerable<TSource> second; //Field offset: 0x0
		public IEnumerable<TSource> <>3__second; //Field offset: 0x0
		private Set<TSource> <set>5__2; //Field offset: 0x0
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
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

		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <UnionIterator>d__71`1(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Set`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TElement>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Set`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 28)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

		[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private abstract class Iterator : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private int threadId; //Field offset: 0x0
		internal int state; //Field offset: 0x0
		internal TSource current; //Field offset: 0x0

		public override TSource Current
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 19
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			private get { } //Length: 52
		}

		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectListIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectListIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectArrayIterator`2", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource[]", "System.Func`2<TSource, Boolean>", "System.Func`2<TSource, TResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TResult>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereArrayIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource[]", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Clone", ReturnType = "System.Linq.Enumerable+Iterator`1<TSource>")]
		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereListIterator`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Iterator`1() { }

		public abstract Iterator<TSource> Clone() { }

		[CalledBy(Type = "System.Linq.Enumerable+WhereEnumerableIterator`1", Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2", Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override TSource get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IEnumerator<TSource> GetEnumerator() { }

		public abstract bool MoveNext() { }

		public abstract IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		public abstract IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	private class WhereArrayIterator : Iterator<TSource>
	{
		private TSource[] source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private int index; //Field offset: 0x0

		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public WhereArrayIterator`1(TSource[] source, Func<TSource, Boolean> predicate) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual Iterator<TSource> Clone() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	private class WhereEnumerableIterator : Iterator<TSource>
	{
		private IEnumerable<TSource> source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public WhereEnumerableIterator`1(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual Iterator<TSource> Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = "Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	private class WhereListIterator : Iterator<TSource>
	{
		private List<TSource> source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[CallerCount(Count = 3)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public WhereListIterator`1(List<TSource> source, Func<TSource, Boolean> predicate) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual Iterator<TSource> Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombinePredicates", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Func`2<TSource, Boolean>")]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	private class WhereSelectArrayIterator : Iterator<TResult>
	{
		private TSource[] source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private int index; //Field offset: 0x0

		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public WhereSelectArrayIterator`2(TSource[] source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public virtual Iterator<TResult> Clone() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	private class WhereSelectEnumerableIterator : Iterator<TResult>
	{
		private IEnumerable<TSource> source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public WhereSelectEnumerableIterator`2(IEnumerable<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public virtual Iterator<TResult> Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = "Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	private class WhereSelectListIterator : Iterator<TResult>
	{
		private List<TSource> source; //Field offset: 0x0
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		private Func<TSource, TResult> selector; //Field offset: 0x0
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[CallerCount(Count = 9)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public WhereSelectListIterator`2(List<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.Linq.Enumerable+Iterator`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public virtual Iterator<TResult> Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "CombineSelectors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TMiddle", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, TMiddle>", "System.Func`2<TMiddle, TResult>"}, ReturnType = "System.Func`2<TSource, TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}


	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InternedString", typeof(object), typeof(bool)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static bool All(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CallerCount(Count = 120)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Any(IEnumerable<TSource> source) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Any(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "Mono.Nat.NatUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "GetAllCardTypes", ReturnType = "System.Collections.Generic.List`1<CardType>")]
	[CalledBy(Type = "Card.ClientCard", Member = "GetAllRaces", ReturnType = "System.Collections.Generic.List`1<CardRace>")]
	[CalledBy(Type = "Card.ClientCard", Member = "GetAllAttributes", ReturnType = "System.Collections.Generic.List`1<CardAttribute>")]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayStats`1", Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = "UnityEngine.Rendering.ObservableList`1<Widget>")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetLastEnumValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DictionaryWrapper`2", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TResult> Cast(IEnumerable source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<CastIterator>d__99`1))]
	private static IEnumerable<TResult> CastIterator(IEnumerable source) { }

	[CalledBy(Type = typeof(WhereEnumerableIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(WhereArrayIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CalledBy(Type = typeof(WhereListIterator`1), Member = "Where", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static Func<TSource, Boolean> CombinePredicates(Func<TSource, Boolean> predicate1, Func<TSource, Boolean> predicate2) { }

	[CalledBy(Type = typeof(WhereSelectEnumerableIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CalledBy(Type = typeof(WhereSelectArrayIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CalledBy(Type = typeof(WhereSelectListIterator`2), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TResult, TResult2>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult2>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static Func<TSource, TResult> CombineSelectors(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.OrcustExecutor", Member = "KnightmarePhoenixSummon", ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor", Member = "OnNewTurn", ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor", Member = "PotOfProsperity", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Card", Member = "IsSupportFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Deck", Member = "get_AllCards", ReturnType = "System.Collections.Generic.IEnumerable`1<Int32>")]
	[CalledBy(Type = "Card.Deck", Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Banlist", typeof(byte), typeof(DateTime), typeof(DateTime), "Enumerator.DuelRules", "Enumerator.ExtraRules", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Concat(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<ConcatIterator>d__59`1))]
	private static IEnumerable<TSource> ConcatIterator(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[CalledBy(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Contains(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	[CalledBy(Type = "Game.DuelManager", Member = "IsSameTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.Local.LocalGame", Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = "Game.Local.LocalGame", Member = "<get_HostEnemy>b__91_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalPlayer"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.Player", Member = "RedefineData", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.RoomData", Member = "GetTeamOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource", "System.Collections.Generic.IEqualityComparer`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Contains(IEnumerable<TSource> source, TSource value) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[Extension]
	public static int Count(IEnumerable<TSource> source) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[Extension]
	public static int Count(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "set_enumValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Distinct(IEnumerable<TSource> source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<DistinctIterator>d__68`1))]
	private static IEnumerable<TSource> DistinctIterator(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "OnSelectOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DeckTrunk", Member = "UpdateMarkOrders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectsManager", Member = "DefineFinite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectsManager", Member = "EndEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.DecksManager", Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DuelBot.Game.GameAI", "DuelBot.Game.BotDuel"}, ReturnType = "DuelBot.Game.AI.Executor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource ElementAt(IEnumerable<TSource> source, int index) { }

	[CalledBy(Type = "Manager.Updater", Member = "get_DefUpdt", ReturnType = typeof(string))]
	[CalledBy(Type = "Data.Tips", Member = "GetRandomTip", ReturnType = typeof(string))]
	[CalledBy(Type = "Game.DuelManager", Member = "UpdateWaiting", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleHand>d__116", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDraw>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainNegated>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "GetUpdateURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Manager.Updater+UpdateType"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_AnmAt", ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.Tips", Member = "GetTip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_BdlRepo", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_ExtTag", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_AnmTagRepo", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_AnmGit", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater", Member = "get_DUGit", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Updater+<GatherDownloadLinks>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.BanlistManager", Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = "Data.Banlist")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SelectedFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Updater", Member = "get_DatasTag", ReturnType = typeof(string))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource ElementAtOrDefault(IEnumerable<TSource> source, int index) { }

	[CallerCount(Count = 97)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static IEnumerable<TResult> Empty() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource First(IEnumerable<TSource> source) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.SalamangreatExecutor", Member = "SelectSetPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoMatch", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource First(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource FirstOrDefault(IEnumerable<TSource> source) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource FirstOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "Scenes.Battle.DuelLogging.LogManager", Member = "OnCardDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool), "System.UInt32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck", Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Banlist", typeof(byte), typeof(DateTime), typeof(DateTime), "Enumerator.DuelRules", "Enumerator.ExtraRules", typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IdentityFunction`1), Member = "get_Instance", ReturnType = "System.Func`2<TElement, TElement>")]
	[Calls(Type = typeof(GroupedEnumerable`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<IGrouping`2<TKey, TSource>> GroupBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.SalamangreatExecutor", Member = "JackJaguar_activate", ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.SalamangreatExecutor", Member = "OnNewTurn", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Intersect(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<IntersectIterator>d__74`1))]
	private static IEnumerable<TSource> IntersectIterator(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource Last(IEnumerable<TSource> source) { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource LastOrDefault(IEnumerable<TSource> source) { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Newtonsoft.Json.Serialization.JsonObjectContract")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetExtensionDataMemberForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MemberInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource LastOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "DuelBot.Game.AI.AIUtil", Member = "GetBestPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DuelBot.Game.BotClientField", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Int32>>)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Nullable<Int32> Max(IEnumerable<TSource> source, Func<TSource, Nullable`1<Int32>> selector) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "get_maxIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyboardNavigationOperation", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static int Max(IEnumerable<Int32> source) { }

	[CalledBy(Type = typeof(Enumerable), Member = "Max", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Nullable`1<Int32>>"}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Nullable<Int32> Max(IEnumerable<Nullable`1<Int32>> source) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "TogglePersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget", "System.Nullable`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int Max(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView+Selection", Member = "get_minIndex", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.KeyboardNavigationOperation", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "DoRangeSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static int Min(IEnumerable<Int32> source) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "Children", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Newtonsoft.Json.Linq.JEnumerable`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TResult> OfType(IEnumerable source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<OfTypeIterator>d__97`1))]
	private static IEnumerable<TResult> OfTypeIterator(IEnumerable source) { }

	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaNode", Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<JsonSchema>"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[CalledBy(Type = "Card.Deck", Member = "GenerateDeckNameFromSetcodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedEnumerable`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TElement>", "System.Func`2<TElement, TKey>", "System.Collections.Generic.IComparer`1<TKey>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static IOrderedEnumerable<TSource> OrderByDescending(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseListViewController", Member = "ClearItems", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField", Member = "get_indexes", ReturnType = "System.Int32[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static IEnumerable<Int32> Range(int start, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<RangeIterator>d__115))]
	private static IEnumerable<Int32> RangeIterator(int start, int count) { }

	[CalledBy(Type = "Game.DuelManager+<OnDraw>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "GetVolumes", ReturnType = "UnityEngine.Rendering.Volume[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Reverse(IEnumerable<TSource> source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<ReverseIterator>d__79`1))]
	private static IEnumerable<TSource> ReverseIterator(IEnumerable<TSource> source) { }

	[CallerCount(Count = 91)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TResult> Select(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TResult> SelectMany(IEnumerable<TSource> source, Func<TSource, Int32, IEnumerable`1<TResult>> selector) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TResult> SelectMany(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<SelectManyIterator>d__17`2))]
	private static IEnumerable<TResult> SelectManyIterator(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<SelectManyIterator>d__19`2))]
	private static IEnumerable<TResult> SelectManyIterator(IEnumerable<TSource> source, Func<TSource, Int32, IEnumerable`1<TResult>> selector) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Byte>))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 44)]
	[DeduplicatedMethod]
	[Extension]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[CalledBy(Type = "Mono.Btls.MonoBtlsContext", Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.X509CertificateImplBtls"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), "System.String[]"}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoElements", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MoreThanOneElement", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource Single(IEnumerable<TSource> source) { }

	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaBuilder", Member = "MapType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaType"}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NoMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MoreThanOneMatch", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource Single(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaResolver", Member = "GetSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Newtonsoft.Json.Schema.JsonSchema")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.DiscriminatedUnionConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MoreThanOneMatch", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource SingleOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "InitializeValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<Type, NamingStrategy>"}, ReturnType = "Newtonsoft.Json.Utilities.EnumInfo")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetMemberInfoFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberInfo)}, ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ForgivingCaseSensitiveFind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, String>", typeof(string)}, ReturnType = "TSource")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MoreThanOneElement", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource SingleOrDefault(IEnumerable<TSource> source) { }

	[CalledBy(Type = "Scenes.General.MultiPick+<Start>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Skip(IEnumerable<TSource> source, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<SkipIterator>d__31`1))]
	private static IEnumerable<TSource> SkipIterator(IEnumerable<TSource> source, int count) { }

	[CalledBy(Type = "UI.Tables.TableLayout+<>c", Member = "<UpdateLayout>b__25_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Tables.TableRow"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.Level8Executor", Member = "PSYFramelordOmegaEffect", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Deck", Member = "get_DeckPrice", ReturnType = typeof(float))]
	[CalledBy(Type = "Card.Deck", Member = "get_MainDeckPrice", ReturnType = typeof(float))]
	[CalledBy(Type = "Card.Deck", Member = "get_ExtraDeckPrice", ReturnType = typeof(float))]
	[CalledBy(Type = "Card.Deck", Member = "get_SideDeckPrice", ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int Sum(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[CalledBy(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static int Sum(IEnumerable<Int32> source) { }

	[CalledBy(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Nullable`1<Int32>>"}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static Nullable<Int32> Sum(IEnumerable<Nullable`1<Int32>> source) { }

	[CalledBy(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Single>"}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static float Sum(IEnumerable<Single> source) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Single>)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static float Sum(IEnumerable<TSource> source, Func<TSource, Single> selector) { }

	[CalledBy(Type = "DuelBot.Game.AI.AIUtil", Member = "GetTotalAttackingMonsterAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "DuelBot.Game.AI.DefaultExecutor", Member = "DefaultEvilswarmExcitonKnightEffect", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Nullable`1<System.Int32>>)}, ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Nullable<Int32> Sum(IEnumerable<TSource> source, Func<TSource, Nullable`1<Int32>> selector) { }

	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "OnFilterChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.GeneralSelection", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnDraw>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.BlueEyesExecutor", Member = "OnSelectCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<BotClientCard>", typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = "System.Collections.Generic.IList`1<BotClientCard>")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Take(IEnumerable<TSource> source, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<TakeIterator>d__25`1))]
	private static IEnumerable<TSource> TakeIterator(IEnumerable<TSource> source, int count) { }

	[CalledBy(Type = "Card.Deck", Member = "SortCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable", Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.KerningTable", Member = "SortKerningPairs", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable", Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByCardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByAvgPrice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByReleaseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByDefense", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "CardListSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<ClientCard>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<ClientCard>")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static IOrderedEnumerable<TSource> ThenBy(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "CardListSorting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<ClientCard>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<ClientCard>")]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "SortingByCardType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Card>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<Card>")]
	[CalledBy(Type = "Card.Deck", Member = "SortCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static IOrderedEnumerable<TSource> ThenByDescending(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.SelectPositionData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IList`1<CardPosition>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.AnnounceAttributeData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IList`1<CardAttribute>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Linq.Buffer`1<System.Byte>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer`1), Member = "ToArray", ReturnType = "TElement[]")]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static TSource[] ToArray(IEnumerable<TSource> source) { }

	[CalledBy(Type = "Card.CardLocalization", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card", typeof(string), typeof(string), "System.String[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }

	[CalledBy(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	[Extension]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Int32>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Int32>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static List<TSource> ToList(IEnumerable<TSource> source) { }

	[CalledBy(Type = "Card.Deck", Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Rarity"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Union(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<UnionIterator>d__71`1))]
	private static IEnumerable<TSource> UnionIterator(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Error), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<TSource> Where(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

}

