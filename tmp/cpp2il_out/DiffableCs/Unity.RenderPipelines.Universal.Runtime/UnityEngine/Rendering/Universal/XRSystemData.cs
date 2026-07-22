namespace UnityEngine.Rendering.Universal;

[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)", False)]
public class XRSystemData : ScriptableObject
{
	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)", False)]
	[ReloadGroup]
	internal sealed class ShaderResources
	{
		[Reload("Shaders/XR/XROcclusionMesh.shader", Package::Root (1))]
		public Shader xrOcclusionMeshPS; //Field offset: 0x10
		[Reload("Shaders/XR/XRMirrorView.shader", Package::Root (1))]
		public Shader xrMirrorViewPS; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ShaderResources() { }

	}

	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)", False)]
	public ShaderResources shaders; //Field offset: 0x18

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XRSystemData() { }

}

