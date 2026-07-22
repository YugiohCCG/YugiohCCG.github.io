namespace System.Linq;

internal abstract class EnumerableSorter
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected EnumerableSorter`1() { }

	internal abstract int CompareKeys(int index1, int index2) { }

	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	[CalledBy(Type = typeof(EnumerableSorter`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TElement[]", typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void QuickSort(Int32[] map, int left, int right) { }

	[CalledBy(Type = "System.Linq.OrderedEnumerable`1+<GetEnumerator>d__1", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnumerableSorter`1), Member = "QuickSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal Int32[] Sort(TElement[] elements, int count) { }

}

