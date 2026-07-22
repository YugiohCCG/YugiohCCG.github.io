namespace UnityEngine.Rendering;

internal class InstanceDataSystem : IDisposable
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct CalculateInterpolatedLightAndOcclusionProbesBatchJob : IJobParallelFor
	{
		public const int k_BatchSize = 1; //Field offset: 0x0
		public const int k_CalculatedProbesPerBatch = 8; //Field offset: 0x0
		[ReadOnly]
		public int probesCount; //Field offset: 0x0
		[ReadOnly]
		public LightProbesQuery lightProbesQuery; //Field offset: 0x8
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Vector3> queryPostitions; //Field offset: 0x18
		[NativeDisableParallelForRestriction]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x28
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<SphericalHarmonicsL2> probesSphericalHarmonics; //Field offset: 0x38
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<Vector4> probesOcclusion; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(LightProbesQuery), Member = "CalculateInterpolatedLightAndOcclusionProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct CollectInstancesLODGroupsAndMasksJob : IJobParallelFor
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x0
		[ReadOnly]
		public ReadOnly instanceData; //Field offset: 0x10
		[ReadOnly]
		public ReadOnly sharedInstanceData; //Field offset: 0xE8
		[WriteOnly]
		public NativeArray<UInt32> lodGroupAndMasks; //Field offset: 0x188

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct ComputeInstancesOffsetAndResizeInstancesArrayJob : IJob
	{
		[ReadOnly]
		public NativeArray<Int32> instancesCount; //Field offset: 0x0
		[WriteOnly]
		public NativeArray<Int32> instancesOffset; //Field offset: 0x10
		public NativeList<InstanceHandle> instances; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		public override void Execute() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct GetVisibleNonProcessedTreeInstancesJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64; //Field offset: 0x0
		[ReadOnly]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[ReadOnly]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xE0
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x188
		[ReadOnly]
		public bool becomeVisible; //Field offset: 0x1A8
		[NativeDisableParallelForRestriction]
		public ParallelBitArray processedBits; //Field offset: 0x1B0
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<Int32> rendererIDs; //Field offset: 0x1D0
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x1E0
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicTreeInstancesCount; //Field offset: 0x1F0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstanceHandle), Member = "get_type", ReturnType = typeof(InstanceType))]
		[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUInstanceData), Member = "Get_SharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(SharedInstanceHandle))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Get_RendererGroupID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	private static class InstanceTransformUpdateIDs
	{
		public static readonly int _TransformUpdateQueueCount; //Field offset: 0x0
		public static readonly int _TransformUpdateOutputL2WVec4Offset; //Field offset: 0x4
		public static readonly int _TransformUpdateOutputW2LVec4Offset; //Field offset: 0x8
		public static readonly int _TransformUpdateOutputPrevL2WVec4Offset; //Field offset: 0xC
		public static readonly int _TransformUpdateOutputPrevW2LVec4Offset; //Field offset: 0x10
		public static readonly int _BoundingSphereOutputVec4Offset; //Field offset: 0x14
		public static readonly int _TransformUpdateDataQueue; //Field offset: 0x18
		public static readonly int _TransformUpdateIndexQueue; //Field offset: 0x1C
		public static readonly int _BoundingSphereDataQueue; //Field offset: 0x20
		public static readonly int _OutputTransformBuffer; //Field offset: 0x24
		public static readonly int _ProbeUpdateQueueCount; //Field offset: 0x28
		public static readonly int _SHUpdateVec4Offset; //Field offset: 0x2C
		public static readonly int _ProbeUpdateDataQueue; //Field offset: 0x30
		public static readonly int _ProbeOcclusionUpdateDataQueue; //Field offset: 0x34
		public static readonly int _ProbeUpdateIndexQueue; //Field offset: 0x38
		public static readonly int _OutputProbeBuffer; //Field offset: 0x3C

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static InstanceTransformUpdateIDs() { }

	}

	private static class InstanceWindDataUpdateIDs
	{
		public static readonly int _WindDataQueueCount; //Field offset: 0x0
		public static readonly int _WindDataUpdateIndexQueue; //Field offset: 0x4
		public static readonly int _WindDataBuffer; //Field offset: 0x8
		public static readonly int _WindParamAddressArray; //Field offset: 0xC
		public static readonly int _WindHistoryParamAddressArray; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static InstanceWindDataUpdateIDs() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct MotionUpdateJob : IJobParallelFor
	{
		public const int k_BatchSize = 16; //Field offset: 0x0
		[ReadOnly]
		public int queueWriteBase; //Field offset: 0x0
		[NativeDisableParallelForRestriction]
		public CPUInstanceData instanceData; //Field offset: 0x8
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicUpdateQueueCount; //Field offset: 0xE8
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<InstanceHandle> transformUpdateInstanceQueue; //Field offset: 0xF0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int chunk_index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct ProbesUpdateJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		public CPUInstanceData instanceData; //Field offset: 0x10
		[ReadOnly]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xF0
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicProbesQueueCount; //Field offset: 0x198
		[NativeDisableParallelForRestriction]
		public NativeArray<InstanceHandle> probeInstanceQueue; //Field offset: 0x1A0
		[NativeDisableParallelForRestriction]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x1B0
		[NativeDisableParallelForRestriction]
		public NativeArray<Vector3> probeQueryPosition; //Field offset: 0x1C0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstanceHandle), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct QueryRendererGroupInstancesCountJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[ReadOnly]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xE0
		[ReadOnly]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x188
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> rendererGroupIDs; //Field offset: 0x198
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<Int32> instancesCount; //Field offset: 0x1A8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct QueryRendererGroupInstancesJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> rendererGroupIDs; //Field offset: 0x10
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x20
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicNonFoundInstancesCount; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct QueryRendererGroupInstancesMultiJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public NativeParallelMultiHashMap<Int32, InstanceHandle> rendererGroupInstanceMultiHash; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> rendererGroupIDs; //Field offset: 0x10
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> instancesOffsets; //Field offset: 0x20
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		public NativeArray<Int32> instancesCounts; //Field offset: 0x30
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[WriteOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x40
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicNonFoundSharedInstancesCount; //Field offset: 0x50
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicNonFoundInstancesCount; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct QuerySortedMeshInstancesJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64; //Field offset: 0x0
		[ReadOnly]
		public CPUInstanceData instanceData; //Field offset: 0x0
		[ReadOnly]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0xE0
		[ReadOnly]
		public NativeArray<Int32> sortedMeshID; //Field offset: 0x188
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeList<InstanceHandle> instances; //Field offset: 0x198

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InstanceDataSystem), Member = "AtomicAddLengthNoResize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeList`1<T>&", typeof(int)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct ScatterTetrahedronCacheIndicesJob : IJobParallelFor
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<InstanceHandle> probeInstances; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<Int32> compactTetrahedronCache; //Field offset: 0x10
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		public CPUInstanceData instanceData; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct TransformUpdateJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64; //Field offset: 0x0
		[ReadOnly]
		public bool initialize; //Field offset: 0x0
		[ReadOnly]
		public bool enableBoundingSpheres; //Field offset: 0x1
		[ReadOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x8
		[ReadOnly]
		public NativeArray<Matrix4x4> localToWorldMatrices; //Field offset: 0x18
		[ReadOnly]
		public NativeArray<Matrix4x4> prevLocalToWorldMatrices; //Field offset: 0x28
		[NativeDisableUnsafePtrRestriction]
		public UnsafeAtomicCounter32 atomicTransformQueueCount; //Field offset: 0x38
		[NativeDisableParallelForRestriction]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0x40
		[NativeDisableParallelForRestriction]
		public CPUInstanceData instanceData; //Field offset: 0xE8
		[NativeDisableParallelForRestriction]
		public NativeArray<InstanceHandle> transformUpdateInstanceQueue; //Field offset: 0x1C8
		[NativeDisableParallelForRestriction]
		public NativeArray<TransformUpdatePacket> transformUpdateDataQueue; //Field offset: 0x1D8
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> boundingSpheresDataQueue; //Field offset: 0x1E8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&), typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ParallelBitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeAtomicCounter32), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(AABB)}, ReturnType = typeof(AABB))]
		[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(float3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(float3x3))]
		[Calls(Type = typeof(AABB), Member = "get_max", ReturnType = typeof(float3))]
		[Calls(Type = typeof(AABB), Member = "get_min", ReturnType = typeof(float3))]
		[Calls(Type = typeof(math), Member = "length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct UpdateCompactedInstanceVisibilityJob : IJobParallelForBatch
	{
		public const int k_BatchSize = 64; //Field offset: 0x0
		[ReadOnly]
		public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		public CPUInstanceData instanceData; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int startIndex, int count) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	private struct UpdateRendererInstancesJob : IJobParallelFor
	{
		public const int k_BatchSize = 128; //Field offset: 0x0
		[ReadOnly]
		public bool implicitInstanceIndices; //Field offset: 0x0
		[ReadOnly]
		public GPUDrivenRendererGroupData rendererData; //Field offset: 0x8
		[ReadOnly]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x1C8
		[ReadOnly]
		public NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataMap; //Field offset: 0x1D8
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		public CPUInstanceData instanceData; //Field offset: 0x1E8
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		[NoAlias]
		public CPUSharedInstanceData sharedInstanceData; //Field offset: 0x2C8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CPUInstanceData), Member = "Get_SharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(SharedInstanceHandle))]
		[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4), typeof(AABB)}, ReturnType = typeof(AABB))]
		[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int), typeof(SmallIntegerArray&), typeof(int), typeof(AABB&), typeof(TransformUpdateFlags), typeof(InstanceFlags), typeof(uint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CPUSharedInstanceData), Member = "Get_RefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SmallIntegerArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SmallIntegerArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_lodMask", ReturnType = typeof(byte))]
		[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_smallMeshCulling", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_shadowCastingMode", ReturnType = typeof(ShadowCastingMode))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_isPartOfStaticBatch", ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_lightProbeUsage", ReturnType = typeof(LightProbeUsage))]
		[Calls(Type = typeof(AABBExtensions), Member = "ToAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(AABB))]
		[Calls(Type = typeof(float3x3), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float4x4)}, ReturnType = typeof(float3x3))]
		[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int index) { }

	}

	private InstanceAllocators m_InstanceAllocators; //Field offset: 0x10
	private CPUSharedInstanceData m_SharedInstanceData; //Field offset: 0x70
	private CPUInstanceData m_InstanceData; //Field offset: 0x118
	private NativeParallelMultiHashMap<Int32, InstanceHandle> m_RendererGroupInstanceMultiHash; //Field offset: 0x1F8
	private ComputeShader m_TransformUpdateCS; //Field offset: 0x208
	private ComputeShader m_WindDataUpdateCS; //Field offset: 0x210
	private int m_TransformInitKernel; //Field offset: 0x218
	private int m_TransformUpdateKernel; //Field offset: 0x21C
	private int m_MotionUpdateKernel; //Field offset: 0x220
	private int m_ProbeUpdateKernel; //Field offset: 0x224
	private int m_LODUpdateKernel; //Field offset: 0x228
	private int m_WindDataCopyHistoryKernel; //Field offset: 0x22C
	private ComputeBuffer m_UpdateIndexQueueBuffer; //Field offset: 0x230
	private ComputeBuffer m_ProbeUpdateDataQueueBuffer; //Field offset: 0x238
	private ComputeBuffer m_ProbeOcclusionUpdateDataQueueBuffer; //Field offset: 0x240
	private ComputeBuffer m_TransformUpdateDataQueueBuffer; //Field offset: 0x248
	private ComputeBuffer m_BoundingSpheresUpdateDataQueueBuffer; //Field offset: 0x250
	private bool m_EnableBoundingSpheres; //Field offset: 0x258
	private readonly Int32[] m_ScratchWindParamAddressArray; //Field offset: 0x260

	public NativeArray<InstanceHandle> aliveInstances
	{
		[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_aliveInstances", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		 get { } //Length: 108
	}

	public bool hasBoundingSpheres
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public ReadOnly instanceData
	{
		[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 244
	}

	public ReadOnly sharedInstanceData
	{
		[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
		[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUSharedInstanceData&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 181
	}

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceAllocator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeShader), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, GPUResidentDrawerResources resources) { }

	[CalledBy(Type = typeof(QuerySortedMeshInstancesJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static int AtomicAddLengthNoResize(in NativeList<T>& list, int count) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceMotionsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceMotions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DispatchMotionUpdateCommand(int motionQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransformsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceProbesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SphericalHarmonicsL2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void DispatchProbeUpdateCommand(int queueCount, NativeArray<InstanceHandle> probeInstanceQueue, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransformsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer+ConvertCPUInstancesToGPUInstancesJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformUpdatePacket)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.TransformUpdatePacket>), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, NativeArray<TransformUpdatePacket> updateDataQueue, NativeArray<float4> boundingSphereUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceWindDataHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void DispatchWindDataCopyHistoryCommand(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceAllocators), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "EnsureProbeBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "EnsureTransformBuffersCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "DispatchWindDataCopyHistoryCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureIndexQueueBufferCapacity(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureProbeBuffersCapacity(int capacity) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "DispatchTransformUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.TransformUpdatePacket>), typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float4>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "EnsureIndexQueueBufferCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureTransformBuffersCapacity(int capacity) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeInstances(NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "AsReadOnly", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FreeRendererGroupInstances(NativeArray<Int32> rendererGroupsID) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_aliveInstances", ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	public NativeArray<InstanceHandle> get_aliveInstances() { }

	[CallerCount(Count = 0)]
	public bool get_hasBoundingSpheres() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_instanceData", ReturnType = typeof(ReadOnly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly get_instanceData() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "get_sharedInstanceData", ReturnType = typeof(ReadOnly))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUSharedInstanceData&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ReadOnly get_sharedInstanceData() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GetAliveInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceAllocators), Member = "GetInstancesLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	public int GetAliveInstancesOfType(InstanceType instanceType) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GetMaxInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "EnsureInstanceBufferCapacity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InstanceAllocators), Member = "GetInstanceHandlesLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	public int GetMaxInstancesOfType(InstanceType instanceType) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GetVisibleTreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&), typeof(ParallelBitArray&), typeof(Unity.Collections.NativeList`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>), typeof(bool), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetVisibleNonProcessedTreeInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetVisibleNonProcessedTreeInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void GetVisibleTreeInstances(in ParallelBitArray compactedVisibilityMasks, in ParallelBitArray processedBits, NativeList<Int32> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "InitializeInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransformsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	public void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "IsValidInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.SharedInstanceHandle, System.Int32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.SharedInstanceHandle, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.SharedInstanceHandle, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "IsValidInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.NativeParallelHashMap`2<UnityEngine.Rendering.SharedInstanceHandle, System.Int32>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public bool InternalSanityCheckStates() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesMultiJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesMultiJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Grow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void ReallocateAndGetInstances(in GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleCollectInstancesLODGroupAndMasksJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.UInt32>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUInstanceData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CPUSharedInstanceData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectInstancesLODGroupsAndMasksJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectInstancesLODGroupsAndMasksJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 2)]
	public JobHandle ScheduleCollectInstancesLODGroupAndMasksJob(NativeArray<InstanceHandle> instances, NativeArray<UInt32> lodGroupAndMasks) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransformsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceProbesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightProbesQuery), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CalculateInterpolatedLightAndOcclusionProbesBatchJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CalculateInterpolatedLightAndOcclusionProbesBatchJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(LightProbesQuery), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScatterTetrahedronCacheIndicesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScatterTetrahedronCacheIndicesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, NativeArray<InstanceHandle> probeUpdateInstanceQueue, NativeArray<Int32> compactTetrahedronCache, NativeArray<Vector3> probeQueryPosition, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GetRendererInstanceHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InstanceHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<System.Int32>), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryRendererGroupInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesCountJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesCountJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeInstancesOffsetAndResizeInstancesArrayJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeInstancesOffsetAndResizeInstancesArrayJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(NativeList`1), Member = "AsDeferredJobArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesMultiJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryRendererGroupInstancesMultiJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<Int32> rendererGroupIDs, NativeArray<Int32> instancesOffset, NativeArray<Int32> instancesCount, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleQueryMeshInstancesJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySortedMeshInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuerySortedMeshInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	public JobHandle ScheduleQuerySortedMeshInstancesJob(NativeArray<Int32> sortedMeshIDs, NativeList<InstanceHandle> instances) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "ScheduleUpdateInstanceDataJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(GPUDrivenRendererGroupData&)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateRendererInstancesJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateRendererInstancesJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, in GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataMap) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateAmbientProbeAndGpuBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetSubArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceProbesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	public void UpdateAllInstanceProbes(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceMotions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInstanceMotions(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateInstanceMotionsData(in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateAllInstanceProbes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbesUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbesUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleInterpolateProbesAndUpdateTetrahedronCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateInstanceProbesData(NativeArray<InstanceHandle> instances, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransformsData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	public void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "InitializeInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "UpdateInstanceTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Matrix4x4>), typeof(RenderersParameters&), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbesUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbesUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "ScheduleInterpolateProbesAndUpdateTetrahedronCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector4>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchTransformUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.TransformUpdatePacket>), typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float4>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateInstanceTransformsData(bool initialize, NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, in RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdateInstanceWindDataHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstanceDataSystem), Member = "DispatchWindDataCopyHistoryCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUInstanceIndex>), typeof(RenderersParameters), typeof(GPUInstanceDataBuffer)}, ReturnType = typeof(void))]
	public void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "UpdatePerFrameInstanceVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParallelBitArray&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobParallelForBatchExtensions), Member = "ScheduleBatch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateCompactedInstanceVisibilityJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateCompactedInstanceVisibilityJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePerFrameInstanceVisibility(in ParallelBitArray compactedVisibilityMasks) { }

}

