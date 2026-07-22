namespace Spine.Unity;

public class BlendModeMaterials
{
	internal class ReplacementMaterial
	{
		public string pageName; //Field offset: 0x10
		public Material material; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ReplacementMaterial() { }

	}

	[HideInInspector]
	[SerializeField]
	protected bool requiresBlendModeMaterials; //Field offset: 0x10
	public bool applyAdditiveMaterial; //Field offset: 0x11
	public List<ReplacementMaterial> additiveMaterials; //Field offset: 0x18
	public List<ReplacementMaterial> multiplyMaterials; //Field offset: 0x20
	public List<ReplacementMaterial> screenMaterials; //Field offset: 0x28

	public bool RequiresBlendModeMaterials
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 370
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public BlendModeMaterials() { }

	[CalledBy(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skin), Member = "GetAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<Spine.Skin+SkinEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BlendModeMaterials), Member = "CloneAtlasRegionWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(System.Collections.Generic.List`1<Spine.Unity.BlendModeMaterials+ReplacementMaterial>)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	public void ApplyMaterials(SkeletonData skeletonData) { }

	[CalledBy(Type = typeof(SkeletonGraphic), Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	public BlendMode BlendModeForMaterial(Material material) { }

	[CalledBy(Type = typeof(BlendModeMaterials), Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AtlasRegion), Member = "Clone", ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasPage), Member = "Clone", ReturnType = typeof(AtlasPage))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, List<ReplacementMaterial> replacementMaterials) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_RequiresBlendModeMaterials() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set_RequiresBlendModeMaterials(bool value) { }

}

