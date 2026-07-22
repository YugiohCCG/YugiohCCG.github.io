namespace UnityEngine.Rendering;

public abstract class RenderPipelineAsset : ScriptableObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <requiresCompatibleRenderPipelineGlobalSettings>k__BackingField; //Field offset: 0x18

	public override Shader autodeskInteractiveMaskedShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader autodeskInteractiveShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader autodeskInteractiveTransparentShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material default2DMaskMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material default2DMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultLineMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultParticleMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader defaultShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader defaultSpeedTree7Shader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader defaultSpeedTree8Shader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader defaultSpeedTree9Shader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultTerrainMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultUIETC1SupportedMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultUIMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Material defaultUIOverdrawMaterial
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Type pipelineType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 86
	}

	internal string pipelineTypeFullName
	{
		[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal get { } //Length: 72
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public override String[] prefixedRenderingLayerMaskNames
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public override String[] renderingLayerMaskNames
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string renderPipelineShaderTag
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		 get { } //Length: 101
	}

	[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", False)]
	protected private override Type renderPipelineType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		private get { } //Length: 86
	}

	protected private override bool requiresCompatibleRenderPipelineGlobalSettings
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public override Shader terrainDetailGrassBillboardShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader terrainDetailGrassShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override Shader terrainDetailLitShader
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CalledBy(Type = typeof(RenderPipelineAsset`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	protected RenderPipelineAsset() { }

	protected abstract RenderPipeline CreatePipeline() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void EnsureGlobalSettings() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_autodeskInteractiveMaskedShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_autodeskInteractiveShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_autodeskInteractiveTransparentShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_default2DMaskMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_default2DMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultLineMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultParticleMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_defaultShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_defaultSpeedTree7Shader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_defaultSpeedTree8Shader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_defaultSpeedTree9Shader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultTerrainMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultUIETC1SupportedMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultUIMaterial() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Material get_defaultUIOverdrawMaterial() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override Type get_pipelineType() { }

	[CalledBy(Type = typeof(GraphicsSettings), Member = "Internal_GetCurrentRenderPipelineGlobalSettings", ReturnType = typeof(RenderPipelineGlobalSettings))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal string get_pipelineTypeFullName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override String[] get_prefixedRenderingLayerMaskNames() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override String[] get_renderingLayerMaskNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override string get_renderPipelineShaderTag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected private override Type get_renderPipelineType() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected private override bool get_requiresCompatibleRenderPipelineGlobalSettings() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_terrainDetailGrassBillboardShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_terrainDetailGrassShader() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override Shader get_terrainDetailLitShader() { }

	[CalledBy(Type = typeof(RenderPipelineManager), Member = "TryPrepareRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal RenderPipeline InternalCreatePipeline() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderPipelineManager), Member = "CleanupRenderPipeline", ReturnType = typeof(void))]
	protected override void OnDisable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	protected override void OnValidate() { }

}

