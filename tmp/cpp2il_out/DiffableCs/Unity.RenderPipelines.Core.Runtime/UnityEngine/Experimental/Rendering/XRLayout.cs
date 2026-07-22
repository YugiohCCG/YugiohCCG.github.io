namespace UnityEngine.Experimental.Rendering;

public class XRLayout
{
	private readonly List<ValueTuple`2<Camera, XRPass>> m_ActivePasses; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public XRLayout() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_cameraType", ReturnType = typeof(CameraType))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRLayout), Member = "AddPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_zNear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRDisplaySubsystem), Member = "set_zFar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSystem), Member = "CreateDefaultLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRLayout)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddCamera(Camera camera, bool enableXR) { }

	[CalledBy(Type = typeof(XRLayout), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRSystem), Member = "CreateDefaultLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRLayout)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "UpdateCombinedMesh", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void AddPass(Camera camera, XRPass xrPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public List<ValueTuple`2<Camera, XRPass>> GetActivePasses() { }

	[CalledBy(Type = typeof(XRSystem), Member = "EndLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(XRSystem), Member = "get_displayActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(XRPass), Member = "GetTextureArraySlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	internal void LogDebugInfo() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRSystem), Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XROcclusionMesh), Member = "UpdateCombinedMesh", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ReconfigurePass(XRPass xrPass, Camera camera) { }

}

