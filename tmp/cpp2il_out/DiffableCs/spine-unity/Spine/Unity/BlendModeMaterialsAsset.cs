namespace Spine.Unity;

[CreateAssetMenu(menuName = "Spine/SkeletonData Modifiers/Blend Mode Materials", order = 200)]
public class BlendModeMaterialsAsset : SkeletonDataModifierAsset
{
	private class AtlasMaterialCache : IDisposable
	{
		private readonly Dictionary<KeyValuePair`2<AtlasPage, Material>, AtlasPage> cache; //Field offset: 0x10

		[CalledBy(Type = typeof(BlendModeMaterialsAsset), Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData), typeof(Material), typeof(Material), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public AtlasMaterialCache() { }

		[CalledBy(Type = typeof(BlendModeMaterialsAsset), Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData), typeof(Material), typeof(Material), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AtlasRegion), Member = "Clone", ReturnType = typeof(AtlasRegion))]
		[Calls(Type = typeof(AtlasMaterialCache), Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasPage), typeof(Material)}, ReturnType = typeof(AtlasPage))]
		[CallsUnknownMethods(Count = 2)]
		public AtlasRegion CloneAtlasRegionWithMaterial(AtlasRegion originalRegion, Material materialTemplate) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public override void Dispose() { }

		[CalledBy(Type = typeof(AtlasMaterialCache), Member = "CloneAtlasRegionWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AtlasPage), Member = "Clone", ReturnType = typeof(AtlasPage))]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private AtlasPage GetAtlasPageWithMaterial(AtlasPage originalPage, Material materialTemplate) { }

	}

	public Material multiplyMaterialTemplate; //Field offset: 0x18
	public Material screenMaterialTemplate; //Field offset: 0x20
	public Material additiveMaterialTemplate; //Field offset: 0x28
	public bool applyAdditiveMaterial; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BlendModeMaterialsAsset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlendModeMaterialsAsset), Member = "ApplyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData), typeof(Material), typeof(Material), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	public virtual void Apply(SkeletonData skeletonData) { }

	[CalledBy(Type = typeof(BlendModeMaterialsAsset), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AtlasMaterialCache), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skin), Member = "GetAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<Spine.Skin+SkinEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasMaterialCache), Member = "CloneAtlasRegionWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public static void ApplyMaterials(SkeletonData skeletonData, Material multiplyTemplate, Material screenTemplate, Material additiveTemplate, bool includeAdditiveSlots) { }

}

