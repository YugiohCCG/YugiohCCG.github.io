namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
public class GraphicsFormatUtility
{
	private static readonly GraphicsFormat[] tableNoStencil; //Field offset: 0x0
	private static readonly GraphicsFormat[] tableStencil; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static GraphicsFormatUtility() { }

	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static uint GetAlphaComponentCount(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas", Member = "GetApproxCacheSizeInByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(GraphicsFormat)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas", Member = "GetMaxCacheSizeForWeightInByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GraphicsFormat)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static uint GetBlockSize(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateValidityTextureWithoutMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitCubeToOctahedral2DQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static uint GetComponentCount(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = "get_depthBufferBits", ReturnType = "UnityEngine.Rendering.DepthBits")]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "get_depthBufferBits", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static int GetDepthBits(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ScaleFunc", typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandles", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandles", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandles", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandles", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ScaleFunc", typeof(int), "UnityEngine.Rendering.DepthBits", typeof(GraphicsFormat), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = "UnityEngine.Rendering.RTHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = "set_depthBufferBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DepthBits"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoSubpixelMorphologicalAntialiasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderSMAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.AntialiasingQuality", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	public static GraphicsFormat GetDepthStencilFormat(int depthBits) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "GetTemporaryShadowTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = typeof(RenderTexture), Member = "GetDepthStencilFormatLegacy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	[CalledBy(Type = typeof(Texture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("GetGraphicsFormat_Native_Texture")]
	internal static GraphicsFormat GetFormat(Texture texture) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static GraphicsFormat GetFormat_Injected(IntPtr texture) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(IsThreadSafe = True)]
	public static string GetFormatString(GraphicsFormat format) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetFormatString_Injected(GraphicsFormat format, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[CalledBy(Type = typeof(RenderTexture), Member = "GetCompatibleFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(RenderTextureReadWrite)}, ReturnType = typeof(GraphicsFormat))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_colorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = False)]
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "get_additionalLightsCookieFormat", ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	[CalledBy(Type = typeof(RenderTexture), Member = "get_format", ReturnType = typeof(RenderTextureFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "get_colorFormat", ReturnType = typeof(RenderTextureFormat))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[CalledBy(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleA(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleB(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleG(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "IsSingleChannelBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Texture)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitCubeToOctahedral2DQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static FormatSwizzle GetSwizzleR(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "IsAlphaFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool HasAlphaChannel(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitCubeToOctahedral2DQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitQuadSingleChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsAlphaOnlyFormat(GraphicsFormat format) { }

	[CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsCompressedFormat(TextureFormat format) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(IntPtr), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CubemapArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	public static bool IsCrunchFormat(TextureFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphBuilders", Member = "CheckUseFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsDepthFormat(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ClearTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.TextureResource"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ReleaseTextureCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.IRenderGraphResource"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = "set_depthBufferBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DepthBits"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TextureDesc", Member = "get_colorFormat", ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = typeof(RenderTexture), Member = "ValidateRenderTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "IsHDRFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsFloatFormat(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "IsHDRFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsHalfFormat(GraphicsFormat format) { }

	[CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(IntPtr), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Cubemap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags), typeof(int), typeof(MipmapLimitDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), "UnityEngine.Rendering.MSAASamples", typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[CalledBy(Type = "UnityEngine.Rendering.RTHandleSystem", Member = "GetStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRendererData", Member = "set_depthAttachmentFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DepthFormat"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static bool IsStencilFormat(GraphicsFormat format) { }

}

