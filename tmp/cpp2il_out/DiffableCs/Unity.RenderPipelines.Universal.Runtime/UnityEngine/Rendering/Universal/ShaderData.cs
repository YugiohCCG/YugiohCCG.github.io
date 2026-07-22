namespace UnityEngine.Rendering.Universal;

internal class ShaderData : IDisposable
{
	private static ShaderData m_Instance; //Field offset: 0x0
	private ComputeBuffer m_LightDataBuffer; //Field offset: 0x10
	private ComputeBuffer m_LightIndicesBuffer; //Field offset: 0x18
	private ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer; //Field offset: 0x20
	private ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer; //Field offset: 0x28

	internal static ShaderData instance
	{
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 141
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private ShaderData() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeBuffer(ref ComputeBuffer buffer) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static ShaderData get_instance() { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShaderData), Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	internal ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size) { }

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderData), Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	internal ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderData), Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	internal ComputeBuffer GetLightDataBuffer(int size) { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupAdditionalLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(CullingResults&), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForwardLights), Member = "SetupPerObjectLightIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults), typeof(UniversalLightData)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ShaderData), Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	internal ComputeBuffer GetLightIndicesBuffer(int size) { }

	[CalledBy(Type = typeof(ShaderData), Member = "GetLightDataBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CalledBy(Type = typeof(ShaderData), Member = "GetLightIndicesBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CalledBy(Type = typeof(ShaderData), Member = "GetAdditionalLightShadowParamsStructuredBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CalledBy(Type = typeof(ShaderData), Member = "GetAdditionalLightShadowSliceMatricesStructuredBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private ComputeBuffer GetOrUpdateBuffer(ref ComputeBuffer buffer, int size) { }

}

