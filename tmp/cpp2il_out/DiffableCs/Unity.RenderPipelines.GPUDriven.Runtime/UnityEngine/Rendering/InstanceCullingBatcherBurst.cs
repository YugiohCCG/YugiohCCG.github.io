namespace UnityEngine.Rendering;

[BurstCompile]
internal static class InstanceCullingBatcherBurst
{
	public static class CreateDrawBatches_00000188$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(InstanceCullingBatcher), Member = "BuildBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcherBurst), Member = "CreateDrawBatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<InstanceHandle>&), typeof(GPUDrivenRendererGroupData&), typeof(NativeParallelHashMap`2<Int32, BatchMeshID>&), typeof(NativeParallelHashMap`2<Int32, BatchMaterialID>&), typeof(NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&), typeof(NativeList`1<DrawInstance>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(InstanceCullingBatcherBurst), Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMeshID>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMaterialID>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawRange>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.DrawKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public static void Invoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<Int32, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<Int32, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CreateDrawBatches_00000188$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public CreateDrawBatches_00000188$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<Int32, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<Int32, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances, AsyncCallback unnamed_param_11, object unnamed_param_12) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<Int32, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<Int32, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	}

	public static class RemoveDrawInstanceIndices_00000184$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyDrawInstanceIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CPUDrawInstanceData), Member = "DestroyMaterialDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceCullingBatcherBurst), Member = "RemoveDrawInstanceIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
		[Calls(Type = typeof(InstanceCullingBatcherBurst), Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawKey&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public static void Invoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class RemoveDrawInstanceIndices_00000184$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public RemoveDrawInstanceIndices_00000184$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	}


	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateDrawBatches_00000188$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<InstanceHandle>&), typeof(GPUDrivenRendererGroupData&), typeof(NativeParallelHashMap`2<Int32, BatchMeshID>&), typeof(NativeParallelHashMap`2<Int32, BatchMaterialID>&), typeof(NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&), typeof(NativeList`1<DrawInstance>&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(CreateDrawBatches_00000188$PostfixBurstDelegate))]
	public static void CreateDrawBatches(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<Int32, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<Int32, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceCullingBatcherBurst), Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMeshID>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMaterialID>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawRange>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.DrawKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>)}, ReturnType = typeof(void))]
	internal static void CreateDrawBatches$BurstManaged(bool implicitInstanceIndices, in NativeArray<InstanceHandle>& instances, in GPUDrivenRendererGroupData rendererData, in NativeParallelHashMap<Int32, BatchMeshID>& batchMeshHash, in NativeParallelHashMap<Int32, BatchMaterialID>& batchMaterialHash, in NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData>& packedMaterialDataHash, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches, ref NativeList<DrawInstance>& drawInstances) { }

	[CalledBy(Type = typeof(InstanceCullingBatcherBurst), Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMeshID>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeParallelHashMap`2<System.Int32, UnityEngine.Rendering.BatchMaterialID>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawRange>), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.DrawKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBatch&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
	[CallsUnknownMethods(Count = 1)]
	private static DrawBatch EditDrawBatch(in DrawKey key, in SubMeshDescriptor subMeshDescriptor, NativeParallelHashMap<DrawKey, Int32> batchHash, NativeList<DrawBatch> drawBatches) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsUnknownMethods(Count = 1)]
	private static DrawRange EditDrawRange(in RangeKey key, NativeParallelHashMap<RangeKey, Int32> rangeHash, NativeList<DrawRange> drawRanges) { }

	[CalledBy(Type = typeof(CreateDrawBatches_00000188$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<InstanceHandle>&), typeof(GPUDrivenRendererGroupData&), typeof(NativeParallelHashMap`2<Int32, BatchMeshID>&), typeof(NativeParallelHashMap`2<Int32, BatchMaterialID>&), typeof(NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&), typeof(NativeList`1<DrawInstance>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcherBurst), Member = "CreateDrawBatches$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<InstanceHandle>&), typeof(GPUDrivenRendererGroupData&), typeof(NativeParallelHashMap`2<Int32, BatchMeshID>&), typeof(NativeParallelHashMap`2<Int32, BatchMaterialID>&), typeof(NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&), typeof(NativeList`1<DrawInstance>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawInstance&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceCullingBatcherBurst), Member = "EditDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawKey&), typeof(SubMeshDescriptor&), typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.DrawKey, System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>)}, ReturnType = typeof(DrawBatch&))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedMaterialData", Member = "get_isTransparent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_shadowCastingMode", ReturnType = typeof(ShadowCastingMode))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_motionVecGenMode", ReturnType = typeof(MotionVectorGenerationMode))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedMaterialData", Member = "get_hasTessellation", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_lightProbeUsage", ReturnType = typeof(LightProbeUsage))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_hasTree", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static void ProcessRenderer(int i, bool implicitInstanceIndices, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<Int32, BatchMeshID> batchMeshHash, NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> packedMaterialDataHash, NativeParallelHashMap<Int32, BatchMaterialID> batchMaterialHash, NativeArray<InstanceHandle> instances, NativeList<DrawInstance> drawInstances, NativeParallelHashMap<RangeKey, Int32> rangeHash, NativeList<DrawRange> drawRanges, NativeParallelHashMap<DrawKey, Int32> batchHash, NativeList<DrawBatch> drawBatches) { }

	[CalledBy(Type = typeof(RemoveDrawInstanceIndices_00000184$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceCullingBatcherBurst), Member = "RemoveDrawInstanceIndices$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void RemoveDrawBatch(in DrawKey key, ref NativeList<DrawRange>& drawRanges, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawBatch>& drawBatches) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RemoveDrawInstanceIndices_00000184$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeList`1<DrawInstance>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawRange>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(RemoveDrawInstanceIndices_00000184$PostfixBurstDelegate))]
	public static void RemoveDrawInstanceIndices(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawBatch>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DrawBatch&))]
	[Calls(Type = typeof(InstanceCullingBatcherBurst), Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawKey&), typeof(NativeList`1<DrawRange>&), typeof(NativeParallelHashMap`2<RangeKey, Int32>&), typeof(NativeParallelHashMap`2<DrawKey, Int32>&), typeof(NativeList`1<DrawBatch>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.DrawInstance>), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void RemoveDrawInstanceIndices$BurstManaged(in NativeArray<Int32>& drawInstanceIndices, ref NativeList<DrawInstance>& drawInstances, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeParallelHashMap<DrawKey, Int32>& batchHash, ref NativeList<DrawRange>& drawRanges, ref NativeList<DrawBatch>& drawBatches) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.RangeKey, System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void RemoveDrawRange(in RangeKey key, ref NativeParallelHashMap<RangeKey, Int32>& rangeHash, ref NativeList<DrawRange>& drawRanges) { }

}

