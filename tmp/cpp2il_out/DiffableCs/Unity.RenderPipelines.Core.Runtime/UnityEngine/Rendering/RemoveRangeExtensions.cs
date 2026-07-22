namespace UnityEngine.Rendering;

[Extension]
public static class RemoveRangeExtensions
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CollectionAccess(CollectionAccessType::ModifyExistingContent (2))]
	[DeduplicatedMethod]
	[Extension]
	[MustUseReturnValue]
	public static bool TryRemoveElementsInRange(IList<TValue> list, int index, int count, out Exception error) { }

}

