namespace UnityEngine.Rendering.Universal;

[Extension]
public static class LightExtensions
{

	[CalledBy(Type = typeof(DeferredLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilDirectionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilPointLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "RenderStencilSpotLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool), typeof(UniversalLightData), typeof(UniversalShadowData), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeferredLights), Member = "SetRenderingLayersMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Light), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "InitializeLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.VisibleLight>), typeof(int), typeof(bool), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(Vector4&), typeof(UInt32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static UniversalAdditionalLightData GetUniversalAdditionalLightData(Light light) { }

}

