namespace Unity.Properties;

public class KeyValueCollectionPropertyBag : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair`2<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, Object>
{
	[IsReadOnly]
	private struct Enumerable : IEnumerable<IProperty`1<TDictionary>>, IEnumerable
	{
		private class Enumerator : IEnumerator<IProperty`1<TDictionary>>, IEnumerator, IDisposable
		{
			private readonly TDictionary m_Dictionary; //Field offset: 0x0
			private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0
			private readonly TKey m_Previous; //Field offset: 0x0
			private readonly List<TKey> m_Keys; //Field offset: 0x0
			private int m_Position; //Field offset: 0x0

			public override IProperty<TDictionary> Current
			{
				[CallerCount(Count = 0)]
				[CallsUnknownMethods(Count = 1)]
				[DeduplicatedMethod]
				 get { } //Length: 43
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				private get { } //Length: 21
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 19)]
			[DeduplicatedMethod]
			public Enumerator(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override IProperty<TDictionary> get_Current() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 21)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 7)]
			[DeduplicatedMethod]
			public override void Reset() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		private readonly TDictionary m_Dictionary; //Field offset: 0x0
		private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_Property; //Field offset: 0x0

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		public Enumerable(TDictionary dictionary, KeyValuePairProperty<TDictionary, TKey, TValue> property) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private override IEnumerator<IProperty`1<TDictionary>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private class KeyValuePairProperty : Property<TDictionary, KeyValuePair`2<TKey, TValue>>, IDictionaryElementProperty
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private TKey <Key>k__BackingField; //Field offset: 0x0

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public internal override TKey Key
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 147
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal set { } //Length: 182
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			[DeduplicatedMethod]
			 get { } //Length: 355
		}

		public override object ObjectKey
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 159
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public KeyValuePairProperty() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public override TKey get_Key() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object get_ObjectKey() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 18)]
		[DeduplicatedMethod]
		public virtual KeyValuePair<TKey, TValue> GetValue(ref TDictionary container) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal void set_Key(TKey value) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref TDictionary container, KeyValuePair<TKey, TValue> value) { }

	}

	private readonly KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public KeyValueCollectionPropertyBag`3() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TDictionary> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TDictionary> GetProperties(ref TDictionary container) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private override bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary>& property) { }

}

