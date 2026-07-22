namespace Spine;

public class AtlasPage
{
	public string name; //Field offset: 0x10
	public int width; //Field offset: 0x18
	public int height; //Field offset: 0x1C
	public Format format; //Field offset: 0x20
	public TextureFilter minFilter; //Field offset: 0x24
	public TextureFilter magFilter; //Field offset: 0x28
	public TextureWrap uWrap; //Field offset: 0x2C
	public TextureWrap vWrap; //Field offset: 0x30
	public bool pma; //Field offset: 0x34
	public object rendererObject; //Field offset: 0x38

	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "get_EmptyRegion", ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.U2D.SpriteAtlas"}, ReturnType = typeof(Atlas))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material"}, ReturnType = typeof(AtlasPage))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AtlasPage() { }

	[CalledBy(Type = "Spine.Unity.BlendModeMaterials", Member = "CloneAtlasRegionWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), "System.Collections.Generic.List`1<ReplacementMaterial>"}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasPage), "UnityEngine.Material"}, ReturnType = typeof(AtlasPage))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AtlasPage Clone() { }

}

