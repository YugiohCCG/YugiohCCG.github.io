namespace Spine.Unity.AttachmentTools;

[Extension]
public static class AttachmentRegionExtensions
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetPositionOffset(RegionAttachment regionAttachment, Vector2 offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetPositionOffset(RegionAttachment regionAttachment, float x, float y) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegionAttachment), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "UpdateOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static void SetRegion(Attachment attachment, AtlasRegion region, bool updateOffset = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionAttachment), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "UpdateOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	public static void SetRegion(RegionAttachment attachment, AtlasRegion region, bool updateOffset = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	public static void SetRegion(MeshAttachment attachment, AtlasRegion region, bool updateUVs = true) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetRotation(RegionAttachment regionAttachment, float rotation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetScale(RegionAttachment regionAttachment, Vector2 scale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static void SetScale(RegionAttachment regionAttachment, float x, float y) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[ContainsInvalidInstructions]
	[Extension]
	public static RegionAttachment ToRegionAttachment(Sprite sprite, Material material, float rotation = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static RegionAttachment ToRegionAttachment(Sprite sprite, AtlasPage page, float rotation = 0) { }

	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(AtlasPage), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegionAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionAttachment), Member = "UpdateOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[Extension]
	public static RegionAttachment ToRegionAttachment(AtlasRegion region, string attachmentName, float scale = 0.01, float rotation = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsInvalidInstructions]
	[Extension]
	public static RegionAttachment ToRegionAttachmentPMAClone(Sprite sprite, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = false, Material materialPropertySource = null, float rotation = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static RegionAttachment ToRegionAttachmentPMAClone(Sprite sprite, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = false, float rotation = 0) { }

}

