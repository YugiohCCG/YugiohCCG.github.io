namespace UnityEngine.Rendering;

public struct RendererListParams : IEquatable<RendererListParams>
{
	public static readonly RendererListParams Invalid; //Field offset: 0x0
	public CullingResults cullingResults; //Field offset: 0x0
	public DrawingSettings drawSettings; //Field offset: 0x10
	public FilteringSettings filteringSettings; //Field offset: 0xD4
	public ShaderTagId tagName; //Field offset: 0xF4
	public bool isPassTagName; //Field offset: 0xF8
	public Nullable<NativeArray`1<ShaderTagId>> tagValues; //Field offset: 0x100
	public Nullable<NativeArray`1<RenderStateBlock>> stateBlocks; //Field offset: 0x118

	internal int numStateBlocks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		internal get { } //Length: 100
	}

	internal IntPtr stateBlocksPtr
	{
		[CalledBy(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 2)]
		internal get { } //Length: 145
	}

	internal IntPtr tagsValuePtr
	{
		[CalledBy(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 2)]
		internal get { } //Length: 145
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static RendererListParams() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(RendererListParams))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(RendererListParams))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = "CreateRenderListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(RendererListParams))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererList&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), "UnityEngine.Rendering.RenderGraphModule.RendererListHandle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass", Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(RendererListParams))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthOnlyPass", Member = "InitRendererListParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(RendererListParams))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	public RendererListParams(CullingResults cullingResults, DrawingSettings drawSettings, FilteringSettings filteringSettings) { }

	[CalledBy(Type = typeof(RendererListParams), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(bool))]
	public override bool Equals(RendererListParams other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RendererListParams), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	internal int get_numStateBlocks() { }

	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal IntPtr get_stateBlocksPtr() { }

	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal IntPtr get_tagsValuePtr() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortingSettings), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ScriptableRenderContext), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 70)]
	internal void Validate() { }

}

