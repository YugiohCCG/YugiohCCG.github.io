namespace System.Linq;

internal class EnumerableSorter : EnumerableSorter<TElement>
{
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	internal IComparer<TKey> comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0
	internal EnumerableSorter<TElement> next; //Field offset: 0x0
	internal TKey[] keys; //Field offset: 0x0

	[CalledBy(Type = typeof(OrderedEnumerable`2), Member = "GetEnumerableSorter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.EnumerableSorter`1<TElement>"}, ReturnType = "System.Linq.EnumerableSorter`1<TElement>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal EnumerableSorter`2(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal virtual int CompareKeys(int index1, int index2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal virtual void ComputeKeys(TElement[] elements, int count) { }

}

