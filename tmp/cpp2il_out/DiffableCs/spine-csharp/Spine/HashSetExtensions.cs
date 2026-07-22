namespace Spine;

[Extension]
public static class HashSetExtensions
{

	[CalledBy(Type = typeof(AnimationState), Member = "ComputeHold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static bool AddAll(HashSet<T> set, T[] addSet) { }

}

