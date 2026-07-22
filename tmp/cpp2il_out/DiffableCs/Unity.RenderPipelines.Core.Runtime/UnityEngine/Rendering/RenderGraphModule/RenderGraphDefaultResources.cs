namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public class RenderGraphDefaultResources
{
	private RTHandle m_BlackTexture2D; //Field offset: 0x10
	private RTHandle m_WhiteTexture2D; //Field offset: 0x18
	private RTHandle m_ShadowTexture2D; //Field offset: 0x20
	[CompilerGenerated]
	private TextureHandle <blackTexture>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private TextureHandle <whiteTexture>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private TextureHandle <clearTextureXR>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private TextureHandle <magentaTextureXR>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private TextureHandle <blackTextureXR>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private TextureHandle <blackTextureArrayXR>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private TextureHandle <blackUIntTextureXR>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private TextureHandle <blackTexture3DXR>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private TextureHandle <whiteTextureXR>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private TextureHandle <defaultShadowTexture>k__BackingField; //Field offset: 0xB8

	public private TextureHandle blackTexture
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle blackTexture3DXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 11
	}

	public private TextureHandle blackTextureArrayXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle blackTextureXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle blackUIntTextureXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 11
	}

	public private TextureHandle clearTextureXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle defaultShadowTexture
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private TextureHandle magentaTextureXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle whiteTexture
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 8
	}

	public private TextureHandle whiteTextureXR
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 11
	}

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphDefaultResources), Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal RenderGraphDefaultResources() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void Cleanup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_blackTexture() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_blackTexture3DXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_blackTextureArrayXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_blackTextureXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_blackUIntTextureXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_clearTextureXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public TextureHandle get_defaultShadowTexture() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_magentaTextureXR() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_whiteTexture() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public TextureHandle get_whiteTextureXR() { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "get_blackTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 3)]
	private void InitDefaultResourcesIfNeeded() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphDefaultResources), Member = "InitDefaultResourcesIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(TextureXR), Member = "GetClearTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(TextureXR), Member = "GetMagentaTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(TextureXR), Member = "GetBlackTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(TextureXR), Member = "GetBlackUIntTexture", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(TextureXR), Member = "GetWhiteTexture", ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal void InitializeForRendering(RenderGraph renderGraph) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_blackTexture(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_blackTexture3DXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_blackTextureArrayXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_blackTextureXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_blackUIntTextureXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_clearTextureXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_defaultShadowTexture(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_magentaTextureXR(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_whiteTexture(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_whiteTextureXR(TextureHandle value) { }

}

