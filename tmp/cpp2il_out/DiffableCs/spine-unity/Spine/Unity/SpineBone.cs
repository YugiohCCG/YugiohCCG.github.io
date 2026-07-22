namespace Spine.Unity;

public class SpineBone : SpineAttributeBase
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public SpineBone(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[CallsUnknownMethods(Count = 1)]
	public static Bone GetBone(string boneName, SkeletonRenderer renderer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BoneData))]
	[CallsUnknownMethods(Count = 1)]
	public static BoneData GetBoneData(string boneName, SkeletonDataAsset skeletonDataAsset) { }

}

