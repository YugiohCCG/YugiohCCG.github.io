namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class SortedDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public bool found; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass34_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ContainsValue>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public EqualityComparer<TValue> valueComparer; //Field offset: 0x0
		public <>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass34_1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <ContainsValue>b__1(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; //Field offset: 0x0
		private int _getEnumeratorRetType; //Field offset: 0x0

		public override KeyValuePair<TKey, TValue> Current
		{
			[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 162
		}

		internal bool NotStartedOrEnded
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			internal get { } //Length: 132
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 12)]
			[DeduplicatedMethod]
			private get { } //Length: 370
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 9)]
			[DeduplicatedMethod]
			private get { } //Length: 246
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private get { } //Length: 201
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 20)]
			[DeduplicatedMethod]
			private get { } //Length: 666
		}

		[CalledBy(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(SortedSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Enumerator<T>")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
		[CallerCount(Count = 14)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal bool get_NotStartedOrEnded() { }

		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 20)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public TKey[] array; //Field offset: 0x0
			public int index; //Field offset: 0x0

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass5_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public int index; //Field offset: 0x0
			public Object[] objects; //Field offset: 0x0

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass6_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 6)]
			[DeduplicatedMethod]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			public override TKey Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
				[CallsUnknownMethods(Count = 5)]
				[DeduplicatedMethod]
				 get { } //Length: 206
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 8)]
				[DeduplicatedMethod]
				private get { } //Length: 217
			}

			[CallerCount(Count = 4)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			public override TKey get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 45
		}

		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			private get { } //Length: 3
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
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 73
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public KeyCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		public override void CopyTo(TKey[] array, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 35)]
		[DeduplicatedMethod]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	public sealed class KeyValuePairComparer : Comparer<KeyValuePair`2<TKey, TValue>>
	{
		internal IComparer<TKey> keyComparer; //Field offset: 0x0

		[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Byte>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Byte>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public KeyValuePairComparer(IComparer<TKey> keyComparer) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public TValue[] array; //Field offset: 0x0
			public int index; //Field offset: 0x0

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass5_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass6_0
		{
			public int index; //Field offset: 0x0
			public Object[] objects; //Field offset: 0x0

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass6_0() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 6)]
			[DeduplicatedMethod]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			public override TValue Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
				[CallsUnknownMethods(Count = 5)]
				[DeduplicatedMethod]
				 get { } //Length: 206
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 7)]
				[DeduplicatedMethod]
				private get { } //Length: 170
			}

			[CallerCount(Count = 4)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedDictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			public override TValue get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 7)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 45
		}

		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			private get { } //Length: 3
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
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 73
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ValueCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		[DeduplicatedMethod]
		public override void CopyTo(TValue[] array, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortedDictionary`2), Member = "ContainsValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SortedDictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 35)]
		[DeduplicatedMethod]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	private TreeSet<KeyValuePair`2<TKey, TValue>> _set; //Field offset: 0x0

	public override int Count
	{
		[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ValueCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 49
	}

	public override TValue Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 250
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 308
	}

	public KeyCollection<TKey, TValue> Keys
	{
		[CalledBy(Type = "Scenes.Deck.DeckSelection", Member = "UpdateDeckList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 154
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
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
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 73
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private get { } //Length: 407
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 25)]
		[DeduplicatedMethod]
		private set { } //Length: 901
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 23
	}

	public ValueCollection<TKey, TValue> Values
	{
		[CalledBy(Type = "ClientAPI.WebServer+DeckList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<String, Deck>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager", Member = "RandomDeckForRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Banlist", "Data.GameSettings", "System.String[]"}, ReturnType = "Card.Deck")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 154
	}

	[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(KeyValuePairComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SortedDictionary`2() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyValuePairComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SortedDictionary`2(IComparer<TKey> comparer) { }

	[CalledBy(Type = "Game.ClientField+<>c__DisplayClass22_0+<<Init>g__initCard|0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Add(TKey key, TValue value) { }

	[CalledBy(Type = "Card.Manager+<DeleteAllDecks>d__68", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.Generic.ICollection<TKey>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool ContainsKey(TKey key) { }

	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.Generic.ICollection<TValue>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public bool ContainsValue(TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyCollection), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueCollection), Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override TValue get_Item(TKey key) { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection", Member = "UpdateDeckList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[CalledBy(Type = "ClientAPI.WebServer+DeckList", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<String, Deck>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager", Member = "RandomDeckForRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Banlist", "Data.GameSettings", "System.String[]"}, ReturnType = "Card.Deck")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ValueCollection<TKey, TValue> get_Values() { }

	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToCSV>d__75", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<LoadPlayerData>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<WriteAllFullDecks>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.ClientField+<Init>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsCompatibleKey(object key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Remove(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

