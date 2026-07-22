namespace UnityEngine.Rendering;

[BurstCompile]
internal static class InstanceDataSystemBurst
{
	public static class FreeInstances_00000285$BurstDirectCall
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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public static void Invoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeInstances_00000285$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FreeInstances_00000285$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	public static class FreeRendererGroupInstances_00000284$BurstDirectCall
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

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public static void Invoke(in ReadOnly<Int32> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeRendererGroupInstances_00000284$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FreeRendererGroupInstances_00000284$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in ReadOnly<Int32> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in ReadOnly<Int32> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	public static class ReallocateInstances_00000283$BurstDirectCall
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

		[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		public static void Invoke(bool implicitInstanceIndices, in NativeArray<Int32>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ReallocateInstances_00000283$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public ReallocateInstances_00000283$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(bool implicitInstanceIndices, in NativeArray<Int32>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash, AsyncCallback unnamed_param_10, object unnamed_param_11) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(bool implicitInstanceIndices, in NativeArray<Int32>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	}


	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(FreeInstances_00000285$PostfixBurstDelegate))]
	public static void FreeInstances(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnly), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>+Enumerator<T>")]
	[Calls(Type = typeof(CPUInstanceData), Member = "IsValidInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeSharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void FreeInstances$BurstManaged(in ReadOnly<InstanceHandle> instances, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(FreeRendererGroupInstances_00000284$PostfixBurstDelegate))]
	public static void FreeRendererGroupInstances(in ReadOnly<Int32> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnly), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+ReadOnly<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Get_SharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(SharedInstanceHandle))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "SharedInstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeSharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static void FreeRendererGroupInstances$BurstManaged(in ReadOnly<Int32> rendererGroupsID, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = "ReallocateAndGetInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUDrivenRendererGroupData&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.InstanceHandle>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReallocateInstances_00000283$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(ReallocateInstances_00000283$PostfixBurstDelegate))]
	public static void ReallocateInstances(bool implicitInstanceIndices, in NativeArray<Int32>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CPUInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "AllocateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(InstanceHandle))]
	[Calls(Type = typeof(InstanceHandle), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Set_RefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeSharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "FreeInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CPUInstanceData), Member = "InstanceToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetNextValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "Get_RefCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CPUInstanceData), Member = "Get_SharedInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceHandle)}, ReturnType = typeof(SharedInstanceHandle))]
	[Calls(Type = typeof(CPUSharedInstanceData), Member = "AddNoGrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SharedInstanceHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceAllocators), Member = "AllocateSharedInstance", ReturnType = typeof(SharedInstanceHandle))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "TryGetFirstValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&", "Unity.Collections.NativeParallelMultiHashMapIterator`1<TKey>&"}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedRendererData", Member = "get_hasTree", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParallelBitArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeParallelMultiHashMap`2), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	internal static void ReallocateInstances$BurstManaged(bool implicitInstanceIndices, in NativeArray<Int32>& rendererGroupIDs, in NativeArray<GPUDrivenPackedRendererData>& packedRendererData, in NativeArray<Int32>& instanceOffsets, in NativeArray<Int32>& instanceCounts, ref InstanceAllocators instanceAllocators, ref CPUInstanceData instanceData, ref CPUSharedInstanceData sharedInstanceData, ref NativeArray<InstanceHandle>& instances, ref NativeParallelMultiHashMap<Int32, InstanceHandle>& rendererGroupInstanceMultiHash) { }

}

