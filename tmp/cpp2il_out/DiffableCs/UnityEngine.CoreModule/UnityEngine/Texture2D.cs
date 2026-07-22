namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D blackTexture
	{
		[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "ClearTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources", Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UberPostSetupBloomPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 84
	}

	public TextureFormat format
	{
		[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "IsTextureValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(FilterMode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Texture2D>", "System.Collections.Generic.List`1<GlyphRenderMode>", "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateTexture2DArrayFromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(string)}, ReturnType = typeof(Texture2DArray))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetTextureFormat")]
		 get { } //Length: 118
	}

	public virtual bool isReadable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D whiteTexture
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureSlotManager", Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextureId", typeof(float), typeof(float), typeof(int), typeof(MaterialPropertyBlock), "UnityEngine.UIElements.UIR.CommandList"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources", Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 84
	}

	[CalledBy(Type = "Manager.Customization", Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string), typeof(bool), typeof(bool), typeof(Sprite&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.ImageHandler", Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextures>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture2D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Texture2D(int width, int height) { }

	[CalledBy(Type = "Manager.Customization+<GetCustomCursor>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "CreateOrExpandTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32[]"}, ReturnType = typeof(float))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[CalledBy(Type = "Discord.ImageManager", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Discord.ImageHandle"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "PrepareAtlas", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCrunchFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.SpriteUtilities", Member = "CreateCircleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color32)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefaultFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureApplyPMA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.SpriteUtilities", Member = "CreateCircleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color32)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Discord.ImageManager", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Discord.ImageHandle"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public void Apply() { }

	[CalledBy(Type = "Manager.Customization", Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(bool), typeof(bool), typeof(Texture2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32[]"}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateAtlasTexturesInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateAtlasTexturesInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "UpdateTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<GetTextureFromWeb>d__145", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[CalledBy(Type = "Manager.Customization", Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(bool), typeof(bool), typeof(Texture2D&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Compress(bool highQuality) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Compress_Injected(IntPtr _unity_self, bool highQuality) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "ClearTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources", Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UberPostSetupBloomPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D get_blackTexture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_blackTexture_Injected() { }

	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlas", Member = "IsTextureValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(FilterMode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>&", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>&", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>&", "System.Collections.Generic.List`1<GlyphRenderMode>&", "System.Collections.Generic.List`1<Single>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Texture2D>", "System.Collections.Generic.List`1<GlyphRenderMode>", "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateTexture2DArrayFromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(string)}, ReturnType = typeof(Texture2DArray))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool get_isReadable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureSlotManager", Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextureId", typeof(float), typeof(float), typeof(int), typeof(MaterialPropertyBlock), "UnityEngine.UIElements.UIR.CommandList"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphDefaultResources", Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D get_whiteTexture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_whiteTexture_Injected() { }

	[CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private ulong GetImageDataSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ulong GetImageDataSize_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureApplyPMA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Color[] GetPixels_Injected(IntPtr _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32[]"}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	public Byte[] GetRawTextureData() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "SetTexel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "CreateOrExpandTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "GetImageDataSize", ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Texture2D), Member = "GetWritableImageData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Texture), Member = "CreateNativeArrayLengthOverflowException", ReturnType = typeof(UnityException))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public NativeArray<T> GetRawTextureData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] GetRawTextureData_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private IntPtr GetWritableImageData(int frame) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Texture2D), Member = "Internal_CreateImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("Texture2DScripting::CreateEmpty")]
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	[CalledBy(Type = typeof(Texture2D), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureColorSpace), typeof(TextureCreationFlags), typeof(IntPtr), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	[CalledBy(Type = "Discord.ImageManager", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Discord.ImageHandle"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void LoadRawTextureData(Byte[] data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	private bool LoadRawTextureDataImplArray(Byte[] data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Rect[] PackTextures_Injected(IntPtr _unity_self, Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetPixelValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Int32[]"}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReadPixelsImpl_Injected(IntPtr _unity_self, in Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.Glyph&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.Glyph&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool Reinitialize(int width, int height) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureApplyPMA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public void SetPixels(Color[] colors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(UnityException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "Commit", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ref ManagedSpanWrapper pixel, int miplevel, int frame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsPVRTCFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

