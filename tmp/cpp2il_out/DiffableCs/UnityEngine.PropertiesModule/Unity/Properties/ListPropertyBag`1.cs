namespace Unity.Properties;

public class ListPropertyBag : IndexedCollectionPropertyBag<List`1<TElement>, TElement>
{

	protected virtual InstantiationKind InstantiationKind
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyBag), Member = "RegisterList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TElement"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public ListPropertyBag`1() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual List<TElement> Instantiate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual List<TElement> InstantiateWithCount(int count) { }

}

