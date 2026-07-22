namespace UnityEngine.Rendering;

public static class XRGraphicsAutomatedTests
{
	[CompilerGenerated]
	private static bool <enabled>k__BackingField; //Field offset: 0x0
	public static bool running; //Field offset: 0x1

	private static bool activatedFromCommandLine
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	public static bool enabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	private static XRGraphicsAutomatedTests() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private static bool get_activatedFromCommandLine() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_enabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "AssignCullingParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ScriptableCullingParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "GetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "Frustum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FrustumPlanes)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_decomposeProjection", ReturnType = typeof(FrustumPlanes))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRPass), Member = "AssignView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XRView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_stereoSeparationDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_stereoViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableCullingParameters), Member = "set_stereoProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "GetTextureArraySlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XRView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(bool), typeof(Rect), typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static void OverrideLayout(XRLayout layout, Camera camera) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_enabled(bool value) { }

}

