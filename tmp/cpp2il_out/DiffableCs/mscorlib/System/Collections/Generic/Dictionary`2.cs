namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
public class Dictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	private struct Entry
	{
		public int hashCode; //Field offset: 0x0
		public int next; //Field offset: 0x0
		public TKey key; //Field offset: 0x0
		public TValue value; //Field offset: 0x0

	}

	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private KeyValuePair<TKey, TValue> _current; //Field offset: 0x0
		private int _getEnumeratorRetType; //Field offset: 0x0

		public override KeyValuePair<TKey, TValue> Current
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 21
		}

		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			private get { } //Length: 207
		}

		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			private get { } //Length: 132
		}

		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 85
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			private get { } //Length: 478
		}

		[CalledBy(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
		[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			private int _index; //Field offset: 0x0
			private int _version; //Field offset: 0x0
			private TKey _currentKey; //Field offset: 0x0

			public override TKey Current
			{
				[CallerCount(Count = 17)]
				[DeduplicatedMethod]
				 get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 2)]
				[DeduplicatedMethod]
				private get { } //Length: 114
			}

			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 17)]
			[DeduplicatedMethod]
			public override TKey get_Current() { }

			[CalledBy(Type = "Effects.EffectsManager", Member = "UnRegisterEffect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectHandler", "UnityEngine.Transform"}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(Claim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Claim), typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.DynamicHeightVirtualizationController`1", Member = "CleanItemHeightCache", ReturnType = typeof(void))]
			[CalledBy(Type = "System.Xml.Schema.SchemaInfo", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.SchemaInfo", "System.Xml.Schema.ValidationEventHandler"}, ReturnType = typeof(void))]
			[CalledBy(Type = "System.Xml.Schema.XdrValidator", Member = "ProcessInlineSchema", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileLambdaExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "ReleasePointerDrags", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.TerrainUtils.TerrainMap", Member = "Validate", ReturnType = "UnityEngine.TerrainUtils.TerrainMapStatusCode")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 42
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

		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public KeyCollection(Dictionary<TKey, TValue> dictionary) { }

		[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void CopyTo(TKey[] array, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
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

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			private int _index; //Field offset: 0x0
			private int _version; //Field offset: 0x0
			private TValue _currentValue; //Field offset: 0x0

			public override TValue Current
			{
				[CallerCount(Count = 106)]
				[DeduplicatedMethod]
				 get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 1)]
				[DeduplicatedMethod]
				private get { } //Length: 55
			}

			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			public override TValue get_Current() { }

			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 42
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

		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ValueCollection(Dictionary<TKey, TValue> dictionary) { }

		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetEvents", ReturnType = "System.ComponentModel.EventDescriptorCollection")]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetProperties", ReturnType = "System.ComponentModel.PropertyDescriptorCollection")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override void CopyTo(TValue[] array, int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int get_Count() { }

		[CallerCount(Count = 39)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
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

	private Int32[] _buckets; //Field offset: 0x0
	private Entry<TKey, TValue>[] _entries; //Field offset: 0x0
	private int _count; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private int _freeCount; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0

	public override int Count
	{
		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public override TValue Item
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 177
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		 set { } //Length: 53
	}

	public KeyCollection<TKey, TValue> Keys
	{
		[CallerCount(Count = 30)]
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
		[CallerCount(Count = 30)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 154
	}

	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[CallerCount(Count = 59)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 154
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[CallerCount(Count = 30)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 154
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[CallerCount(Count = 59)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 154
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 104
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
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		private get { } //Length: 274
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		private set { } //Length: 479
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 169
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 169
	}

	public ValueCollection<TKey, TValue> Values
	{
		[CallerCount(Count = 59)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 154
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Dictionary`2() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Dictionary`2(int capacity) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Dictionary`2(IEqualityComparer<TKey> comparer) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Xml.Serialization.XmlRootAttribute"}, ReturnType = "System.Xml.Serialization.XmlSerializer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Dictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object, System.Runtime.Serialization.SerializationInfo>))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Dictionary`2(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "RegisterLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform", "UnityEngine.Transform", "Scenes.Battle.LineArc"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ClearFromLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.LineArc", Member = "ClearToLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Transform"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Xml.Serialization.XmlRootAttribute"}, ReturnType = "System.Xml.Serialization.XmlSerializer")]
	[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", "UnityEngine.Material"}, ReturnType = "Spine.AtlasPage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override void Add(TKey key, TValue value) { }

	[CallerCount(Count = 171)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public override bool ContainsKey(TKey key) { }

	[CalledBy(Type = typeof(ValueCollection), Member = "System.Collections.Generic.ICollection<TValue>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool ContainsValue(TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int EnsureCapacity(int capacity) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private int FindEntry(TKey key) { }

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override TValue get_Item(TKey key) { }

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ValueCollection<TKey, TValue> get_Values() { }

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashHelpers), Member = "GetPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private int Initialize(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsCompatibleKey(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Object, System.Runtime.Serialization.SerializationInfo>))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowSerializationException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override void OnDeserialization(object sender) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Remove(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(TKey key, out TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void Resize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void Resize(int newSize, bool forceNewHashCodes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyValuePair`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongKeyTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public bool TryAdd(TKey key, TValue value) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.IDictionary.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(HashHelpers), Member = "ExpandPrime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_ConcurrentOperationsNotSupported", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowAddingDuplicateWithKeyArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }

}

