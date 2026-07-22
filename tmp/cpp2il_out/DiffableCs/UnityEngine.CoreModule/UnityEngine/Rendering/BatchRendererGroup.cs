namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode]
public class BatchRendererGroup : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(BatchRendererGroup batchRendererGroup) { }

	}

	internal sealed class OnFinishedCulling : MulticastDelegate
	{

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnFinishedCulling(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(IntPtr customCullingResult) { }

	}

	internal sealed class OnPerformCulling : MulticastDelegate
	{

		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContext", "UnityEngine.Rendering.InstanceCullingBatcherDesc", typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public OnPerformCulling(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

	}

	private IntPtr m_GroupHandle; //Field offset: 0x10
	private OnPerformCulling m_PerformCulling; //Field offset: 0x18
	private OnFinishedCulling m_FinishedCulling; //Field offset: 0x20

	public static BatchBufferTarget BufferTarget
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContext", "UnityEngine.Rendering.InstanceCullingBatcherDesc", typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public BatchRendererGroup(BatchRendererGroupCreateInfo info) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "GetBatchID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceComponentGroup"}, ReturnType = typeof(BatchID))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public BatchID AddBatch(NativeArray<MetadataValue> batchMetadata, GraphicsBufferHandle buffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private BatchID AddDrawCommandBatch(IntPtr values, int count, GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void AddDrawCommandBatch_Injected(IntPtr _unity_self, IntPtr values, int count, in GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, out BatchID ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create(BatchRendererGroup group, Void* userContext) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Destroy(IntPtr groupHandle) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static BatchBufferTarget get_BufferTarget() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static BatchBufferTarget GetBufferTarget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

	[CalledBy(Type = "UnityEngine.Rendering.CullingJob", Member = "CalculateVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.InstanceFlags"}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("BatchRendererGroup::OcclusionTestAABB", IsThreadSafe = True)]
	internal static bool OcclusionTestAABB(IntPtr occlusionBuffer, Bounds aabb) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool OcclusionTestAABB_Injected(IntPtr occlusionBuffer, in Bounds aabb) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void RegisterMaterials(ReadOnlySpan<Int32> materialID, Span<BatchMaterialID> batchMaterialID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RegisterMaterials_Injected(IntPtr _unity_self, ref ManagedSpanWrapper materialID, ref ManagedSpanWrapper batchMaterialID) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	internal void RegisterMeshes(ReadOnlySpan<Int32> meshID, Span<BatchMeshID> batchMeshID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RegisterMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper meshID, ref ManagedSpanWrapper batchMeshID) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "UpdateInstanceDataBufferLayoutVersion", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveBatch(BatchID batchID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveDrawCommandBatch(BatchID batchID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RemoveDrawCommandBatch_Injected(IntPtr _unity_self, in BatchID batchID) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void UnregisterMaterial(BatchMaterialID material) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UnregisterMaterial_Injected(IntPtr _unity_self, in BatchMaterialID material) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void UnregisterMesh(BatchMeshID mesh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UnregisterMesh_Injected(IntPtr _unity_self, in BatchMeshID mesh) { }

}

