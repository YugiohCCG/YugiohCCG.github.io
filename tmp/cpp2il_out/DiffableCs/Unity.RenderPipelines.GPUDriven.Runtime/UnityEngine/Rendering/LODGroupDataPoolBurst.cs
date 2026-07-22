namespace UnityEngine.Rendering;

[BurstCompile]
internal static class LODGroupDataPoolBurst
{
	public static class AllocateOrGetLODGroupDataInstances_000002D6$BurstDirectCall
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
		public static int Invoke(in NativeArray<Int32>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class AllocateOrGetLODGroupDataInstances_000002D6$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public AllocateOrGetLODGroupDataInstances_000002D6$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(in NativeArray<Int32>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	}

	public static class FreeLODGroupData_000002D5$BurstDirectCall
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

		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public static int Invoke(in NativeArray<Int32>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FreeLODGroupData_000002D5$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public FreeLODGroupData_000002D5$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(in NativeArray<Int32>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	}


	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(AllocateOrGetLODGroupDataInstances_000002D6$PostfixBurstDelegate))]
	public static int AllocateOrGetLODGroupDataInstances(in NativeArray<Int32>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static int AllocateOrGetLODGroupDataInstances$BurstManaged(in NativeArray<Int32>& lodGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeList<LODGroupCullingData>& lodGroupCullingData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles, ref NativeArray<GPUInstanceIndex>& lodGroupInstances) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(FreeLODGroupData_000002D5$PostfixBurstDelegate))]
	public static int FreeLODGroupData(in NativeArray<Int32>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static int FreeLODGroupData$BurstManaged(in NativeArray<Int32>& destroyedLODGroupsID, ref NativeList<LODGroupData>& lodGroupsData, ref NativeParallelHashMap<Int32, GPUInstanceIndex>& lodGroupDataHash, ref NativeList<GPUInstanceIndex>& freeLODGroupDataHandles) { }

}

