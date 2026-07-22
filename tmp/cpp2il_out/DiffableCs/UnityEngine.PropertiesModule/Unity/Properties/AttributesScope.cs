namespace Unity.Properties;

[IsReadOnly]
public struct AttributesScope : IDisposable
{
	private readonly IAttributes m_Target; //Field offset: 0x0
	private readonly List<Attribute> m_Previous; //Field offset: 0x8

	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "Unity.Properties.IListPropertyAccept<TList>.Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListPropertyVisitor), "Unity.Properties.Property`2<TContainer, TList>", "TContainer&", "TList&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public AttributesScope(IProperty target, IProperty source) { }

	[CalledBy(Type = typeof(Property`2), Member = "Unity.Properties.Internal.IAttributes.CreateAttributesScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttributes)}, ReturnType = typeof(AttributesScope))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal AttributesScope(IAttributes target, List<Attribute> attributes) { }

	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = "Unity.Properties.IListPropertyAccept<TList>.Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListPropertyVisitor), "Unity.Properties.Property`2<TContainer, TList>", "TContainer&", "TList&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathVisitor), Member = "Unity.Properties.IPropertyBagVisitor.Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", "TContainer&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

}

