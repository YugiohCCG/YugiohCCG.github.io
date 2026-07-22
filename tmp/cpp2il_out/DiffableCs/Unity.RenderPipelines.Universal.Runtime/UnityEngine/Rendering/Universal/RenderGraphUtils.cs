namespace UnityEngine.Rendering.Universal;

internal static class RenderGraphUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__6_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <SetGlobalTexture>b__6_0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal TextureHandle texture; //Field offset: 0x10
		internal int nameID; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PassData() { }

	}

	private static ProfilingSampler s_SetGlobalTextureProfilingSampler; //Field offset: 0x0
	internal const int GBufferSize = 7; //Field offset: 0x0
	internal const int DBufferSize = 3; //Field offset: 0x0
	internal const int LightTextureSize = 4; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderGraphUtils() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetRenderingLayersGlobalTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public static void SetGlobalTexture(RenderGraph graph, int nameId, TextureHandle handle, string passName = "Set Global Texture", string file = "", int line = 0) { }

	[CalledBy(Type = typeof(DrawObjectsPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DrawObjectsWithRenderingLayersPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(MaskSize), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GBufferPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_dBuffer", ReturnType = typeof(TextureHandle[]))]
	[CallsUnknownMethods(Count = 3)]
	internal static void UseDBufferIfValid(IRasterRenderGraphBuilder builder, UniversalResourceData resourceData) { }

}

