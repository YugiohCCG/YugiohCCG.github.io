namespace Unity.Properties;

public class IndexedCollectionPropertyBag : PropertyBag<TList>, IListPropertyBag<TList, TElement>, ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>, IConstructorWithCount<TList>, IConstructor, IIndexedCollectionPropertyBagEnumerator<TList>
{
	private class ListElementProperty : Property<TList, TElement>, IListElementProperty
	{
		internal int m_Index; //Field offset: 0x0
		internal bool m_IsReadOnly; //Field offset: 0x0

		public override int Index
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[DeduplicatedMethod]
			 get { } //Length: 33
		}

		[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "TryGetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList&", typeof(int), "Unity.Properties.IProperty`1<TList>&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ListElementProperty() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public override int get_Index() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual TElement GetValue(ref TList container) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref TList container, TElement value) { }

	}

	private readonly ListElementProperty<TList, TElement> m_Property; //Field offset: 0x0

	[CalledBy(Type = typeof(ListPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListElementProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public IndexedCollectionPropertyBag`2() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TList> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IndexedCollectionPropertyBagEnumerable`1<TContainer>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TList> GetProperties(ref TList container) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override TList InstantiateWithCount(int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListElementProperty), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override bool TryGetProperty(ref TList container, int index, out IProperty<TList>& property) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container) { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	private override IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributesScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IProperty), typeof(IProperty)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributesScope), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IListPropertyAccept<TList>.Accept(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list) { }

}

