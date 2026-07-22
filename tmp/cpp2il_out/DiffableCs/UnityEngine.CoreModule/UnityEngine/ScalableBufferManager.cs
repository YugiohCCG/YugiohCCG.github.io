namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/ScalableBufferManager.h")]
[StaticAccessor("ScalableBufferManager::GetInstance()", StaticAccessorType::Dot (0))]
public static class ScalableBufferManager
{

	public static float heightScaleFactor
	{
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetResolvedScale", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GlobalDynamicResolutionSettings", typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetScaledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "ApplyScalesOnSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	public static float widthScaleFactor
	{
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetResolvedScale", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GlobalDynamicResolutionSettings", typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetScaledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
		[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "ApplyScalesOnSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetResolvedScale", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GlobalDynamicResolutionSettings", typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetScaledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "ApplyScalesOnSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_heightScaleFactor() { }

	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetResolvedScale", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GlobalDynamicResolutionSettings", typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetScaledSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "ApplyScalesOnSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public static float get_widthScaleFactor() { }

	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "FlushScalableBufferManagerState", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void ResizeBuffers(float widthScale, float heightScale) { }

}

