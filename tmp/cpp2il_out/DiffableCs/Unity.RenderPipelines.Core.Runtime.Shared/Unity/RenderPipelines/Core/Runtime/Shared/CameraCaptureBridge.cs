namespace Unity.RenderPipelines.Core.Runtime.Shared;

internal static class CameraCaptureBridge
{

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraCaptureBridge), Member = "GetCachedCaptureActionsEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Action`2<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>>))]
	public static IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> GetCachedCaptureActionsEnumerator(Camera camera) { }

}

