namespace UnityEngine.Rendering;

[Extension]
internal static class AABBExtensions
{

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+UpdateRendererInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	public static AABB ToAABB(Bounds bounds) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	public static Bounds ToBounds(AABB aabb) { }

}

