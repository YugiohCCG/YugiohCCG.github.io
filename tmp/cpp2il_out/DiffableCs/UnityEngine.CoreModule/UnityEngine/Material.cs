namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : object
{
	private static readonly int k_ColorId; //Field offset: 0x0
	private static readonly int k_MainTexId; //Field offset: 0x4

	public Color color
	{
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 401
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 385
	}

	public LocalKeyword[] enabledKeywords
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 166
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "SetMaterialSettingsToFixDrawOrder", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 167
	}

	public Texture mainTexture
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetMainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion"}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = "Spine.AtlasPage")]
		[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(Material)}, ReturnType = "Spine.AtlasPage")]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MaterialsTextureLoader", Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(Material), Member = "GetTextureImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 245
		[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "UnityEngine.Texture2D[]", typeof(Material), typeof(bool)}, ReturnType = "Spine.Unity.SpineAtlasAsset")]
		[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "Spine.Atlas")]
		[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(Material)}, ReturnType = "Spine.AtlasPage")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 286
	}

	public Vector2 mainTextureOffset
	{
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0", Member = "<DOOffset>b__0", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "GetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 245
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0", Member = "<DOOffset>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 293
	}

	public Vector2 mainTextureScale
	{
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0", Member = "<DOTiling>b__0", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "GetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 245
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0", Member = "<DOTiling>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 293
	}

	public int passCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "CanCopyMSAA", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "CanCopyMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.TextureDesc&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature", Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetShader()->GetPassCount")]
		 get { } //Length: 151
	}

	public int renderQueue
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SetCustomRenderQueue")]
		 set { } //Length: 164
	}

	public Shader shader
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(string), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = "Spine.Skin")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(string), typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = "Spine.Skin")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Material), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(float)}, ReturnType = "Spine.AtlasRegion")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 177
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 214
	}

	public String[] shaderKeywords
	{
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 151
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 166
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static Material() { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "get_material", ReturnType = typeof(Material))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "UnityEngine.Texture2D[]", typeof(Shader), typeof(bool)}, ReturnType = "Spine.Unity.SpineAtlasAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "get_EmptyRegion", ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Font", typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "get_errorMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Shaders", Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "CreateBlitShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "GetDefaultSpriteMaterial", ReturnType = typeof(Material))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Material(Shader shader) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	public Material(Material source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int ComputeCRC() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void DisableKeyword(in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.MaskingTypes"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "EnableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "DisableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "EnableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void DisableKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = True)]
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void EnableKeyword(string keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void EnableKeyword(in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = True)]
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalProjector", Member = "IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "InitStencilDeferredMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "RenderDebugOccluderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", typeof(Vector2), typeof(float), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public int FindPass(string passName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int FindPass_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Color get_color() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_enableInstancing() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_enableInstancing_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.TextCoreSettings")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<Material>", "System.Collections.Generic.List`1<GlyphRenderMode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = "Spine.Unity.MaterialsTextureLoader", Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshSingleCanvasRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(Material)}, ReturnType = "Spine.AtlasPage")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToSpineAtlasPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = "Spine.AtlasPage")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetMainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "GetTextureImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[CallsUnknownMethods(Count = 3)]
	public Texture get_mainTexture() { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0", Member = "<DOOffset>b__0", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_mainTextureOffset() { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0", Member = "<DOTiling>b__0", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "GetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_mainTextureScale() { }

	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "CanCopyMSAA", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "CanCopyMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.TextureDesc&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature", Member = "AddRenderPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderer", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetShader()->GetPassCount")]
	public int get_passCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_passCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(float)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Material), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(string), typeof(Material), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = "Spine.Skin")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(string), typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = "Spine.Skin")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Material), typeof(TextureFormat), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Shader get_shader() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public String[] get_shaderKeywords() { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass17_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass20_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass70_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Color GetColor(string name) { }

	[CalledBy(Type = "TMPro.TMP_Text", Member = "get_faceColor", ReturnType = typeof(Color32))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "get_outlineColor", ReturnType = typeof(Color32))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass18_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass21_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass71_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(int), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Color GetColor(int nameID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	[CallerCount(Count = 84)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public float GetFloat(int nameID) { }

	[CalledBy(Type = "Manager.Background", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass22_0", Member = "<DOFloat>b__0", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float GetFloat(string name) { }

	[CallerCount(Count = 84)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public int GetInt(string name) { }

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private String[] GetShaderKeywords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static String[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetOutlineThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetSharedMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "EnableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "ValidateEnvMapProperty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetSharedMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Material[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "ValidateEnvMapProperty", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Material), Member = "GetTextureImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	public Texture GetTexture(int nameID) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<SetFieldBackground>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "get_OpponentBGTex", ReturnType = typeof(Texture))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "get_FieldBGTex", ReturnType = typeof(Texture))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "GetTexFromPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem"}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(string)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "GetTextureImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	public Texture GetTexture(string name) { }

	[CalledBy(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass25_0", Member = "<DOOffset>b__0", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "GetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	public Vector2 GetTextureOffset(string name) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass8_0", Member = "<DOOffset>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Material), Member = "get_mainTextureOffset", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Material), Member = "GetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 GetTextureOffset(int nameID) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass9_0", Member = "<DOTiling>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Material), Member = "get_mainTextureScale", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Material), Member = "GetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 GetTextureScale(int nameID) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass27_0", Member = "<DOTiling>b__0", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "GetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	public Vector2 GetTextureScale(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetTextureScaleAndOffsetFromScript")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetTextureScaleAndOffsetImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret) { }

	[CalledBy(Type = "TMPro.ShaderUtilities", Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.ShaderUtilities", Member = "ComputePaddingForProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass29_0", Member = "<DOVector>b__0", ReturnType = typeof(Vector4))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector4 GetVector(int nameID) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass28_0", Member = "<DOVector>b__0", ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector4 GetVector(string name) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool HasFloat(int nameID) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("HasFloatFromScript")]
	private bool HasFloatImpl(int name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name) { }

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCachedSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Color, Color, ColorOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(float), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Single, Single, FloatOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOTiling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector2), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector2, Vector2, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Vector4), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Core.TweenerCore`3<Vector4, Vector4, VectorOptions>")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool HasProperty(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass16_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass19_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass69_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_color(Color value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_enabledKeywords(LocalKeyword[] value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonRenderer", Member = "SetMaterialSettingsToFixDrawOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_enableInstancing(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_enableInstancing_Injected(IntPtr _unity_self, bool value) { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "CreateRuntimeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), "UnityEngine.Texture2D[]", typeof(Material), typeof(bool)}, ReturnType = "Spine.Unity.SpineAtlasAsset")]
	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAtlas)}, ReturnType = "Spine.Atlas")]
	[CalledBy(Type = "Spine.Unity.BlendModeMaterialsAsset+AtlasMaterialCache", Member = "GetAtlasPageWithMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasPage", typeof(Material)}, ReturnType = "Spine.AtlasPage")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(float), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegionPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void set_mainTexture(Texture value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass24_0", Member = "<DOOffset>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_mainTextureOffset(Vector2 value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass26_0", Member = "<DOTiling>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_mainTextureScale(Vector2 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetCustomRenderQueue")]
	public void set_renderQueue(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_renderQueue_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset", typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.MaterialManager", Member = "CopyMaterialPresetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_shader(Shader value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_shaderKeywords(String[] value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetBuffer(string name, GraphicsBuffer value) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetFaceColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetFaceColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetOutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass18_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass21_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass71_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetColor(int nameID, Color value) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Gradient), typeof(string), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass17_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass20_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass70_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetColor(string name, Color value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetEnabledKeywords_Injected(IntPtr _unity_self, LocalKeyword[] keywords) { }

	[CalledBy(Type = "Manager.Background", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass22_0", Member = "<DOFloat>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderMotionBlur>b__147_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+MotionBlurPassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "CreateBlitShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "TMPro.TMP_SubMesh", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void SetFloat(string name, float value) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetFloat(int nameID, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA+<>c", Member = "<Render>b__17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.TemporalAA+TaaPassData", "UnityEngine.Rendering.RenderGraphModule.RasterGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetFloatArray(int nameID, Single[] values) { }

	[CalledBy(Type = typeof(Material), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void SetFloatArray(int name, Single[] values, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[CallerCount(Count = 85)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetBufferFromScript")]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMaskable", Member = "<UnityEngine.UI.IMaterialModifier.GetModifiedMaterial>b__34_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetInt(int nameID, int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetInt(string name, int value) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetInteger(int nameID, int value) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("SetIntFromScript")]
	private void SetIntImpl(int name, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UpdateMotionBlurMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[CalledBy(Type = typeof(Material), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UpdateMotionBlurMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Material), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRenderDevice", Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"EvaluationState&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(RenderTexture), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextureBlitter", Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool SetPass_Injected(IntPtr _unity_self, int pass) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, String[] names) { }

	[CalledBy(Type = "Scenes.Battle.DuelZone+<SetFieldBackground>d__101", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetTexOnPS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetPSTex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetPSSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.ParticleSystem", typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetFieldBGTex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetOpponentBGTex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.ShuffleEffect", Member = "SetSleeveMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SetTexture(string name, Texture value) { }

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetTexture(int nameID, Texture value) { }

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass25_0", Member = "<DOOffset>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetTextureOffset(string name, Vector2 value) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass8_0", Member = "<DOOffset>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Material), Member = "set_mainTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetTextureOffset(int nameID, Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetTextureOffsetFromScript")]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetTextureOffsetImpl_Injected(IntPtr _unity_self, int name, in Vector2 offset) { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass9_0", Member = "<DOTiling>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Material), Member = "set_mainTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetTextureScale(int nameID, Vector2 value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass27_0", Member = "<DOTiling>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetTextureScale(string name, Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SetTextureScaleFromScript")]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetTextureScaleImpl_Injected(IntPtr _unity_self, int name, in Vector2 scale) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass28_0", Member = "<DOVector>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetVector(string name, Vector4 value) { }

	[CallerCount(Count = 67)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetVector(int nameID, Vector4 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderDoFBokeh>b__139_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+DoFBokehPassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetVectorArray(int nameID, Vector4[] values) { }

	[CalledBy(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SetVectorArray(string name, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

}

