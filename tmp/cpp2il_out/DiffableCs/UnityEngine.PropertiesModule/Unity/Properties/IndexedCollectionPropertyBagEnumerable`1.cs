namespace Unity.Properties;

[IsReadOnly]
internal struct IndexedCollectionPropertyBagEnumerable
{
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	private readonly TContainer m_Container; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IndexedCollectionPropertyBagEnumerable`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator() { }

}

