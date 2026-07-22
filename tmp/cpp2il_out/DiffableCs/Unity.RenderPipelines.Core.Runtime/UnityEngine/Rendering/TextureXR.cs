namespace UnityEngine.Rendering;

public static class TextureXR
{
	private static int m_MaxViews; //Field offset: 0x0
	private static Texture m_BlackUIntTexture2DArray; //Field offset: 0x8
	private static Texture m_BlackUIntTexture; //Field offset: 0x10
	private static RTHandle m_BlackUIntTexture2DArrayRTH; //Field offset: 0x18
	private static RTHandle m_BlackUIntTextureRTH; //Field offset: 0x20
	private static Texture2DArray m_ClearTexture2DArray; //Field offset: 0x28
	private static Texture2D m_ClearTexture; //Field offset: 0x30
	private static RTHandle m_ClearTexture2DArrayRTH; //Field offset: 0x38
	private static RTHandle m_ClearTextureRTH; //Field offset: 0x40
	private static Texture2DArray m_MagentaTexture2DArray; //Field offset: 0x48
	private static Texture2D m_MagentaTexture; //Field offset: 0x50
	private static RTHandle m_MagentaTexture2DArrayRTH; //Field offset: 0x58
	private static RTHandle m_MagentaTextureRTH; //Field offset: 0x60
	private static Texture2D m_BlackTexture; //Field offset: 0x68
	private static Texture3D m_BlackTexture3D; //Field offset: 0x70
	private static Texture2DArray m_BlackTexture2DArray; //Field offset: 0x78
	private static RTHandle m_BlackTexture2DArrayRTH; //Field offset: 0x80
	private static RTHandle m_BlackTextureRTH; //Field offset: 0x88
	private static RTHandle m_BlackTexture3DRTH; //Field offset: 0x90
	private static Texture2DArray m_WhiteTexture2DArray; //Field offset: 0x98
	private static RTHandle m_WhiteTexture2DArrayRTH; //Field offset: 0xA0
	private static RTHandle m_WhiteTextureRTH; //Field offset: 0xA8

	public static TextureDimension dimension
	{
		[CalledBy(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextureDesc), Member = "InitDefaultValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 115
	}

	public static int maxViews
	{
		[CallerCount(Count = 0)]
		 set { } //Length: 82
	}

	public static int slices
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 77
	}

	public static bool useTexArray
	{
		[CalledBy(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraphUtils), Member = "IsTextureXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 69
	}

	[CallerCount(Count = 0)]
	private static TextureXR() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Color), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Texture3D CreateBlackTexture3D(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[CalledBy(Type = typeof(TextureXR), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[CalledBy(Type = typeof(TextureXR), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(Texture2DArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphics), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(Texture), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextureDesc), Member = "InitDefaultValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRendererData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static TextureDimension get_dimension() { }

	[CallerCount(Count = 0)]
	public static int get_slices() { }

	[CalledBy(Type = typeof(XRMirrorView), Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), typeof(XRDisplaySubsystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "IsTextureXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool get_useTexArray() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static RTHandle GetBlackTexture() { }

	[CallerCount(Count = 0)]
	public static RTHandle GetBlackTexture3D() { }

	[CallerCount(Count = 0)]
	public static RTHandle GetBlackTextureArray() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static RTHandle GetBlackUIntTexture() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static RTHandle GetClearTexture() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static RTHandle GetMagentaTexture() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static RTHandle GetWhiteTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Texture3D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Color), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureXR), Member = "CreateTexture2DArrayFromTexture2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(string)}, ReturnType = typeof(Texture2DArray))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "set_volumeDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(TextureXR), Member = "CreateBlackUIntTextureArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(RTHandles), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader) { }

	[CallerCount(Count = 0)]
	public static void set_maxViews(int value) { }

}

