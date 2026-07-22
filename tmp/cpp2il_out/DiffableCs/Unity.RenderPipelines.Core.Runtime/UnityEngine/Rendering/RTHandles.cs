namespace UnityEngine.Rendering;

public static class RTHandles
{
	private static RTHandleSystem s_DefaultInstance; //Field offset: 0x0

	public static int maxHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 91
	}

	public static int maxWidth
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 91
	}

	public static RTHandleProperties rtHandleProperties
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 120
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static RTHandles() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private static RTHandle Alloc(RTHandle tex) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo&), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderPassEvent", "UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.PostProcessParams&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateGbufferResources", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(RenderTargetIdentifier tex, string name) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "ImportXRMotionColorAndDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceShadows+ScreenSpaceShadowsPostPass", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(RenderTargetIdentifier tex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandle), Member = "SetRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static RTHandle Alloc(RenderTexture tex, bool transferOwnership = false) { }

	[CalledBy(Type = typeof(TextureXR), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "TryGetCachedUserLutTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static RTHandle Alloc(Texture tex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "AllocAutoSizedRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RTHandleAllocInfo)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static RTHandle Alloc(ScaleFunc scaleFunc, RTHandleAllocInfo info) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ScaleFunc), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[CalledBy(Type = typeof(TextureResource), Member = "CreateGraphicsResource", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(ScaleFunc scaleFunc, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "AllocAutoSizedRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RTHandleAllocInfo)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 3)]
	public static RTHandle Alloc(Vector2 scaleFactor, RTHandleAllocInfo info) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(Vector2), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[CalledBy(Type = typeof(TextureResource), Member = "CreateGraphicsResource", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(Vector2 scaleFactor, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "AllocShadowRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "ShadowRTReAllocateIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "CreateRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(RTHandle), Member = "SetRenderTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static RTHandle Alloc(int width, int height, RTHandleAllocInfo info) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HistoryContext), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HistoryUpdateInfo&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureResource), Member = "CreateGraphicsResource", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "AllocateTexturesIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(int width, int height, GraphicsFormat format, int slices = 1, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(TextureWrapMode), typeof(int), typeof(FilterMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, bool useDynamicScaleExplicit = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	[CalledBy(Type = typeof(TextureDesc), Member = "CalculateFinalDimensions", ReturnType = typeof(Vector2Int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2Int CalculateDimensions(ScaleFunc scaleFunc) { }

	[CalledBy(Type = typeof(TextureDesc), Member = "CalculateFinalDimensions", ReturnType = typeof(Vector2Int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "CalculateDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2Int CalculateDimensions(Vector2 scaleFactor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandleSystem), Member = "CalculateRatioAgainstMaxSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_maxHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int get_maxWidth() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static RTHandleProperties get_rtHandleProperties() { }

	[CalledBy(Type = typeof(BufferedRTHandleSystem), Member = "AllocBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static GraphicsFormat GetFormat(GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	public static void Initialize(int width, int height, bool useLegacyDynamicResControl = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Initialize(int width, int height) { }

	[CalledBy(Type = typeof(LensFlareCommonSRP), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Texture2DAtlas), Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureXR), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "AddStaleResourceToPoolOrRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RTHandleSystem), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void Release(RTHandle rth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandleSystem), Member = "SetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetReferenceSize(int width, int height) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_useDynamicScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandleSystem), Member = "SetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetReferenceSize(int width, int height) { }

}

