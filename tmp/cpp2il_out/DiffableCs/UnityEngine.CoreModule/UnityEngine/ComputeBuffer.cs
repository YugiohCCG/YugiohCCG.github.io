namespace UnityEngine;

[NativeClass("GraphicsBuffer")]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class ComputeBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(ComputeBuffer computeBuffer) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public int count
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.DebugOverlay"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderData", Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureProbeBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 82
	}

	public int stride
	{
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "SetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "DispatchDebugClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.OcclusionTestComputeShader&", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOcclusionTestOverlay>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OcclusionTestOverlaySetupPassData", "UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OccluderParameters&", "System.ReadOnlySpan`1<OccluderSubviewUpdate>", "UnityEngine.Rendering.OccluderHandles&", "Unity.Collections.NativeArray`1<Plane>", typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.IndirectBufferContextHandles&", "UnityEngine.Rendering.OccluderHandles&", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CBType&", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "SetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 82
	}

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "UpdateDebugData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeGlobalIndirection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int), typeof(Vector3Int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeConstantRuntimeResources", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderData", Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType), typeof(ComputeBufferMode), typeof(int)}, ReturnType = typeof(void))]
	public ComputeBuffer(int count, int stride) { }

	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBufferSingleton`1", Member = "get_instance", ReturnType = "UnityEngine.Rendering.ConstantBufferSingleton`1<CBType>")]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBufferSingleton`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "BindAPVRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", "UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+GPUResources", Member = "CreateResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureProbeBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "AllocateTexturesIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType), typeof(ComputeBufferMode), typeof(int)}, ReturnType = typeof(void))]
	public ComputeBuffer(int count, int stride, ComputeBufferType type) { }

	[CalledBy(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsBuffer_Bindings::DestroyComputeBuffer")]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DestroyBuffer_Injected(IntPtr buf) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.DebugOverlay"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShaderData", Member = "GetOrUpdateBuffer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer&), typeof(int)}, ReturnType = typeof(ComputeBuffer))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureProbeBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_count() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_count_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "SetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "SetGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.IndirectBufferContextHandles&", "UnityEngine.Rendering.OccluderHandles&", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OccluderParameters&", "System.ReadOnlySpan`1<OccluderSubviewUpdate>", "UnityEngine.Rendering.OccluderHandles&", "Unity.Collections.NativeArray`1<Plane>", typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon+<>c", Member = "<RenderDebugOcclusionTestOverlay>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.OcclusionCullingCommon+OcclusionTestOverlaySetupPassData", "UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OccluderContext&", "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.OcclusionTestComputeShader&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "DispatchDebugClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_stride() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_stride_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Release() { }

	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CBType&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "UpdateDebugData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeGlobalIndirection", Member = "PushComputeData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeGlobalIndirection", Member = "GetRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RuntimeResources&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeConstantRuntimeResources", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Upload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "SetShadowParamsForEmptyShadowmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "SetupAdditionalLightsShadowReceiverConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Vector2Int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnsafeUtility), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void SetData(Array data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "InternalSetNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetData(NativeArray<T> data) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "UploadIndexData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "GetRuntimeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RuntimeResources&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer", "Unity.Collections.NativeArray`1<GPUInstanceIndex>", "GPUResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchTransformUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<TransformUpdatePacket>", "Unity.Collections.NativeArray`1<float4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchWindDataCopyHistoryCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<GPUInstanceIndex>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ComputeBuffer), Member = "InternalSetNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetData(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }

}

