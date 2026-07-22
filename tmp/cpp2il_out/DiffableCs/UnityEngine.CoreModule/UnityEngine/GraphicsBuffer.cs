namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
[UsedByNativeCode]
public sealed class GraphicsBuffer : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(GraphicsBuffer graphicsBuffer) { }

	}

	[Flags]
	internal enum Target
	{
		Vertex = 1,
		Index = 2,
		CopySource = 4,
		CopyDestination = 8,
		Structured = 16,
		Raw = 32,
		Append = 64,
		Counter = 128,
		IndirectArguments = 256,
		Constant = 512,
	}

	[Flags]
	internal enum UsageFlags
	{
		None = 0,
		LockBufferForWrite = 1,
	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public GraphicsBufferHandle bufferHandle
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceComponentGroup"}, ReturnType = typeof(BatchID))]
		[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "get_visibleInstanceBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
		[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "get_indirectDrawArgsBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 98
	}

	public int count
	{
		[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferPool", Member = "GetResourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer&)}, ReturnType = typeof(long))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public string name
	{
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferResource", Member = "UpdateGraphicsResource", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GraphicsBuffer), Member = "SetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	public int stride
	{
		[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferPool", Member = "GetResourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer&)}, ReturnType = typeof(long))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 81
	}

	public UsageFlags usageFlags
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 81
	}

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBuffer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeScratchBufferPool", Member = "CreateScratchBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingScratchBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferResource", Member = "CreateGraphicsResource", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "AllocateTexturesIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "InternalInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(UsageFlags), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public GraphicsBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "get_emptyBuffer", ReturnType = typeof(GraphicsBuffer))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum+SupportResources", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferBuilder", Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceNumInfo&"}, ReturnType = "UnityEngine.Rendering.GPUInstanceDataBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "AllocateInstanceBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "AllocateDrawBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "InternalInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(UsageFlags), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public GraphicsBuffer(Target target, int count, int stride) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Void* BeginBufferWrite(int offset = 0, int size = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Void* BeginBufferWrite_Injected(IntPtr _unity_self, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
	private static void DestroyBuffer(GraphicsBuffer buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DestroyBuffer_Injected(IntPtr buf) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "UnlockBufferAfterWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void EndBufferWrite(int bytesWritten = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EndBufferWrite_Injected(IntPtr _unity_self, int bytesWritten) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceComponentGroup"}, ReturnType = typeof(BatchID))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "get_visibleInstanceBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "get_indirectDrawArgsBufferHandle", ReturnType = typeof(GraphicsBufferHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public GraphicsBufferHandle get_bufferHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_bufferHandle_Injected(IntPtr _unity_self, out GraphicsBufferHandle ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferPool", Member = "GetResourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer&)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_count() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_count_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferPool", Member = "GetResourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer&)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_stride() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_stride_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public UsageFlags get_usageFlags() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::GetUsageFlags", HasExplicitThis = True)]
	private UsageFlags GetUsageFlags() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UsageFlags GetUsageFlags_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsBuffer_Bindings::InitBuffer")]
	private static IntPtr InitBuffer(Target target, UsageFlags usageFlags, int count, int stride) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(UsageFlags), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 36)]
	private void InternalInitialization(Target target, UsageFlags usageFlags, int count, int stride) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetData_Injected(IntPtr _unity_self, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetNativeData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void InternalSetNativeData_Injected(IntPtr _unity_self, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "get_emptyBuffer", ReturnType = typeof(GraphicsBuffer))]
	[CalledBy(Type = typeof(GraphicsBuffer), Member = "LockBufferForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GraphicsBuffer_Bindings::IsValidBuffer")]
	private static bool IsValidBuffer(GraphicsBuffer buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsValidBuffer_Injected(IntPtr buf) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsVertexIndexOrCopyOnly(Target target) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateActiveRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "BeginBufferWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	[DeduplicatedMethod]
	public NativeArray<T> LockBufferForWrite(int bufferStartIndex, int count) { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Release() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool RequiresCompute(Target target) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.BufferResource", Member = "UpdateGraphicsResource", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "CreateForwardPlusBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public void set_name(string value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "SetupShaderProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "SetShaderDebugPrintBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "ClearShaderDebugPrintBuffer", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferBuilder", Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceNumInfo&"}, ReturnType = "UnityEngine.Rendering.GPUInstanceDataBuffer")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "InternalSetNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetData(NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "InternalSetNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetData(NativeArray<T> data) { }

	[CalledBy(Type = typeof(GraphicsBuffer), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction(Name = "GraphicsBuffer_Bindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateActiveRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = "EndBufferWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void UnlockBufferAfterWrite(int countWritten) { }

}

