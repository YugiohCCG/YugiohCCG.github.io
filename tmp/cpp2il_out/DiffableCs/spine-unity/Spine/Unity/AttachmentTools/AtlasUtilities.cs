namespace Spine.Unity.AttachmentTools;

[Extension]
public static class AtlasUtilities
{
	private struct IntAndAtlasRegionKey
	{
		private int i; //Field offset: 0x0
		private AtlasRegion region; //Field offset: 0x8

		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public IntAndAtlasRegionKey(int i, AtlasRegion region) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	internal const TextureFormat SpineTextureFormat = 4; //Field offset: 0x0
	internal const float DefaultMipmapBias = -0.5; //Field offset: 0x0
	internal const bool UseMipMaps = False; //Field offset: 0x0
	internal const float DefaultScale = 0.01; //Field offset: 0x0
	private const int NonrenderingRegion = -1; //Field offset: 0x0
	private static readonly Dictionary<AtlasRegion, Int32> existingRegions; //Field offset: 0x0
	private static readonly List<Int32> regionIndices; //Field offset: 0x8
	private static readonly List<AtlasRegion> originalRegions; //Field offset: 0x10
	private static readonly List<AtlasRegion> repackedRegions; //Field offset: 0x18
	private static List<Texture2D>[] texturesToPackAtParam; //Field offset: 0x20
	private static List<Attachment> inoutAttachments; //Field offset: 0x28
	private static Dictionary<IntAndAtlasRegionKey, Texture2D> CachedRegionTextures; //Field offset: 0x30
	private static List<Texture2D> CachedRegionTexturesList; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Unity.AttachmentTools.AtlasUtilities+IntAndAtlasRegionKey, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private static AtlasUtilities() { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearCache() { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void CopyTexture(Texture2D source, Rect sourceRect, Texture2D destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void CopyTextureApplyPMA(Texture2D source, Rect sourceRect, Texture2D destination) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeU", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeV", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeW", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static void CopyTextureAttributesFrom(Texture2D destination, Texture2D source) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeW", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeV", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeU", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static Texture2D GetClone(Texture2D t, TextureFormat textureFormat = 4, bool mipmaps = false, bool linear = false, bool applyPMA = false) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(float)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static Texture2D GetMainTexture(AtlasRegion region) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = false, string newAssetName = "Repacked Attachments", bool clearCache = false, bool useOriginalNonrenderables = true, Int32[] additionalTexturePropertyIDsToCopy = null, Texture2D[] additionalOutputTextures = null, TextureFormat[] additionalTextureFormats = null, Boolean[] additionalTextureIsLinear = null) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentRegionExtensions), Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "UVRectToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(AtlasRegion), typeof(AtlasPage)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "PackTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D[]), typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(AtlasUtilities), Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_mipMapBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ClearCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshAttachment), Member = "NewLinkedMesh", ReturnType = typeof(MeshAttachment))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 31)]
	[ContainsUnimplementedInstructions]
	public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = false, string newAssetName = "Repacked Attachments", Material materialPropertySource = null, bool clearCache = false, bool useOriginalNonrenderables = true, Int32[] additionalTexturePropertyIDsToCopy = null, Texture2D[] additionalOutputTextures = null, TextureFormat[] additionalTextureFormats = null, Boolean[] additionalTextureIsLinear = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(Skin))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Skin GetRepackedSkin(Skin o, string newName, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = false, bool useOriginalNonrenderables = true, bool clearCache = false, Int32[] additionalTexturePropertyIDsToCopy = null, Texture2D[] additionalOutputTextures = null, TextureFormat[] additionalTextureFormats = null, Boolean[] additionalTextureIsLinear = null) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Skin), Member = "get_Attachments", ReturnType = typeof(System.Collections.Generic.ICollection`1<Spine.Skin+SkinEntry>))]
	[Calls(Type = typeof(Skin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skin), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	[Extension]
	public static Skin GetRepackedSkin(Skin o, string newName, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = 4, bool mipmaps = false, Material materialPropertySource = null, bool clearCache = false, bool useOriginalNonrenderables = true, Int32[] additionalTexturePropertyIDsToCopy = null, Texture2D[] additionalOutputTextures = null, TextureFormat[] additionalTextureFormats = null, Boolean[] additionalTextureIsLinear = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Rect GetSpineAtlasRect(AtlasRegion region, bool includeRotate = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static Texture2D GetTexture(AtlasRegion region, int texturePropertyId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static Texture2D GetTexture(AtlasRegion region, string texturePropertyName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Rect GetUnityRect(AtlasRegion region, int textureHeight) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	private static Rect GetUnityRect(AtlasRegion region) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasUtilities), Member = "ClearCache", ReturnType = typeof(void))]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void Init() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static float InverseLerp(float a, float b, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsRenderable(Attachment a) { }

	[CallerCount(Count = 0)]
	[Extension]
	private static Rect SpineUnityFlipRect(Rect rect, int textureHeight) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static AtlasRegion ToAtlasRegion(Texture2D t, Material materialPropertySource, float scale = 0.01) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(AtlasPage)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AttachmentCloneExtensions), Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(AtlasPage), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(AtlasUtilities), Member = "TextureRectToUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	internal static AtlasRegion ToAtlasRegion(Sprite s, bool isolatedTexture = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static AtlasRegion ToAtlasRegion(Sprite s, Material material) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static AtlasRegion ToAtlasRegion(Sprite s, AtlasPage page) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(float)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static AtlasRegion ToAtlasRegion(Texture2D t, Shader shader, float scale = 0.01, Material materialPropertySource = null) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AttachmentCloneExtensions), Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static AtlasRegion ToAtlasRegionPMAClone(Sprite s, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = false, Material materialPropertySource = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static AtlasRegion ToAtlasRegionPMAClone(Sprite s, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static AtlasRegion ToAtlasRegionPMAClone(Texture2D t, Material materialPropertySource, TextureFormat textureFormat = 4, bool mipmaps = false) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(AtlasRegion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(AtlasPage))]
	[Calls(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	public static AtlasRegion ToAtlasRegionPMAClone(Texture2D t, Shader shader, TextureFormat textureFormat = 4, bool mipmaps = false, Material materialPropertySource = null) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttachmentCloneExtensions), Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(AttachmentRegionExtensions), Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AtlasPage), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Extension]
	public static AtlasPage ToSpineAtlasPage(Material m) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetMainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float)}, ReturnType = typeof(Sprite))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static Sprite ToSprite(AtlasRegion ar, float pixelsPerUnit = 100) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = typeof(AtlasRegion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(AtlasUtilities), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeW", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeV", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeU", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_textureRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	private static Texture2D ToTexture(Sprite s, TextureFormat textureFormat = 4, bool mipmaps = false, bool linear = false, bool applyPMA = false) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(AtlasUtilities), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeW", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeV", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_wrapModeU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureWrapMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_wrapModeU", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "set_anisoLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Unity.AttachmentTools.AtlasUtilities+IntAndAtlasRegionKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntAndAtlasRegionKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(AtlasUtilities), Member = "GetMainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion)}, ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Spine.Unity.AttachmentTools.AtlasUtilities+IntAndAtlasRegionKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntAndAtlasRegionKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Color[]))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static Texture2D ToTexture(AtlasRegion ar, TextureFormat textureFormat = 4, bool mipmaps = false, int texturePropertyId = 0, bool linear = false, bool applyPMA = false) { }

	[CalledBy(Type = typeof(AtlasUtilities), Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(System.Collections.Generic.List`1<Spine.Attachment>), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), typeof(Int32[]), typeof(Texture2D[]), typeof(TextureFormat[]), typeof(Boolean[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private static AtlasRegion UVRectToAtlasRegion(Rect uvRect, AtlasRegion referenceRegion, AtlasPage page) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight) { }

}

