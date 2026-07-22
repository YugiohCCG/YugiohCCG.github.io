namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters>
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_CullingPlanes>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <m_LayerFarCullDistances>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	private const int k_MaximumCullingPlaneCount = 10; //Field offset: 0x0
	public static readonly int maximumCullingPlaneCount; //Field offset: 0x0
	private const int k_LayerCount = 32; //Field offset: 0x0
	private const int k_CullingJobCountUpperLimit = 16; //Field offset: 0x0
	private const int k_CullingJobCountLowerLimit = 1; //Field offset: 0x0
	public static readonly int layerCount; //Field offset: 0x4
	private LODParameters m_LODParameters; //Field offset: 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal <m_CullingPlanes>e__FixedBuffer m_CullingPlanes; //Field offset: 0x1C
	private int m_CullingPlaneCount; //Field offset: 0xBC
	private uint m_CullingMask; //Field offset: 0xC0
	private ulong m_SceneMask; //Field offset: 0xC8
	private ulong m_ViewID; //Field offset: 0xD0
	[FixedBuffer(typeof(float), 32)]
	internal <m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; //Field offset: 0xD8
	private int m_LayerCull; //Field offset: 0x158
	private Matrix4x4 m_CullingMatrix; //Field offset: 0x15C
	private Vector3 m_Origin; //Field offset: 0x19C
	private float m_ShadowDistance; //Field offset: 0x1A8
	private float m_ShadowNearPlaneOffset; //Field offset: 0x1AC
	private CullingOptions m_CullingOptions; //Field offset: 0x1B0
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; //Field offset: 0x1B4
	private CameraProperties m_CameraProperties; //Field offset: 0x1B8
	private float m_AccurateOcclusionThreshold; //Field offset: 0x59C
	private int m_MaximumPortalCullingJobs; //Field offset: 0x5A0
	private Matrix4x4 m_StereoViewMatrix; //Field offset: 0x5A4
	private Matrix4x4 m_StereoProjectionMatrix; //Field offset: 0x5E4
	private float m_StereoSeparationDistance; //Field offset: 0x624
	private int m_maximumVisibleLights; //Field offset: 0x628
	private bool m_ConservativeEnclosingSphere; //Field offset: 0x62C
	private int m_NumIterationsEnclosingSphere; //Field offset: 0x630

	public bool conservativeEnclosingSphere
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 7
	}

	public CullingOptions cullingOptions
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "AssignCullingParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ScriptableCullingParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPassCreateInfo"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 get { } //Length: 9
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "AssignCullingParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ScriptableCullingParameters)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPassCreateInfo"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		 set { } //Length: 7
	}

	public int cullingPlaneCount
	{
		[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "GetCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
		[CallerCount(Count = 1)]
		 get { } //Length: 9
	}

	public int maximumVisibleLights
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 set { } //Length: 7
	}

	public int numIterationsEnclosingSphere
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 7
	}

	public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 7
	}

	public float shadowDistance
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 9
	}

	public Matrix4x4 stereoProjectionMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 47
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 44
	}

	public float stereoSeparationDistance
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 9
	}

	public Matrix4x4 stereoViewMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 set { } //Length: 44
	}

	[CallerCount(Count = 0)]
	private static ScriptableCullingParameters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "GetLayerCullingDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "GetCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CameraProperties), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraProperties)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(ScriptableCullingParameters other) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "AssignCullingParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ScriptableCullingParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPassCreateInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public CullingOptions get_cullingOptions() { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "GetCullingPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Plane))]
	[CallerCount(Count = 1)]
	public int get_cullingPlaneCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public Matrix4x4 get_stereoProjectionMatrix() { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "get_cullingPlaneCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public Plane GetCullingPlane(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LODParameters), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CameraProperties), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ScriptableCullingParameters), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public float GetLayerCullingDistance(int layerIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_conservativeEnclosingSphere(bool value) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "AssignCullingParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ScriptableCullingParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPassCreateInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	public void set_cullingOptions(CullingOptions value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public void set_maximumVisibleLights(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_numIterationsEnclosingSphere(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_reflectionProbeSortingCriteria(ReflectionProbeSortingCriteria value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableCullingParameters&), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_shadowDistance(float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_stereoProjectionMatrix(Matrix4x4 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_stereoSeparationDistance(float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void set_stereoViewMatrix(Matrix4x4 value) { }

}

