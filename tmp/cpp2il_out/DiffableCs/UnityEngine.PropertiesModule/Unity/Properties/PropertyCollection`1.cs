namespace Unity.Properties;

[IsReadOnly]
public struct PropertyCollection : IEnumerable<IProperty`1<TContainer>>, IEnumerable
{
	internal struct Enumerator : IEnumerator<IProperty`1<TContainer>>, IEnumerator, IDisposable
	{
		private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
		private IEnumerator<IProperty`1<TContainer>> m_Enumerator; //Field offset: 0x0
		private Enumerator<IProperty<TContainer>> m_Properties; //Field offset: 0x0
		private IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private IProperty<TContainer> <Current>k__BackingField; //Field offset: 0x0

		public private override IProperty<TContainer> Current
		{
			[CallerCount(Count = 10)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 254
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 37
		}

		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal Enumerator(IEnumerator<IProperty`1<TContainer>> enumerator) { }

		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal Enumerator(Enumerator<IProperty<TContainer>> properties) { }

		[CalledBy(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal Enumerator(IndexedCollectionPropertyBagEnumerator<TContainer> enumerator) { }

		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override IProperty<TContainer> get_Current() { }

		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "get_Current", ReturnType = "Unity.Properties.IProperty`1<TContainer>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 13)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerator`1), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Current(IProperty<TContainer> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private enum EnumeratorType
	{
		Empty = 0,
		Enumerable = 1,
		List = 2,
		IndexedCollectionPropertyBag = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly PropertyCollection<TContainer> <Empty>k__BackingField; //Field offset: 0x0
	private readonly EnumeratorType<TContainer> m_Type; //Field offset: 0x0
	private readonly IEnumerable<IProperty`1<TContainer>> m_Enumerable; //Field offset: 0x0
	private readonly List<IProperty`1<TContainer>> m_Properties; //Field offset: 0x0
	private readonly IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag; //Field offset: 0x0

	public static PropertyCollection<TContainer> Empty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 176
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static PropertyCollection`1() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public PropertyCollection`1(IEnumerable<IProperty`1<TContainer>> enumerable) { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<InlineStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.InlineStyleAccess&"}, ReturnType = "Unity.Properties.PropertyCollection`1<InlineStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<ResolvedStyleAccess>")]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ResolvedStyleAccess&"}, ReturnType = "Unity.Properties.PropertyCollection`1<ResolvedStyleAccess>")]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = "GetProperties", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>")]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&"}, ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public PropertyCollection`1(List<IProperty`1<TContainer>> properties) { }

	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList&"}, ReturnType = "Unity.Properties.PropertyCollection`1<TList>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal PropertyCollection`1(IndexedCollectionPropertyBagEnumerable<TContainer> enumerable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public static PropertyCollection<TContainer> get_Empty() { }

	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.TypePathVisitor", Member = "Unity.Properties.ITypeVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyCollection`1), Member = "System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IProperty`1<TContainer>>")]
	[CalledBy(Type = typeof(PropertyCollection`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(IndexedCollectionPropertyBagEnumerable`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.IndexedCollectionPropertyBagEnumerator`1<TContainer>")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IndexedCollectionPropertyBagEnumerator`1<TContainer>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>+Enumerator<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerator`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public Enumerator<TContainer> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override IEnumerator<IProperty`1<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = "GetEnumerator", ReturnType = "Unity.Properties.PropertyCollection`1<TContainer>+Enumerator<TContainer>")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

