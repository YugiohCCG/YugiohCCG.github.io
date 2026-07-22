namespace UnityEngine.Rendering;

[Extension]
public static class DynamicArrayExtensions
{

	[CalledBy(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DynamicArray`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private static int Partition(Span<T> data, int left, int right) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static int Partition(Span<T> data, int left, int right, SortComparer<T> comparer) { }

	[CalledBy(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "Partition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static void QuickSort(Span<T> data, int left, int right) { }

	[CalledBy(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int), "UnityEngine.Rendering.DynamicArray`1<T>+SortComparer<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DynamicArray`1<T>", "UnityEngine.Rendering.DynamicArray`1<T>+SortComparer<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int), "UnityEngine.Rendering.DynamicArray`1<T>+SortComparer<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static void QuickSort(Span<T> data, int left, int right, SortComparer<T> comparer) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DynamicArray`1<System.Object>)}, ReturnType = typeof(System.Span`1<System.Object>))]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "Partition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Extension]
	public static void QuickSort(DynamicArray<T> array) { }

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>", typeof(int), typeof(int), "UnityEngine.Rendering.DynamicArray`1<T>+SortComparer<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static void QuickSort(DynamicArray<T> array, SortComparer<T> comparer) { }

}

