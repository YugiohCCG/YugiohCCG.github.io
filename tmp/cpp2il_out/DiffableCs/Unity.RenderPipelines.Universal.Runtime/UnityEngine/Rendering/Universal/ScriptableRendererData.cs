namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRendererData : ScriptableObject
{
	[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)", False)]
	[ReloadGroup]
	internal sealed class DebugShaderResources
	{
		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)", False)]
		[Reload("Shaders/Debug/DebugReplacement.shader", Package::Root (1))]
		public Shader debugReplacementPS; //Field offset: 0x10
		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)", False)]
		[Reload("Shaders/Debug/HDRDebugView.shader", Package::Root (1))]
		public Shader hdrDebugViewPS; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DebugShaderResources() { }

	}

	[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class.")]
	[ReloadGroup]
	internal sealed class ProbeVolumeResources
	{
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Shader probeVolumeDebugShader; //Field offset: 0x10
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Shader probeVolumeFragmentationDebugShader; //Field offset: 0x18
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Shader probeVolumeOffsetDebugShader; //Field offset: 0x20
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Shader probeVolumeSamplingDebugShader; //Field offset: 0x28
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Mesh probeSamplingDebugMesh; //Field offset: 0x30
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class.")]
		public Texture2D probeSamplingDebugTexture; //Field offset: 0x38
		[Obsolete("This shader is now in the ProbeVolumeRuntimeResources class.")]
		public ComputeShader probeVolumeBlendStatesCS; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ProbeVolumeResources() { }

	}

	[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)", False)]
	public DebugShaderResources debugShaders; //Field offset: 0x18
	[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class.")]
	public ProbeVolumeResources probeVolumeResources; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isInvalidated>k__BackingField; //Field offset: 0x28
	[SerializeField]
	internal List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x30
	[SerializeField]
	internal List<Int64> m_RendererFeatureMap; //Field offset: 0x38
	[SerializeField]
	private bool m_UseNativeRenderPass; //Field offset: 0x40
	private bool m_StripShadowsOffVariants; //Field offset: 0x41
	private bool m_StripAdditionalLightOffVariants; //Field offset: 0x42

	internal bool isInvalidated
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public List<ScriptableRendererFeature> rendererFeatures
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal override bool stripAdditionalLightOffVariants
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal override bool stripShadowsOffVariants
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public bool useNativeRenderPass
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 8
	}

	[CalledBy(Type = typeof(UniversalRendererData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardRendererData), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected ScriptableRendererData() { }

	protected abstract ScriptableRenderer Create() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_isInvalidated() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public List<ScriptableRendererFeature> get_rendererFeatures() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override bool get_stripAdditionalLightOffVariants() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override bool get_stripShadowsOffVariants() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public bool get_useNativeRenderPass() { }

	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "CreateRenderers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "get_scriptableRenderer", ReturnType = typeof(ScriptableRenderer))]
	[CalledBy(Type = typeof(UniversalRenderPipelineAsset), Member = "GetRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ScriptableRenderer))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ScriptableRenderer InternalCreateRenderer() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnEnable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnValidate() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_isInvalidated(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override void set_stripAdditionalLightOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal override void set_stripShadowsOffVariants(bool value) { }

	[CallerCount(Count = 0)]
	public void set_useNativeRenderPass(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetDirty() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public bool TryGetRendererFeature(out T rendererFeature) { }

}

