namespace UnityEngine.Rendering;

[Extension]
public static class SwapCollectionExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 37)]
	[CollectionAccess(CollectionAccessType::ModifyExistingContent (2))]
	[DeduplicatedMethod]
	[Extension]
	[MustUseReturnValue]
	public static bool TrySwap(IList<TValue> list, int from, int to, out Exception error) { }

}

