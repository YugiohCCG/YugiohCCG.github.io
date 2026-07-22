namespace Unity.Properties;

public class HashSetPropertyBag : SetPropertyBagBase<HashSet`1<TElement>, TElement>
{

	protected virtual InstantiationKind InstantiationKind
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HashSetPropertyBag`1() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual HashSet<TElement> Instantiate() { }

}

