namespace Spine.Unity.AttachmentTools;

[Extension]
public static class AttachmentCloneExtensions
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Extension]
	public static Attachment GetRemappedClone(Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = true, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, bool pivotShiftsMeshUVCoords = true, bool useOriginalRegionScale = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionAttachment), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "UpdateOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshAttachment), Member = "NewLinkedMesh", ReturnType = typeof(MeshAttachment))]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	[Extension]
	public static Attachment GetRemappedClone(Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, float scale = 0.01) { }

}

