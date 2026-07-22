namespace UnityEngine.Rendering;

[Extension]
public static class ListBufferExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void QuickSort(ListBuffer<T> self) { }

}

