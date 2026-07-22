namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: 2D Renderer", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
internal class Renderer2DResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x10
	[ResourcePath("Shaders/2D/Light2D.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_LightShader; //Field offset: 0x18
	[ResourcePath("Shaders/2D/Shadow2D-Projected.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_ProjectedShadowShader; //Field offset: 0x20
	[ResourcePath("Shaders/2D/Shadow2D-Shadow-Sprite.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_SpriteShadowShader; //Field offset: 0x28
	[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_SpriteUnshadowShader; //Field offset: 0x30
	[ResourcePath("Shaders/2D/Shadow2D-Shadow-Geometry.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_GeometryShadowShader; //Field offset: 0x38
	[ResourcePath("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_GeometryUnshadowShader; //Field offset: 0x40
	[HideInInspector]
	[ResourcePath("Runtime/2D/Data/Textures/FalloffLookupTexture.png", SearchType::ProjectPath (0))]
	[SerializeField]
	private Texture2D m_FallOffLookup; //Field offset: 0x48
	[ResourcePath("Shaders/Utils/CopyDepth.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_CopyDepthPS; //Field offset: 0x50

	internal Shader copyDepthPS
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Texture2D fallOffLookup
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader geometryShadowShader
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader geometryUnshadowShader
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader lightShader
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader projectedShadowShader
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader spriteShadowShader
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	internal Shader spriteUnshadowShader
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
		internal set { } //Length: 101
	}

	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	public override int version
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Renderer2DResources() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal Shader get_copyDepthPS() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal Texture2D get_fallOffLookup() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal Shader get_geometryShadowShader() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Shader get_geometryUnshadowShader() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Shader get_lightShader() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Shader get_projectedShadowShader() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal Shader get_spriteShadowShader() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal Shader get_spriteUnshadowShader() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_copyDepthPS(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_fallOffLookup(Texture2D value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_geometryShadowShader(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_geometryUnshadowShader(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_lightShader(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_projectedShadowShader(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_spriteShadowShader(Shader value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderPipelineGraphicsSettingsExtensions), Member = "SetValueAndNotify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IRenderPipelineGraphicsSettings), "T&", "T", typeof(string)}, ReturnType = typeof(void))]
	internal void set_spriteUnshadowShader(Shader value) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

