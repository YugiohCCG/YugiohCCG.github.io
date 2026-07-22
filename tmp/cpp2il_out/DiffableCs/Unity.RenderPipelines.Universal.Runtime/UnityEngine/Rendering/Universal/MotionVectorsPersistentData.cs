namespace UnityEngine.Rendering.Universal;

internal sealed class MotionVectorsPersistentData
{
	private const int k_EyeCount = 2; //Field offset: 0x0
	private readonly Matrix4x4[] m_Projection; //Field offset: 0x10
	private readonly Matrix4x4[] m_View; //Field offset: 0x18
	private readonly Matrix4x4[] m_ViewProjection; //Field offset: 0x20
	private readonly Matrix4x4[] m_PreviousProjection; //Field offset: 0x28
	private readonly Matrix4x4[] m_PreviousView; //Field offset: 0x30
	private readonly Matrix4x4[] m_PreviousViewProjection; //Field offset: 0x38
	private readonly Matrix4x4[] m_PreviousPreviousProjection; //Field offset: 0x40
	private readonly Matrix4x4[] m_PreviousPreviousView; //Field offset: 0x48
	private readonly Int32[] m_LastFrameIndex; //Field offset: 0x50
	private readonly Single[] m_PrevAspectRatio; //Field offset: 0x58
	private float m_deltaTime; //Field offset: 0x60
	private float m_lastDeltaTime; //Field offset: 0x64
	private Vector3 m_worldSpaceCameraPos; //Field offset: 0x68
	private Vector3 m_previousWorldSpaceCameraPos; //Field offset: 0x74
	private Vector3 m_previousPreviousWorldSpaceCameraPos; //Field offset: 0x80

	internal float deltaTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal float lastDeltaTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal int lastFrameIndex
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 38
	}

	internal Matrix4x4[] previousPreviousProjectionStereo
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Matrix4x4[] previousPreviousViewStereo
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	internal Vector3 previousPreviousWorldSpaceCameraPos
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 25
	}

	internal Matrix4x4[] previousProjectionStereo
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Matrix4x4 previousViewProjection
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 69
	}

	internal Matrix4x4[] previousViewProjectionStereo
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Matrix4x4[] previousViewStereo
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Vector3 previousWorldSpaceCameraPos
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 19
	}

	internal Matrix4x4[] projectionStereo
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Matrix4x4 viewProjection
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 69
	}

	internal Matrix4x4[] viewProjectionStereo
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Matrix4x4[] viewStereo
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal Vector3 worldSpaceCameraPos
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 19
	}

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MotionVectorsPersistentData), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal MotionVectorsPersistentData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal float get_deltaTime() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal float get_lastDeltaTime() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int get_lastFrameIndex() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_previousPreviousProjectionStereo() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_previousPreviousViewStereo() { }

	[CallerCount(Count = 0)]
	internal Vector3 get_previousPreviousWorldSpaceCameraPos() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_previousProjectionStereo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal Matrix4x4 get_previousViewProjection() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_previousViewProjectionStereo() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_previousViewStereo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Vector3 get_previousWorldSpaceCameraPos() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_projectionStereo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal Matrix4x4 get_viewProjection() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_viewProjectionStereo() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Matrix4x4[] get_viewStereo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal Vector3 get_worldSpaceCameraPos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static int GetXRMultiPassId(XRPass xr) { }

	[CalledBy(Type = typeof(MotionVectorsPersistentData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "set_resetHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass+<>c", Member = "<SetRenderGraphMotionVectorGlobalMatrices>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionMatrixPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionVectorRenderPass), Member = "SetMotionVectorGlobalMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void SetGlobalMotionMatrices(RasterCommandBuffer cmd, XRPass xr) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRPass), Member = "GetProjMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Update(UniversalCameraData cameraData) { }

}

