namespace UnityEngine.Rendering.RenderGraphModule.Util;

[Extension]
public static class RenderGraphUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<CopyPassData, RasterGraphContext> <>9__8_0; //Field offset: 0x8
		public static BaseRenderFunc<BlitPassData, UnsafeGraphContext> <>9__14_0; //Field offset: 0x10
		public static BaseRenderFunc<BlitMaterialPassData, UnsafeGraphContext> <>9__20_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderGraphUtils), Member = "BlitRenderFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils+BlitPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
		internal void <AddBlitPass>b__14_0(BlitPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderGraphUtils), Member = "BlitMaterialRenderFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.Util.RenderGraphUtils+BlitMaterialPassData", typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
		internal void <AddBlitPass>b__20_0(BlitMaterialPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blitter), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <AddCopyPass>b__8_0(CopyPassData data, RasterGraphContext context) { }

	}

	internal enum BlitFilterMode
	{
		ClampNearest = 0,
		ClampBilinear = 1,
	}

	internal struct BlitMaterialParameters
	{
		private static readonly int blitTextureProperty; //Field offset: 0x0
		private static readonly int blitSliceProperty; //Field offset: 0x4
		private static readonly int blitMipProperty; //Field offset: 0x8
		private static readonly int blitScaleBias; //Field offset: 0xC
		public TextureHandle source; //Field offset: 0x0
		public TextureHandle destination; //Field offset: 0x10
		public Vector2 scale; //Field offset: 0x20
		public Vector2 offset; //Field offset: 0x28
		public int sourceSlice; //Field offset: 0x30
		public int destinationSlice; //Field offset: 0x34
		public int numSlices; //Field offset: 0x38
		public int sourceMip; //Field offset: 0x3C
		public int destinationMip; //Field offset: 0x40
		public int numMips; //Field offset: 0x44
		public Material material; //Field offset: 0x48
		public int shaderPass; //Field offset: 0x50
		public MaterialPropertyBlock propertyBlock; //Field offset: 0x58
		public int sourceTexturePropertyID; //Field offset: 0x60
		public int sourceSlicePropertyID; //Field offset: 0x64
		public int sourceMipPropertyID; //Field offset: 0x68
		public int scaleBiasPropertyID; //Field offset: 0x6C
		public FullScreenGeometryType geometry; //Field offset: 0x70

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static BlitMaterialParameters() { }

		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass) { }

		[CalledBy(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Material), typeof(int), typeof(MaterialPropertyBlock), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(FullScreenGeometryType), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int), typeof(MaterialPropertyBlock), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(FullScreenGeometryType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Material), typeof(int), typeof(MaterialPropertyBlock), typeof(FullScreenGeometryType), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int), typeof(MaterialPropertyBlock), typeof(FullScreenGeometryType), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, int destinationSlice, int destinationMip, int numSlices = -1, int numMips = 1, int sourceSlice = -1, int sourceMip = -1, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlitMaterialParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public BlitMaterialParameters(TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, Material material, int shaderPass, MaterialPropertyBlock mpb, FullScreenGeometryType geometry = 0, int sourceTexturePropertyID = -1, int sourceSlicePropertyID = -1, int sourceMipPropertyID = -1, int scaleBiasPropertyID = -1) { }

	}

	private class BlitMaterialPassData
	{
		public int sourceTexturePropertyID; //Field offset: 0x10
		public TextureHandle source; //Field offset: 0x14
		public TextureHandle destination; //Field offset: 0x24
		public Vector2 scale; //Field offset: 0x34
		public Vector2 offset; //Field offset: 0x3C
		public Material material; //Field offset: 0x48
		public int shaderPass; //Field offset: 0x50
		public MaterialPropertyBlock propertyBlock; //Field offset: 0x58
		public int sourceSlice; //Field offset: 0x60
		public int destinationSlice; //Field offset: 0x64
		public int numSlices; //Field offset: 0x68
		public int sourceMip; //Field offset: 0x6C
		public int destinationMip; //Field offset: 0x70
		public int numMips; //Field offset: 0x74
		public FullScreenGeometryType geometry; //Field offset: 0x78
		public int sourceSlicePropertyID; //Field offset: 0x7C
		public int sourceMipPropertyID; //Field offset: 0x80
		public int scaleBiasPropertyID; //Field offset: 0x84
		public bool isXR; //Field offset: 0x88

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BlitMaterialPassData() { }

	}

	private class BlitPassData
	{
		public TextureHandle source; //Field offset: 0x10
		public TextureHandle destination; //Field offset: 0x20
		public Vector2 scale; //Field offset: 0x30
		public Vector2 offset; //Field offset: 0x38
		public int sourceSlice; //Field offset: 0x40
		public int destinationSlice; //Field offset: 0x44
		public int numSlices; //Field offset: 0x48
		public int sourceMip; //Field offset: 0x4C
		public int destinationMip; //Field offset: 0x50
		public int numMips; //Field offset: 0x54
		public BlitFilterMode filterMode; //Field offset: 0x58
		public bool isXR; //Field offset: 0x5C

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BlitPassData() { }

	}

	private class CopyPassData
	{
		public bool isMSAA; //Field offset: 0x10
		public bool force2DForXR; //Field offset: 0x11

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CopyPassData() { }

	}

	internal enum FullScreenGeometryType
	{
		Mesh = 0,
		ProceduralTriangle = 1,
		ProceduralQuad = 2,
	}

	private static MaterialPropertyBlock s_PropertyBlock; //Field offset: 0x0
	private const string DisableTexture2DXArray = "DISABLE_TEXTURE2D_X_ARRAY"; //Field offset: 0x0
	private static Vector4 s_BlitScaleBias; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderGraphUtils() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "IsTextureXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 34)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void AddBlitPass(RenderGraph graph, TextureHandle source, TextureHandle destination, Vector2 scale, Vector2 offset, int sourceSlice = 0, int destinationSlice = 0, int numSlices = -1, int sourceMip = 0, int destinationMip = 0, int numMips = 1, BlitFilterMode filterMode = 1, string passName = "Blit Pass Utility", string file = "", int line = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraphUtils), Member = "IsTextureXR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 62)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void AddBlitPass(RenderGraph graph, BlitMaterialParameters blitParameters, string passName = "Blit Pass Utility w. Material", string file = "", int line = 0) { }

	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(int), typeof(int), typeof(int), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "BlitToDebugTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "GetTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(Blitter), Member = "CanCopyMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(TextureXR), Member = "get_useTexArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 37)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static void AddCopyPass(RenderGraph graph, TextureHandle source, TextureHandle destination, string passName = "Copy Pass Utility", string file = "", int line = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Extension]
	public static void AddCopyPass(RenderGraph graph, TextureHandle source, TextureHandle destination, int sourceSlice, int destinationSlice = 0, int sourceMip = 0, int destinationMip = 0, string passName = "Copy Pass Utility", string file = "", int line = 0) { }

	[CalledBy(Type = typeof(<>c), Member = "<AddBlitPass>b__20_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlitMaterialPassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(UnsafeCommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "DrawQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "DrawTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "DrawQuadMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void BlitMaterialRenderFunc(BlitMaterialPassData data, UnsafeGraphContext context) { }

	[CalledBy(Type = typeof(<>c), Member = "<AddBlitPass>b__14_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlitPassData), typeof(UnsafeGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(UnsafeCommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(float), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void BlitRenderFunc(BlitPassData data, UnsafeGraphContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blitter), Member = "CanCopyMSAA", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	public static bool CanAddCopyPassMSAA() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blitter), Member = "CanCopyMSAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	public static bool CanAddCopyPassMSAA(in TextureDesc sourceDesc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blitter), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CopyRenderFunc(CopyPassData data, RasterGraphContext rgContext) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsFramebufferFetchEmulationMSAASupportedOnCurrentPlatform() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal static bool IsFramebufferFetchEmulationSupportedOnCurrentPlatform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static bool IsFramebufferFetchSupportedOnCurrentPlatform(RenderGraph graph, in TextureHandle tex) { }

	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(BlitFilterMode), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(BlitMaterialParameters), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureXR), Member = "get_useTexArray", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsTextureXR(ref TextureDesc destDesc, int sourceSlice, int destinationSlice, int numSlices, int numMips) { }

}

