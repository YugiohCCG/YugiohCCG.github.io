namespace UnityEngine.Rendering.RendererUtils;

public struct RendererListDesc
{
	private static readonly ShaderTagId s_EmptyName; //Field offset: 0x0
	public SortingCriteria sortingCriteria; //Field offset: 0x0
	public PerObjectData rendererConfiguration; //Field offset: 0x4
	public RenderQueueRange renderQueueRange; //Field offset: 0x8
	public Nullable<RenderStateBlock> stateBlock; //Field offset: 0x10
	public Shader overrideShader; //Field offset: 0x80
	public Material overrideMaterial; //Field offset: 0x88
	public bool excludeObjectMotionVectors; //Field offset: 0x90
	public int layerMask; //Field offset: 0x94
	public uint renderingLayerMask; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private uint <batchLayerMask>k__BackingField; //Field offset: 0x9C
	public int overrideMaterialPassIndex; //Field offset: 0xA0
	public int overrideShaderPassIndex; //Field offset: 0xA4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private CullingResults <cullingResult>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Camera <camera>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ShaderTagId <passName>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ShaderTagId[] <passNames>k__BackingField; //Field offset: 0xC8

	public uint batchLayerMask
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 7
	}

	internal Camera camera
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 8
	}

	internal CullingResults cullingResult
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 14
	}

	internal ShaderTagId passName
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 7
	}

	internal ShaderTagId[] passNames
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	private static RendererListDesc() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.RendererListHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RendererListDesc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawingSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), typeof(SortingSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawingSettings), Member = "SetShaderPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ShaderTagId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderQueueRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderQueueRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Nullable`1<UnityEngine.Rendering.RenderStateBlock>), Member = "get_Value", ReturnType = typeof(RenderStateBlock))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public static RendererListParams ConvertToParameters(in RendererListDesc desc) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public uint get_batchLayerMask() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal Camera get_camera() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal CullingResults get_cullingResult() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal ShaderTagId get_passName() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal ShaderTagId[] get_passNames() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", Member = "ValidateRendererListDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RendererListDesc), Member = "ConvertToParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListParams))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsValid() { }

}

