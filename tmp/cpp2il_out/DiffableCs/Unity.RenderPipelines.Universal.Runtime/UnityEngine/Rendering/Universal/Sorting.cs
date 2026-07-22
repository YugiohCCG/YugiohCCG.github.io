namespace UnityEngine.Rendering.Universal;

internal struct Sorting
{
	[CompilerGenerated]
	private struct <>c__DisplayClass4_0
	{
		public T[] data; //Field offset: 0x0

	}

	public static ProfilingSampler s_QuickSortSampler; //Field offset: 0x0
	public static ProfilingSampler s_InsertionSortSampler; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Sorting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal static void <Median3Pivot>g__Swap|4_0(int a, int b, ref <>c__DisplayClass4_0<T>& unnamed_param_2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void InsertionSort(T[] data, Func<T, T, Int32> compare) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void InsertionSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

	[CalledBy(Type = typeof(Sorting), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sorting), Member = "Partition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private static T Median3Pivot(T[] data, int start, int pivot, int end, Func<T, T, Int32> compare) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sorting), Member = "Median3Pivot", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static int Partition(T[] data, int start, int end, Func<T, T, Int32> compare) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static void QuickSort(T[] data, Func<T, T, Int32> compare) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+WorkSlice`1", Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`3<T, T, Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sorting), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Sorting), Member = "Median3Pivot", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = "T")]
	[Calls(Type = typeof(Sorting), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "System.Func`3<T, T, Int32>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static void QuickSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

}

