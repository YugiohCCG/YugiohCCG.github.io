namespace UnityEngine.Rendering;

public struct SortingSettings : IEquatable<SortingSettings>
{
	private Matrix4x4 m_WorldToCameraMatrix; //Field offset: 0x0
	private Vector3 m_CameraPosition; //Field offset: 0x40
	private Vector3 m_CustomAxis; //Field offset: 0x4C
	private SortingCriteria m_Criteria; //Field offset: 0x58
	private DistanceMetric m_DistanceMetric; //Field offset: 0x5C

	public SortingCriteria criteria
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "GetDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "GetObjectMotionDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(DrawingSettings))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererParamsObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateDrawingSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShaderTagId), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(SortingCriteria)}, ReturnType = typeof(DrawingSettings))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public SortingSettings(Camera camera) { }

	[CalledBy(Type = typeof(DrawingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawingSettings)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SortingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(SortingSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortingSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortingSettings)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	public SortingCriteria get_criteria() { }

	[CalledBy(Type = typeof(DrawingSettings), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RendererListParams), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_criteria(SortingCriteria value) { }

}

