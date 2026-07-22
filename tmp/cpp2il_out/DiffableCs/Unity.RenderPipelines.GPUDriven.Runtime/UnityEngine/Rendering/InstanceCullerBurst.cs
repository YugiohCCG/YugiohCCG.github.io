namespace UnityEngine.Rendering;

[BurstCompile]
internal static class InstanceCullerBurst
{
	public static class SetupCullingJobInput_00000146$BurstDirectCall
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

		[CalledBy(Type = typeof(InstanceCullerBurst), Member = "SetupCullingJobInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[Calls(Type = typeof(ReceiverPlanes), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = typeof(ReceiverPlanes))]
		[Calls(Type = typeof(ReceiverSphereCuller), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = typeof(ReceiverSphereCuller))]
		[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[Calls(Type = typeof(FrustumPlaneCuller), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(ReceiverSphereCuller&), typeof(Allocator)}, ReturnType = typeof(FrustumPlaneCuller))]
		[Calls(Type = typeof(LODGroupRenderingUtils), Member = "CalculateScreenRelativeMetric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODParameters), typeof(float)}, ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 6)]
		public static void Invoke(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class SetupCullingJobInput_00000146$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		public SetupCullingJobInput_00000146$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public override void Invoke(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric) { }

	}


	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CalledBy(Type = typeof(InstanceCuller), Member = "CreateFrustumCullingJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(ReadOnly&), typeof(ReadOnly&), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.LODGroupCullingData>), typeof(BinningConfig&), typeof(float), typeof(OcclusionCullingCommon), typeof(Unity.Collections.NativeArray`1<System.Byte>), typeof(Unity.Collections.NativeArray`1<System.Byte>)}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetupCullingJobInput_00000146$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(BatchCullingContext*), typeof(ReceiverPlanes*), typeof(ReceiverSphereCuller*), typeof(FrustumPlaneCuller*), typeof(Single*)}, ReturnType = typeof(void))]
	[MonoPInvokeCallback(typeof(SetupCullingJobInput_00000146$PostfixBurstDelegate))]
	public static void SetupCullingJobInput(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric) { }

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReceiverPlanes), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = typeof(ReceiverPlanes))]
	[Calls(Type = typeof(ReceiverSphereCuller), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Allocator)}, ReturnType = typeof(ReceiverSphereCuller))]
	[Calls(Type = typeof(NativeList`1), Member = "AsArray", ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(FrustumPlaneCuller), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BatchCullingContext&), typeof(Unity.Collections.NativeArray`1<UnityEngine.Plane>), typeof(ReceiverSphereCuller&), typeof(Allocator)}, ReturnType = typeof(FrustumPlaneCuller))]
	[Calls(Type = typeof(LODGroupRenderingUtils), Member = "CalculateScreenRelativeMetric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LODParameters), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	internal static void SetupCullingJobInput$BurstManaged(float lodBias, BatchCullingContext* context, ReceiverPlanes* receiverPlanes, ReceiverSphereCuller* receiverSphereCuller, FrustumPlaneCuller* frustumPlaneCuller, Single* screenRelativeMetric) { }

}

