namespace Unity.Properties;

public sealed class ArrayPropertyBag : IndexedCollectionPropertyBag<TElement[], TElement>
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
	public ArrayPropertyBag`1() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual TElement[] Instantiate() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual TElement[] InstantiateWithCount(int count) { }

}

