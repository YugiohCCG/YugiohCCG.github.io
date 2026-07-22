namespace Unity.Properties;

internal struct IndexedCollectionPropertyBagEnumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
{
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; //Field offset: 0x0
	private readonly IndexedCollectionSharedPropertyState m_Previous; //Field offset: 0x0
	private TContainer m_Container; //Field offset: 0x0
	private int m_Position; //Field offset: 0x0

	public override IProperty<TContainer> Current
	{
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 88
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private get { } //Length: 123
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal IndexedCollectionPropertyBagEnumerator`1(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override IProperty<TContainer> get_Current() { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public override bool MoveNext() { }

	[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

}

