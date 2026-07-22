namespace System.Collections.Generic;

internal class ArraySortHelper
{
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper<TKey, TValue> Default
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 153
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static ArraySortHelper`2() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ArraySortHelper`2() { }

	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static ArraySortHelper<TKey, TValue> get_Default() { }

	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "DownHeap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "PickPivotAndPartition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`2), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey[]", "TValue[]", typeof(int), typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }

}

