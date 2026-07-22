namespace Spine.Unity;

[CreateAssetMenu(fileName = "New SkeletonDataAsset", menuName = "Spine/SkeletonData Asset")]
public class SkeletonDataAsset : ScriptableObject
{
	public AtlasAssetBase[] atlasAssets; //Field offset: 0x18
	public float scale; //Field offset: 0x20
	public TextAsset skeletonJSON; //Field offset: 0x28
	public bool isUpgradingBlendModeMaterials; //Field offset: 0x30
	public BlendModeMaterials blendModeMaterials; //Field offset: 0x38
	[Tooltip("Use SkeletonDataModifierAssets to apply changes to the SkeletonData after being loaded, such as apply blend mode Materials to Attachments under slots with special blend modes.")]
	public List<SkeletonDataModifierAsset> skeletonDataModifiers; //Field offset: 0x40
	[SpineAnimation(null, null, False, False)]
	public String[] fromAnimation; //Field offset: 0x48
	[SpineAnimation(null, null, False, False)]
	public String[] toAnimation; //Field offset: 0x50
	public Single[] duration; //Field offset: 0x58
	public float defaultMix; //Field offset: 0x60
	public RuntimeAnimatorController controller; //Field offset: 0x68
	private SkeletonData skeletonData; //Field offset: 0x70
	private AnimationStateData stateData; //Field offset: 0x78

	public bool IsLoaded
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public SkeletonDataAsset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = "Game.CardAnimationPlayer+<BuildSkeleton>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CallsUnknownMethods(Count = 10)]
	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase atlasAsset, bool initialize, float scale = 0.01) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CallsUnknownMethods(Count = 5)]
	public static SkeletonDataAsset CreateRuntimeInstance(TextAsset skeletonDataFile, AtlasAssetBase[] atlasAssets, bool initialize, float scale = 0.01) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationStateData), Member = "SetMix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void FillStateData() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsLoaded() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	public AnimationStateData GetAnimationStateData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal Atlas[] GetAtlasArray() { }

	[CalledBy(Type = typeof(AnimationReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpineBone), Member = "GetBoneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonDataAsset)}, ReturnType = typeof(BoneData))]
	[CalledBy(Type = typeof(SkeletonRenderer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MecanimTranslator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animator), typeof(SkeletonDataAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonGraphic), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonAnimation), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpineAttachment), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonDataAsset)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonDataAsset), Member = "GetAnimationStateData", ReturnType = typeof(AnimationStateData))]
	[CalledBy(Type = typeof(SkeletonDataAsset), Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(AtlasAssetBase[]), typeof(bool), typeof(float)}, ReturnType = typeof(SkeletonDataAsset))]
	[CalledBy(Type = typeof(SkeletonDataAsset), Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(AtlasAssetBase), typeof(bool), typeof(float)}, ReturnType = typeof(SkeletonDataAsset))]
	[CalledBy(Type = typeof(EventDataReferenceAsset), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonAnimation), Member = "set_AnimationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AnimationStateData), Member = "SetMix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationStateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BlendModeMaterials), Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(SkeletonLoader), Member = "set_Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(AtlasAttachmentLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextAsset), Member = "get_bytes", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 23)]
	public SkeletonData GetSkeletonData(bool quiet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationStateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationStateData), Member = "SetMix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void InitializeWithData(SkeletonData sd) { }

	[CalledBy(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonLoader), Member = "set_Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static SkeletonData ReadSkeletonData(Byte[] bytes, AttachmentLoader attachmentLoader, float scale) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonLoader), Member = "set_Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static SkeletonData ReadSkeletonData(string text, AttachmentLoader attachmentLoader, float scale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void Reset() { }

}

