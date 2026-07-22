namespace UnityEngine.Rendering;

[BurstCompile]
internal static class GPUResidentDrawerBurst
{
	public static class ClassifyMaterials_000000EA$BurstDirectCall
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

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public static void Invoke(in NativeArray<Int32>& materialIDs, in ReadOnly<Int32, BatchMaterialID> batchMaterialHash, ref NativeList<Int32>& supportedMaterialIDs, ref NativeList<Int32>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ClassifyMaterials_000000EA$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ClassifyMaterials_000000EA$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& materialIDs, in ReadOnly<Int32, BatchMaterialID> batchMaterialHash, ref NativeList<Int32>& supportedMaterialIDs, ref NativeList<Int32>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in NativeArray<Int32>& materialIDs, in ReadOnly<Int32, BatchMaterialID> batchMaterialHash, ref NativeList<Int32>& supportedMaterialIDs, ref NativeList<Int32>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	}

	public static class FindUnsupportedRenderers_000000EB$BurstDirectCall
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

		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "PostPostLateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "FindUnsupportedRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(Unity.Collections.NativeList`1<System.Int32>))]
		[CalledBy(Type = typeof(GPUResidentDrawerBurst), Member = "FindUnsupportedRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(SmallIntegerArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(NativeArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "U"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public static void Invoke(in NativeArray<Int32>& unsupportedMaterials, in ReadOnly<SmallIntegerArray> materialIDArrays, in ReadOnly<Int32> rendererGroups, ref NativeList<Int32>& unsupportedRenderers) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class FindUnsupportedRenderers_000000EB$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FindUnsupportedRenderers_000000EB$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& unsupportedMaterials, in ReadOnly<SmallIntegerArray> materialIDArrays, in ReadOnly<Int32> rendererGroups, ref NativeList<Int32>& unsupportedRenderers, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in NativeArray<Int32>& unsupportedMaterials, in ReadOnly<SmallIntegerArray> materialIDArrays, in ReadOnly<Int32> rendererGroups, ref NativeList<Int32>& unsupportedRenderers) { }

	}

	public static class GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall
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

		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Unity.Collections.NativeArray`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GPUResidentDrawer), Member = "GetMaterialsWithChangedPackedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>), typeof(Allocator)}, ReturnType = typeof(Unity.Collections.NativeHashSet`1<System.Int32>))]
		[CalledBy(Type = typeof(GPUResidentDrawerBurst), Member = "GetMaterialsWithChangedPackedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedMaterialData>&), typeof(ReadOnly<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeHashSet`1<Int32>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedMaterialData", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUDrivenPackedMaterialData"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeHashSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public static void Invoke(in NativeArray<Int32>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<Int32>& filteredMaterials) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(in NativeArray<Int32>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<Int32>& filteredMaterials, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(in NativeArray<Int32>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<Int32>& filteredMaterials) { }

	}


	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(ClassifyMaterials_000000EA$PostfixBurstDelegate))]
	public static void ClassifyMaterials(in NativeArray<Int32>& materialIDs, in ReadOnly<Int32, BatchMaterialID> batchMaterialHash, ref NativeList<Int32>& supportedMaterialIDs, ref NativeList<Int32>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenProcessor", Member = "ClassifyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal static void ClassifyMaterials$BurstManaged(in NativeArray<Int32>& materialIDs, in ReadOnly<Int32, BatchMaterialID> batchMaterialHash, ref NativeList<Int32>& supportedMaterialIDs, ref NativeList<Int32>& unsupportedMaterialIDs, ref NativeList<GPUDrivenPackedMaterialData>& supportedPackedMaterialDatas) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FindUnsupportedRenderers_000000EB$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(ReadOnly<SmallIntegerArray>&), typeof(ReadOnly<Int32>&), typeof(NativeList`1<Int32>&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(FindUnsupportedRenderers_000000EB$PostfixBurstDelegate))]
	public static void FindUnsupportedRenderers(in NativeArray<Int32>& unsupportedMaterials, in ReadOnly<SmallIntegerArray> materialIDArrays, in ReadOnly<Int32> rendererGroups, ref NativeList<Int32>& unsupportedRenderers) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallIntegerArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NativeArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "U"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void FindUnsupportedRenderers$BurstManaged(in NativeArray<Int32>& unsupportedMaterials, in ReadOnly<SmallIntegerArray> materialIDArrays, in ReadOnly<Int32> rendererGroups, ref NativeList<Int32>& unsupportedRenderers) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetMaterialsWithChangedPackedMaterial_000000EC$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedMaterialData>&), typeof(ReadOnly<Int32, GPUDrivenPackedMaterialData>&), typeof(NativeHashSet`1<Int32>&)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(GetMaterialsWithChangedPackedMaterial_000000EC$PostfixBurstDelegate))]
	public static void GetMaterialsWithChangedPackedMaterial(in NativeArray<Int32>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<Int32>& filteredMaterials) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Rendering.GPUDrivenPackedMaterialData", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUDrivenPackedMaterialData"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeHashSet`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static void GetMaterialsWithChangedPackedMaterial$BurstManaged(in NativeArray<Int32>& materialIDs, in NativeArray<GPUDrivenPackedMaterialData>& packedMaterialDatas, in ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialHash, ref NativeHashSet<Int32>& filteredMaterials) { }

}

