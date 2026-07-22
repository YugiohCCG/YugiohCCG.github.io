namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[UsedByNativeCode]
public class Texture : object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	internal ColorSpace activeTextureColorSpace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
		internal get { } //Length: 160
	}

	public int anisoLevel
	{
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public override TextureDimension dimension
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 151
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public FilterMode filterMode
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlasPage", Member = "CreateAtlasTexture", ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "Init", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyReader", Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StylePropertyValue", typeof(float), "UnityEngine.UIElements.StyleSheets.ImageSource&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "CreateOrExpandTexture", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "PrepareAtlas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "Commit", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public override GraphicsFormat graphicsFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(GraphicsFormat))]
		 get { } //Length: 73
	}

	public override int height
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 151
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public override bool isReadable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
	}

	public float mipMapBias
	{
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 167
	}

	public int mipmapCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Texture3D), Member = "GetPixelData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetMipmapCount")]
		 get { } //Length: 151
	}

	public static bool streamingTextureDiscardUnusedMips
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateMipMapDebugWidget>b__7_0", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
		 get { } //Length: 42
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateMipMapDebugWidget>b__7_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
		 set { } //Length: 51
	}

	public Vector2 texelSize
	{
		[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetTexelSize")]
		 get { } //Length: 168
	}

	public uint updateCount
	{
		[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "NeedsUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "NeedsUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
	}

	public override int width
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 151
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 62
	}

	public TextureWrapMode wrapMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadWithPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadWithPaddingMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("GetWrapModeU")]
		 get { } //Length: 151
		[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public TextureWrapMode wrapModeU
	{
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public TextureWrapMode wrapModeV
	{
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	public TextureWrapMode wrapModeW
	{
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 151
		[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 164
	}

	[CallerCount(Count = 0)]
	private static Texture() { }

	[CalledBy(Type = "UnityEngine.WebCamTexture", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.WebCamTexture", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Texture() { }

	[CalledBy(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = typeof(Texture3D), Member = "GetPixelData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal UnityException CreateNonReadableException(Texture t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"})]
	internal ColorSpace get_activeTextureColorSpace() { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_anisoLevel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_anisoLevel_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override TextureDimension get_dimension() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public FilterMode get_filterMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(GraphicsFormat))]
	public override GraphicsFormat get_graphicsFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int get_height() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override bool get_isReadable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_mipMapBias() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_mipMapBias_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Texture3D), Member = "GetPixelData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetMipmapCount")]
	public int get_mipmapCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_mipmapCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateMipMapDebugWidget>b__7_0", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "GetTextureStreamingManager().GetDiscardUnusedMips")]
	public static bool get_streamingTextureDiscardUnusedMips() { }

	[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetTexelSize")]
	public Vector2 get_texelSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "NeedsUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "NeedsUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public uint get_updateCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint get_updateCount_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int get_width() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.ScaleFunc", typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&", "UnityEngine.Rendering.RenderGraphModule.ImportResourceParams&", typeof(bool)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "GetTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadWithPaddingMultiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadWithPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(Vector4), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "RTHandleNeedsReAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RenderGraphModule.TextureDesc&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("GetWrapModeU")]
	public TextureWrapMode get_wrapMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextureWrapMode get_wrapModeU() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureWrapMode get_wrapModeU_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextureWrapMode get_wrapModeV() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureWrapMode get_wrapModeV_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public TextureWrapMode get_wrapModeW() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureWrapMode get_wrapModeW_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ThreadSafe]
	private int GetDataHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ThreadSafe]
	private int GetDataWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[ThreadSafe]
	private TextureDimension GetDimension() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static TextureDimension GetDimension_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(Texture3D), Member = "GetPixelData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ulong GetPixelDataOffset_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	[CalledBy(Type = typeof(Texture3D), Member = "GetPixelData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ulong GetPixelDataSize_Injected(IntPtr _unity_self, int mipLevel, int element) { }

	[CallerCount(Count = 0)]
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsSRGBFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void IncrementUpdateCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IncrementUpdateCount_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_anisoLevel(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_anisoLevel_Injected(IntPtr _unity_self, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void set_dimension(TextureDimension value) { }

	[CalledBy(Type = "UnityEngine.UIElements.DynamicAtlasPage", Member = "CreateAtlasTexture", ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "Commit", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GradientSettingsAtlas", Member = "PrepareAtlas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.ShaderInfoStorage`1", Member = "CreateOrExpandTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyReader", Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.StylePropertyValue", typeof(float), "UnityEngine.UIElements.StyleSheets.ImageSource&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_filterMode(FilterMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void set_height(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", typeof(Shader), typeof(Material&), typeof(Texture2D&), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(string), typeof(Material), typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_mipMapBias(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_mipMapBias_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c", Member = "<CreateMipMapDebugWidget>b__7_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(Name = "GetTextureStreamingManager().SetDiscardUnusedMips")]
	public static void set_streamingTextureDiscardUnusedMips(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void set_width(int value) { }

	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureCurve", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureGradient", Member = "GetTexture", ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_wrapMode(TextureWrapMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_wrapModeU(TextureWrapMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_wrapModeU_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_wrapModeV(TextureWrapMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_wrapModeV_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(TextureFormat), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "CopyTextureAttributesFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_wrapModeW(TextureWrapMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_wrapModeW_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings", Member = "UpdateMaterials", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugPropertiesWithSlot")]
	private static void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot) { }

	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsCompressedFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "CanDecompressFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	internal bool ValidateFormat(TextureFormat format) { }

}

