namespace Unity.Properties;

public class DictionaryPropertyBag : KeyValueCollectionPropertyBag<Dictionary`2<TKey, TValue>, TKey, TValue>
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
	public DictionaryPropertyBag`2() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual Dictionary<TKey, TValue> Instantiate() { }

}

