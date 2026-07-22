namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[UsedByNativeCode]
public class CommandBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(CommandBuffer commandBuffer) { }

	}

	public static bool ThrowOnSetRenderTarget; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10

	public string name
	{
		[CalledBy(Type = "UnityEngine.Rendering.BaseCommandBuffer", Member = "get_name", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 163
		[CalledBy(Type = "UnityEngine.Rendering.CommandBufferPool", Member = "Get", ReturnType = typeof(CommandBuffer))]
		[CalledBy(Type = "UnityEngine.Rendering.CommandBufferPool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CommandBuffer))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", "UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", typeof(GPUDrivenProcessor), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 391
	}

	public int sizeInBytes
	{
		[CalledBy(Type = "UnityEngine.Rendering.BaseCommandBuffer", Member = "get_sizeInBytes", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetBufferSize")]
		 get { } //Length: 82
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", "UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", typeof(GPUDrivenProcessor), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CommandBuffer() { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void BeginRenderPass(int width, int height, int volumeDepth, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex, NativeArray<SubPassDescriptor> subPasses, ReadOnlySpan<Byte> debugNameUtf8) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginRenderPass", HasExplicitThis = True)]
	private void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, ReadOnlySpan<AttachmentDescriptor> attachments, int depthAttachmentIndex, ReadOnlySpan<SubPassDescriptor> subPasses, ReadOnlySpan<Byte> debugNameUtf8) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BeginRenderPass_Internal_Injected(IntPtr _unity_self, int width, int height, int volumeDepth, int samples, ref ManagedSpanWrapper attachments, int depthAttachmentIndex, ref ManagedSpanWrapper subPasses, ref ManagedSpanWrapper debugNameUtf8) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void BeginSample(CustomSampler sampler) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSample", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(string), typeof(CustomSampler)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSample", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSample", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(string), "System.Object[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	public void BeginSample(string name) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = True)]
	private void BeginSample_CustomSampler(CustomSampler sampler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BeginSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void BeginSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2DArray), Member = "get_allSlices", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2DArray), Member = "get_allSlices", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = True)]
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Blit_Identifier_Injected(IntPtr _unity_self, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = True)]
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "BuildRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "BuildRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "BuildRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "BuildRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void CheckThrowOnSetRenderTarget() { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("ClearCommands")]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Clear_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteCIExyPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataCIExy", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = True, ThrowsException = True)]
	public void ClearRandomWriteTargets() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearRandomWriteTargets_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTClearFlags), "UnityEngine.Color[]", typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTClearFlags), "UnityEngine.Color[]", typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth = 1, uint stencil = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ClearRenderTargetMulti_Internal(RTClearFlags clearFlags, Color[] colors, float depth, uint stencil) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearRenderTargetMulti_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, ref ManagedSpanWrapper colors, float depth, uint stencil) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, uint stencil) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, in Color color, float depth, uint stencil) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "BeginXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "EndXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.CameraData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = True)]
	public void ConfigureFoveatedRendering(IntPtr platformData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ConfigureFoveatedRendering_Injected(IntPtr _unity_self, IntPtr platformData) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeMethod("AddCopyCounterValue")]
	private void CopyCounterValueCC(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyCounterValueCC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeMethod("AddCopyCounterValue")]
	private void CopyCounterValueCG(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyCounterValueCG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeMethod("AddCopyCounterValue")]
	private void CopyCounterValueGC(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyCounterValueGC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeMethod("AddCopyCounterValue")]
	private void CopyCounterValueGG(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyCounterValueGG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = True)]
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyTexture_Internal_Injected(IntPtr _unity_self, ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphicsFence), Member = "InitPostAllocation", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public GraphicsFence CreateAsyncGraphicsFence() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = True)]
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateGPUFence_Internal_Injected(IntPtr _unity_self, GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsFence), Member = "InitPostAllocation", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableComputeKeyword", HasExplicitThis = True)]
	private void DisableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	private void DisableGlobalKeyword(GlobalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBuffer", "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBufferLayout", "System.Collections.Generic.List`1<BrickChunkAlloc>", typeof(bool), typeof(Texture), "UnityEngine.Rendering.ProbeVolumeSHBands", typeof(bool), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableMaterialKeyword", HasExplicitThis = True)]
	private void DisableMaterialKeyword(Material material, LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DisableScissorRect", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DisableScissorRect", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DisableScissorRect", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	public void DisableScissorRect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableScissorRect_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.BaseCommandBuffer", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MaterialQualityUtilities", Member = "SetGlobalShaderKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.MaterialQuality", typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	public void DisableShaderKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DispatchCompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(ComputeBuffer), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DispatchCompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(ComputeBuffer), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DispatchCompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(GraphicsBuffer), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DispatchCompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(GraphicsBuffer), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum", Member = "ExecuteCommonIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), "SupportResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "DispatchRays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(uint), typeof(uint), typeof(uint), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DispatchRays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(uint), typeof(uint), typeof(uint), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_DispatchRays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(uint), typeof(uint), typeof(uint), typeof(Camera)}, ReturnType = typeof(void))]
	public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera = null) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawQuadMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]", typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]", typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = "get_enableInstancing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 43)]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 34)]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 34)]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMeshInstancedProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMeshInstancedProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawMultipleMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Matrix4x4[]", "UnityEngine.Mesh[]", "System.Int32[]", typeof(int), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawMultipleMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Matrix4x4[]", "UnityEngine.Mesh[]", "System.Int32[]", typeof(int), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_DrawMultipleMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4[]), typeof(Mesh[]), typeof(Int32[]), typeof(int), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ExcludeFromDocs]
	public void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ExcludeFromDocs]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ExcludeFromDocs]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(Material), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+<>c", Member = "<RenderFragmentationOverlay>b__45_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+RenderFragmentationOverlayPassData", "UnityEngine.Rendering.RenderGraphModule.RenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "DrawQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(CommandBuffer), typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void DrawRendererList(RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableComputeKeyword", HasExplicitThis = True)]
	private void EnableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	private void EnableGlobalKeyword(GlobalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBuffer", "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBufferLayout", "System.Collections.Generic.List`1<BrickChunkAlloc>", typeof(bool), typeof(Texture), "UnityEngine.Rendering.ProbeVolumeSHBands", typeof(bool), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableMaterialKeyword", HasExplicitThis = True)]
	private void EnableMaterialKeyword(Material material, LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EnableScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EnableScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EnableScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	public void EnableScissorRect(Rect scissor) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableScissorRect_Injected(IntPtr _unity_self, in Rect scissor) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.BaseCommandBuffer", typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MaterialQualityUtilities", Member = "SetGlobalShaderKeywords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.MaterialQuality", typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	public void EnableShaderKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void EndRenderPass() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndRenderPass", HasExplicitThis = True)]
	private void EndRenderPass_Internal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndRenderPass_Internal_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void EndSample(CustomSampler sampler) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSample", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSample", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	public void EndSample(string name) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = True)]
	private void EndSample_CustomSampler(CustomSampler sampler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.BaseCommandBuffer", Member = "get_name", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_name_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.BaseCommandBuffer", Member = "get_sizeInBytes", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetBufferSize")]
	public int get_sizeInBytes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_sizeInBytes_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "IncrementUpdateCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "IncrementUpdateCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "IncrementUpdateCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::IncrementUpdateCount", HasExplicitThis = True)]
	public void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IncrementUpdateCount_Injected(IntPtr _unity_self, in RenderTargetIdentifier dest) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_BuildRayTracingAccelerationStructure", HasExplicitThis = True)]
	private void Internal_BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_BuildRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr accelerationStructure, in BuildSettings buildSettings) { }

	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DispatchCompute_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchComputeIndirect(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DispatchComputeIndirect_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchComputeIndirectGraphicsBuffer(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "DispatchRays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(uint), typeof(uint), typeof(uint), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchRays", HasExplicitThis = True, ThrowsException = True)]
	private void Internal_DispatchRays(RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, Camera camera = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DispatchRays_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, IntPtr camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, in Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = True)]
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMeshInstanced_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, ref ManagedSpanWrapper matrices, int count, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = True)]
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMeshInstancedIndirect_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = True)]
	private void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedProcedural", HasExplicitThis = True)]
	private void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMeshInstancedProcedural_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, int count, IntPtr properties) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMultipleMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4[]), typeof(Mesh[]), typeof(Int32[]), typeof(int), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("AddDrawMultipleMeshes")]
	private void Internal_DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawMultipleMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper matrices, Mesh[] meshes, ref ManagedSpanWrapper subsetIndices, int count, IntPtr material, int shaderPass, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = True)]
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawOcclusionMesh_Injected(IntPtr _unity_self, in RectInt normalizedCamViewport) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("AddDrawProcedural")]
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProcedural_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("AddDrawProceduralIndexed")]
	private void Internal_DrawProceduralIndexed(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProceduralIndexed_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = True)]
	private void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProceduralIndexedIndirect_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = True)]
	private void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = True)]
	private void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProceduralIndirect_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = True)]
	private void Internal_DrawProceduralIndirectGraphicsBuffer(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("AddDrawRenderer")]
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawRenderer_Injected(IntPtr _unity_self, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddDrawRendererList")]
	private void Internal_DrawRendererList(RendererList rendererList) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_DrawRendererList_Injected(IntPtr _unity_self, in RendererList rendererList) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(ComputeBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_1(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_1_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(ComputeBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_2(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_2_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_3(Texture src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_3_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_4(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_4_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_5(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_5_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_6(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_6_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_7(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_7_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(GraphicsBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_8(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_8_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(GraphicsBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddRequestAsyncReadback")]
	private void Internal_RequestAsyncReadback_9(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_RequestAsyncReadback_9_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeConstantGraphicsBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = True)]
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, Single[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeFloats_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeGraphicsBufferHandleParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, in GraphicsBufferHandle bufferHandle) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	private void Internal_SetComputeGraphicsBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeInts", HasExplicitThis = True)]
	private void Internal_SetComputeInts(ComputeShader computeShader, int nameID, Int32[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeInts_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeRayTracingAccelerationStructure", HasExplicitThis = True)]
	private void Internal_SetComputeRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr accelerationStructure) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetComputeTextureParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingAccelerationStructure", HasExplicitThis = True)]
	private void Internal_SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr accelerationStructure) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingComputeBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingConstantComputeBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingConstantGraphicsBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloatParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingFloatParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, float val) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloats", HasExplicitThis = True)]
	private void Internal_SetRayTracingFloats(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingFloats_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingGraphicsBufferHandleParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in GraphicsBufferHandle bufferHandle) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingGraphicsBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingIntParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingIntParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, int val) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingInts", HasExplicitThis = True)]
	private void Internal_SetRayTracingInts(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingInts_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixArrayParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingMatrixParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in Matrix4x4 val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingTextureParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, ref RenderTargetIdentifier rt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingTextureParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref RenderTargetIdentifier rt) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorArrayParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingVectorArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorParam", HasExplicitThis = True)]
	private void Internal_SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetRayTracingVectorParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in Vector4 val) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetSinglePassStereo_Injected(IntPtr _unity_self, SinglePassStereoMode mode) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = True)]
	private void InternalSetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetComputeBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetComputeBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetComputeBufferNativeData(ComputeBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetComputeBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = True)]
	private void InternalSetGraphicsBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetGraphicsBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetGraphicsBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetGraphicsBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetGraphicsBufferNativeData(GraphicsBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetGraphicsBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "InvokeOnRenderObjectCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "InvokeOnRenderObjectCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "InvokeOnRenderObjectCallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void InvokeOnRenderObjectCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::InvokeOnRenderObjectCallbacks", HasExplicitThis = True)]
	private void InvokeOnRenderObjectCallbacks_Internal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InvokeOnRenderObjectCallbacks_Internal_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "IssuePluginCustomBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(uint), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "IssuePluginCustomBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(uint), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "IssuePluginCustomBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(uint), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomBlitInternal", HasExplicitThis = True)]
	private void IssuePluginCustomBlitInternal(IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IssuePluginCustomBlitInternal_Injected(IntPtr _unity_self, IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomTextureUpdateInternal", HasExplicitThis = True)]
	private void IssuePluginCustomTextureUpdateInternal(IntPtr callback, Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IssuePluginCustomTextureUpdateInternal_Injected(IntPtr _unity_self, IntPtr callback, IntPtr targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "IssuePluginCustomTextureUpdateV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Texture), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "IssuePluginCustomTextureUpdateV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Texture), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "IssuePluginCustomTextureUpdateV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Texture), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "IssuePluginEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "IssuePluginEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "IssuePluginEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void IssuePluginEvent(IntPtr callback, int eventID) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "IssuePluginEventAndData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "IssuePluginEventAndData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "IssuePluginEventAndData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventAndDataInternal", HasExplicitThis = True)]
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IssuePluginEventAndDataInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID, IntPtr data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventInternal", HasExplicitThis = True)]
	private void IssuePluginEventInternal(IntPtr callback, int eventID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void IssuePluginEventInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "MarkLateLatchMatrixShaderPropertyID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "MarkLateLatchMatrixShaderPropertyID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "MarkLateLatchMatrixShaderPropertyID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = True)]
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MarkLateLatchMatrixShaderPropertyID_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void NextSubPass() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::NextSubPass", HasExplicitThis = True)]
	private void NextSubPass_Internal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void NextSubPass_Internal_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	private void ReleaseBuffer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReleaseBuffer_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_9", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetGraphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ValidateAgainstExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags), typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_RequestAsyncReadback_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>), typeof(AsyncRequestNativeArrayData*)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[CalledBy(Type = "UnityEngine.Rendering.CommandBufferPool", Member = "Get", ReturnType = typeof(CommandBuffer))]
	[CalledBy(Type = "UnityEngine.Rendering.CommandBufferPool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CommandBuffer))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", "UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", typeof(GPUDrivenProcessor), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_name_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnsafeUtility), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void SetBufferData(GraphicsBuffer buffer, Array data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetGraphicsBufferNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetComputeBufferNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "CopyFromStaging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.IndirectBufferAllocInfo&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetGraphicsBufferNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetComputeBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	public void SetBufferData(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "EnsureValidOcclusionTestResults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetComputeBufferNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetComputeBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public void SetBufferData(ComputeBuffer buffer, List<T> data) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ConstantBuffer`1", Member = "PushGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnsafeUtility), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void SetBufferData(ComputeBuffer buffer, Array data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetGraphicsBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "InternalSetGraphicsBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Array), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "DispatchStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.GPUSort+Args", typeof(uint), "UnityEngine.Rendering.GPUSort+Stage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(GraphicsBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(GraphicsBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(ComputeBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(ComputeBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeFloatParam(ComputeShader computeShader, string name, float val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeFloatParam", HasExplicitThis = True)]
	public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeFloatParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, float val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetComputeFloats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	public void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetComputeFloats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	public void SetComputeFloatParams(ComputeShader computeShader, int nameID, Single[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = True)]
	public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "DispatchStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.GPUSort+Args", typeof(uint), "UnityEngine.Rendering.GPUSort+Stage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeIntParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, int val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "System.Int32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "System.Int32[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetComputeInts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	public void SetComputeIntParams(ComputeShader computeShader, int nameID, Int32[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "System.Int32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "System.Int32[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetComputeInts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	public void SetComputeIntParams(ComputeShader computeShader, string name, Int32[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeKeyword", HasExplicitThis = True)]
	private void SetComputeKeyword(ComputeShader computeShader, LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixArrayParam", HasExplicitThis = True)]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixParam", HasExplicitThis = True)]
	public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeMatrixParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Matrix4x4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBuffer", "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBufferLayout", "System.Collections.Generic.List`1<BrickChunkAlloc>", typeof(bool), typeof(Texture), "UnityEngine.Rendering.ProbeVolumeSHBands", typeof(bool), typeof(Texture), typeof(bool), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "PerformBlending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), "UnityEngine.Rendering.ProbeBrickPool"}, ReturnType = typeof(void))]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateBlackUIntTextureArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateBlackUintTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "PerformBlending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), "UnityEngine.Rendering.ProbeBrickPool"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = True)]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeVectorArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "PerformBlending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), "UnityEngine.Rendering.ProbeBrickPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum", Member = "ExecuteCommonIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), "SupportResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum", Member = "DispatchDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "DirectArgs&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum", Member = "DispatchIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "IndirectDirectArgs&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetComputeVectorParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Vector4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.BaseCommandBuffer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	public void SetExecutionFlags(CommandBufferExecutionFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags flags) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteBeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ExecuteRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderPass", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyColorPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyDepthPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = True)]
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetFoveatedRenderingMode_Injected(IntPtr _unity_self, FoveatedRenderingMode foveatedRenderingMode) { }

	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = True)]
	public void SetGlobalColor(int nameID, Color value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalColor(string name, Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalColor_Injected(IntPtr _unity_self, int nameID, in Color value) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalConstantBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalConstantGraphicsBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddSetGlobalDepthBias")]
	public void SetGlobalDepthBias(float bias, float slopeBias) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalDepthBias_Injected(IntPtr _unity_self, float bias, float slopeBias) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	public void SetGlobalFloat(int nameID, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalFloat(string name, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Upload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalFloatArray(int nameID, Single[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalFloatArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArrayListImpl", HasExplicitThis = True)]
	private void SetGlobalFloatArrayListImpl(int nameID, object values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalFloatArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	private void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalGraphicsBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalInt(string name, int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "SetShaderDebugPrintInputConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.ShaderDebugPrintInput"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "SetOcclusionPermutation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool), typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = True)]
	public void SetGlobalInt(int nameID, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalInt_Injected(IntPtr _unity_self, int nameID, int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = True)]
	public void SetGlobalInteger(int nameID, int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalInteger(string name, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalInteger_Injected(IntPtr _unity_self, int nameID, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShaderKeyword", HasExplicitThis = True)]
	private void SetGlobalKeyword(GlobalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "SetupMainLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(VisibleLight&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = True)]
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalMatrix_Injected(IntPtr _unity_self, int nameID, in Matrix4x4 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Matrix4x4>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "SetBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "SetBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Upload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalMatrixArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArrayListImpl", HasExplicitThis = True)]
	private void SetGlobalMatrixArrayListImpl(int nameID, object values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalMatrixArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[CallerCount(Count = 65)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem", Member = "ReAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyColorPass", Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SwapColorBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderTextureDescriptor&), typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceShadows+ScreenSpaceShadowsPass", Member = "OnCameraSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "Configure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "SetGlobalTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.DBufferRenderPass+PassData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalVector(string name, Vector4 value) { }

	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetEasuConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.BaseCommandBuffer", typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "SetupPerCameraShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoGaussianDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetRcasConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupMainLightConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FSRUtils", Member = "SetEasuConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ProcessLensFlareSRPElementsSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.LensFlareDataElementSRP", typeof(CommandBuffer), typeof(Color), typeof(Light), typeof(float), typeof(float), typeof(Material), typeof(Vector2), typeof(bool), typeof(Vector2), typeof(Vector4), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "SetShaderDebugPrintInputConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.ShaderDebugPrintInput"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, in Vector4 value) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "SetBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "SetBuiltinShaderConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Upload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager", Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalLightData", "WorkSlice`1<LightCookieMapping>&", "WorkSlice`1<Vector4>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = True, ThrowsException = True)]
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<Vector4>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalVectorArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArrayListImpl", HasExplicitThis = True)]
	private void SetGlobalVectorArrayListImpl(int nameID, object values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetGlobalVectorArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRPass", Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetInstanceMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetInstanceMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = True)]
	public void SetInstanceMultiplier(uint multiplier) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetInstanceMultiplier_Injected(IntPtr _unity_self, uint multiplier) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetInvertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetInvertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetInvertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("AddSetInvertCulling")]
	public void SetInvertCulling(bool invertCulling) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetInvertCulling_Injected(IntPtr _unity_self, bool invertCulling) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "DispatchStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.GPUSort+Args", typeof(uint), "UnityEngine.Rendering.GPUSort+Stage"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitCubeToOctahedral2DQuadWithPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Texture), typeof(Vector2), typeof(Vector4), typeof(int), typeof(bool), typeof(int), "System.Nullable`1<Vector4>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetLateLatchProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetLateLatchProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetLateLatchProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetLateLatchProjectionMatrices_Injected(IntPtr _unity_self, ref ManagedSpanWrapper projectionMat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = True)]
	private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteSetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", typeof(int), "UnityEngine.Rendering.RenderGraphModule.ResourceHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteSetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", typeof(int), "UnityEngine.Rendering.RenderGraphModule.ResourceHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteSetRandomWriteTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer&), "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", typeof(int), "UnityEngine.Rendering.RenderGraphModule.ResourceHandle", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "ExecuteCIExyPrepass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.HDRDebugViewPass+PassDataCIExy", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = True, ThrowsException = True)]
	private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRandomWriteTarget_GraphicsBuffer_Injected(IntPtr _unity_self, int index, IntPtr uav, bool preserveCounterValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = True, ThrowsException = True)]
	private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRandomWriteTarget_Texture_Injected(IntPtr _unity_self, int index, ref RenderTargetIdentifier rt) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RayTracingAccelerationStructure)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(GraphicsBufferHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(ComputeBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(ComputeBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingConstantBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(GraphicsBuffer), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingFloatParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "System.Single[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingFloats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingFloatParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "System.Single[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingFloats", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, Single[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "System.Int32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "System.Int32[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingInts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, Int32[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "System.Int32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingIntParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "System.Int32[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingInts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Int32[])}, ReturnType = typeof(void))]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, Matrix4x4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Matrix4x4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingMatrixArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingMatrixParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), "UnityEngine.Vector4[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "Internal_SetRayTracingVectorArrayParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, Vector4[] values) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetRayTracingVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRayTracingVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum[]), "System.Int32Enum"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTargetMulti_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction[]), typeof(RenderBufferStoreAction[]), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	public void SetRenderTarget(RenderTargetBinding binding) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum[]), "System.Int32Enum"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTargetMultiSubtarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction[]), typeof(RenderBufferStoreAction[]), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RenderTargetIdentifier[]", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTargetMultiSubtarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction[]), typeof(RenderBufferStoreAction[]), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderTargetIdentifier[]", typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetRenderTargetMulti_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction[]), typeof(RenderBufferStoreAction[]), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag", typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), "UnityEngine.Rendering.ClearFlag", typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.ClearFlag", typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "ClearCubemap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTexture), typeof(Color), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "DrawFullScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(RenderTargetIdentifier), typeof(MaterialPropertyBlock), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas", Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), "UnityEngine.Rendering.PowerOfTwoTextureAtlas+BlitType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "ClearTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Texture2DAtlas", Member = "Blit2DTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector4), typeof(Texture), typeof(Vector4), typeof(bool), "UnityEngine.Rendering.Texture2DAtlas+BlitType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.FinalBlitPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), "UnityEngine.Rendering.ClearFlag", typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(CullingResults&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "CheckThrowOnSetRenderTarget", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetRenderTargetColorDepthSubtarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRenderTargetColorDepthSubtarget_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRenderTargetMulti_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetBinding), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRenderTargetMultiSubtarget_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetShadowSamplingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(ShadowSamplingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetShadowSamplingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(ShadowSamplingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetShadowSamplingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(ShadowSamplingMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShadowSamplingMode_Impl", HasExplicitThis = True)]
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetShadowSamplingMode_Impl_Injected(IntPtr _unity_self, ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetupCameraProperties(Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetupCameraProperties", HasExplicitThis = True)]
	private void SetupCameraProperties_Internal(Camera camera) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupCameraProperties_Internal_Injected(IntPtr _unity_self, IntPtr camera) { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	public void SetViewport(Rect pixelRect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetViewport_Injected(IntPtr _unity_self, in Rect pixelRect) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRBuiltinShaderConstants", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRPass", typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ShadowUtils", Member = "RenderShadowSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ScriptableRenderContext&), "UnityEngine.Rendering.Universal.ShadowSliceData&", typeof(ShadowDrawingSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetViewProjectionMatrices_Injected(IntPtr _unity_self, in Matrix4x4 view, in Matrix4x4 proj) { }

	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "SetWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "SetWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle", typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetWireframe", HasExplicitThis = True)]
	public void SetWireframe(bool enable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetWireframe_Injected(IntPtr _unity_self, bool enable) { }

	[CalledBy(Type = "UnityEngine.Rendering.ComputeCommandBuffer", Member = "UnmarkLateLatchMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RasterCommandBuffer", Member = "UnmarkLateLatchMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UnsafeCommandBuffer", Member = "UnmarkLateLatchMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = True)]
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UnmarkLateLatchMatrix_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(ComputeBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(ComputeBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(GraphicsBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(GraphicsBuffer), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(TextureFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "RequestAsyncReadbackIntoNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(Texture), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(GraphicsFormat), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraph", Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"CompiledPassInfo&", "UnityEngine.Rendering.RenderGraphModule.RenderGraphPass", "UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassCompiler", Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.InternalRenderGraphContext", "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry", "System.Collections.Generic.List`1<RenderGraphPass>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicsFence), Member = "Validate", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = True)]
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void WaitOnGPUFence_Internal_Injected(IntPtr _unity_self, IntPtr fencePtr, SynchronisationStageFlags stage) { }

}

