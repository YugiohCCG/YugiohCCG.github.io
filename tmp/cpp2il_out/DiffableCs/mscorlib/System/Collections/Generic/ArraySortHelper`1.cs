namespace System.Collections.Generic;

internal class ArraySortHelper
{
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper<T> Default
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
	private static ArraySortHelper`1() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ArraySortHelper`1() { }

	[CalledBy(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "InternalBinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static ArraySortHelper<T> get_Default() { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "DownHeap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntrospectiveSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "PickPivotAndPartition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "Heapsort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }

	[CalledBy(Type = typeof(ArraySortHelper`1), Member = "IntroSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	[DeduplicatedMethod]
	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Comparer`1), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }

	[CalledBy(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static void Swap(T[] a, int i, int j) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }

}

