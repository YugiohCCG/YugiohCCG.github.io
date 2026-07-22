namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
[RequiredByNativeCode]
internal class GPUDrivenProcessor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__34_0(in GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.cctor>b__34_1(in GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }

	}

	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(GPUDrivenProcessor obj) { }

	}

	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; //Field offset: 0x0
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List<Mesh> <scratchMeshes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List<Material> <scratchMaterials>k__BackingField; //Field offset: 0x20

	public bool enablePartialRendering
	{
		[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 155
	}

	internal List<Material> scratchMaterials
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal List<Mesh> scratchMeshes
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	private static GPUDrivenProcessor() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public GPUDrivenProcessor() { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawerBurst", Member = "ClassifyMaterials$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "ReadOnly<Int32, BatchMaterialID>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.Span`1<T>")]
	[Calls(Type = typeof(GPUDrivenProcessor), Member = "ClassifyMaterialsImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Int32>), typeof(System.Span`1<System.Int32>), typeof(System.Span`1<System.Int32>), typeof(System.Span`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	public static int ClassifyMaterials(NativeArray<Int32> materialIDs, NativeArray<Int32> unsupportedMaterialIDs, NativeArray<Int32> supportedMaterialIDs, NativeArray<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas) { }

	[CalledBy(Type = typeof(GPUDrivenProcessor), Member = "ClassifyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GPUDrivenProcessor::ClassifyMaterials", IsThreadSafe = True)]
	private static int ClassifyMaterialsImpl(ReadOnlySpan<Int32> materialIDs, Span<Int32> unsupportedMaterialIDs, Span<Int32> supportedMaterialIDs, Span<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ClassifyMaterialsImpl_Injected(ref ManagedSpanWrapper materialIDs, ref ManagedSpanWrapper unsupportedMaterialIDs, ref ManagedSpanWrapper supportedMaterialIDs, ref ManagedSpanWrapper supportedPackedMaterialDatas) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ClearMaterialFilters() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearMaterialFilters_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(GPUDrivenProcessor), Member = "Finalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUDrivenProcessor), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Destroy() { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDispatchData), "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DisableGPUDrivenRendering(ReadOnlySpan<Int32> renderersID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableGPUDrivenRendering_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void DispatchLODGroupData(ReadOnlySpan<Int32> lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param) { }

	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "UpdateLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "TransformLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DispatchLODGroupData(ReadOnlySpan<Int32> lodGroupID, GPUDrivenLODGroupDataCallback callback) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DispatchLODGroupData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper lodGroupID, GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataCallback param) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUDrivenProcessor), Member = "Destroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<Int32> renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableGPUDrivenRenderingAndDispatchRendererData(ReadOnlySpan<Int32> renderersID, GPUDrivenRendererDataCallback callback, bool materialUpdateOnly = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(IntPtr _unity_self, ref ManagedSpanWrapper renderersID, GPUDrivenRendererDataNativeCallback callback, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback param, bool materialUpdateOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUDrivenProcessor), Member = "Destroy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal List<Material> get_scratchMaterials() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal List<Mesh> get_scratchMeshes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_Create() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_enablePartialRendering(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_enablePartialRendering_Injected(IntPtr _unity_self, bool value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_scratchMaterials(List<Material> value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_scratchMeshes(List<Mesh> value) { }

}

