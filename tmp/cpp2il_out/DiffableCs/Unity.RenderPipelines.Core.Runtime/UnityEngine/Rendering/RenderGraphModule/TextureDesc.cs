namespace UnityEngine.Rendering.RenderGraphModule;

public struct TextureDesc
{
	public TextureSizeMode sizeMode; //Field offset: 0x0
	public int width; //Field offset: 0x4
	public int height; //Field offset: 0x8
	public int slices; //Field offset: 0xC
	public Vector2 scale; //Field offset: 0x10
	public ScaleFunc func; //Field offset: 0x18
	public GraphicsFormat format; //Field offset: 0x20
	public FilterMode filterMode; //Field offset: 0x24
	public TextureWrapMode wrapMode; //Field offset: 0x28
	public TextureDimension dimension; //Field offset: 0x2C
	public bool enableRandomWrite; //Field offset: 0x30
	public bool useMipMap; //Field offset: 0x31
	public bool autoGenerateMips; //Field offset: 0x32
	public bool isShadowMap; //Field offset: 0x33
	public int anisoLevel; //Field offset: 0x34
	public float mipMapBias; //Field offset: 0x38
	public MSAASamples msaaSamples; //Field offset: 0x3C
	public bool bindTextureMS; //Field offset: 0x40
	public bool useDynamicScale; //Field offset: 0x41
	public bool useDynamicScaleExplicit; //Field offset: 0x42
	public RenderTextureMemoryless memoryless; //Field offset: 0x44
	public VRTextureUsage vrUsage; //Field offset: 0x48
	public string name; //Field offset: 0x50
	public FastMemoryDesc fastMemoryDesc; //Field offset: 0x58
	public bool fallBackToBlackTexture; //Field offset: 0x64
	public bool disableFallBackToImportedTexture; //Field offset: 0x65
	public bool clearBuffer; //Field offset: 0x66
	public Color clearColor; //Field offset: 0x68
	public bool discardBuffer; //Field offset: 0x78

	public GraphicsFormat colorFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		 get { } //Length: 105
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DepthBits depthBufferBits
	{
		[CalledBy(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
		 get { } //Length: 75
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
		 set { } //Length: 139
	}

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RTHandleResourcePool", Member = "CreateTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor), typeof(TextureSizeMode), typeof(int), typeof(float), typeof(FilterMode), typeof(TextureWrapMode), typeof(string)}, ReturnType = typeof(TextureDesc))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(Color), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(Color), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraDepthCopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateMotionVectorTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateAfterPostProcessTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyDepthPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TextureDesc), Member = "InitDefaultValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureDesc), Member = "InitDefaultValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureDesc), Member = "InitDefaultValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TextureDesc(TextureDesc input) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ImportResourceParams&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public TextureDesc(RenderTextureDescriptor input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "get_descriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(Texture), Member = "get_wrapMode", ReturnType = typeof(TextureWrapMode))]
	[Calls(Type = typeof(Texture), Member = "get_anisoLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(Texture), Member = "get_mipMapBias", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	public TextureDesc(RenderTexture input) { }

	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandles), Member = "CalculateDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(RTHandles), Member = "CalculateDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2Int CalculateFinalDimensions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	public GraphicsFormat get_colorFormat() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(int))]
	public DepthBits get_depthBufferBits() { }

	[CalledBy(Type = typeof(TextureResource), Member = "GetDescHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RTHandleResourcePool", Member = "GetHashCodeWithNameHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashFNV1A32), Member = "Create", ReturnType = typeof(HashFNV1A32))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScaleFunc), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextureXR), Member = "get_dimension", ReturnType = typeof(TextureDimension))]
	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_colorFormat(GraphicsFormat value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	public void set_depthBufferBits(DepthBits value) { }

}

