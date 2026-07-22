namespace UnityEngine.Rendering;

public struct DrawingSettings : IEquatable<DrawingSettings>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <shaderPassNames>e__FixedBuffer
	{
		public int FixedElementField; //Field offset: 0x0

	}

	public static readonly int maxShaderPasses; //Field offset: 0x0
	private SortingSettings m_SortingSettings; //Field offset: 0x0
	[FixedBuffer(typeof(int), 16)]
	internal <shaderPassNames>e__FixedBuffer shaderPassNames; //Field offset: 0x60
	private PerObjectData m_PerObjectData; //Field offset: 0xA0
	private DrawRendererFlags m_Flags; //Field offset: 0xA4
	private int m_OverrideShaderID; //Field offset: 0xA8
	private int m_OverrideShaderPassIndex; //Field offset: 0xAC
	private int m_OverrideMaterialInstanceId; //Field offset: 0xB0
	private int m_OverrideMaterialPassIndex; //Field offset: 0xB4
	private int m_fallbackMaterialInstanceId; //Field offset: 0xB8
	private int m_MainLightIndex; //Field offset: 0xBC
	private int m_UseSrpBatcher; //Field offset: 0xC0

	public bool enableDynamicBatching
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
		[CallerCount(Count = 4)]
		 set { } //Length: 31
	}

	public bool enableInstancing
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
		[CallerCount(Count = 4)]
		 set { } //Length: 31
	}

	public int mainLightIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Material overrideMaterial
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(DrawingSettings))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		 set { } //Length: 55
	}

	public int overrideMaterialPassIndex
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Shader overrideShader
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		 set { } //Length: 55
	}

	public int overrideShaderPassIndex
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public PerObjectData perObjectData
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	private static DrawingSettings() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = typeof(RendererListDesc), Member = "ConvertToParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListParams))]
	[CallerCount(Count = 6)]
	public DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	[CalledBy(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DrawingSettings), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings), typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RendererListParams), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DrawingSettings), Member = "GetShaderPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ShaderTagId))]
	[Calls(Type = typeof(SortingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortingSettings)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(DrawingSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortingSettings), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public ShaderTagId GetShaderPassName(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	public static bool op_Equality(DrawingSettings left, DrawingSettings right) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CallerCount(Count = 4)]
	public void set_enableDynamicBatching(bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CallerCount(Count = 4)]
	public void set_enableInstancing(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_mainLightIndex(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugRenderSetup", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	public void set_overrideMaterial(Material value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_overrideMaterialPassIndex(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalLightData", "PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	public void set_overrideShader(Shader value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_overrideShaderPassIndex(int value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_perObjectData(PerObjectData value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<ShaderTagId>", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = typeof(RendererListDesc), Member = "ConvertToParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListParams))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void SetShaderPassName(int index, ShaderTagId shaderPassName) { }

}

