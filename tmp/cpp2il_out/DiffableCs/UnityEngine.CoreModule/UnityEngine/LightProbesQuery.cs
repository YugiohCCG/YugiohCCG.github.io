namespace UnityEngine;

[NativeContainer]
[NativeHeader("Runtime/Camera/RenderLoops/LightProbeContext.h")]
[StaticAccessor("LightProbeContextWrapper", StaticAccessorType::DoubleColon (2))]
public struct LightProbesQuery : IDisposable
{
	[NativeContainer]
	public struct LightProbesQueryDispose
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_LightProbeContextWrapper; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public void Dispose() { }

	}

	public struct LightProbesQueryDisposeJob : IJob
	{
		internal LightProbesQueryDispose Data; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override void Execute() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal IntPtr m_LightProbeContextWrapper; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x8

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "ScheduleInterpolateProbesAndUpdateTetrahedronCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Vector3>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public LightProbesQuery(Allocator allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+CalculateInterpolatedLightAndOcclusionProbesBatchJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	public void CalculateInterpolatedLightAndOcclusionProbes(NativeArray<Vector3> positions, NativeArray<Int32> tetrahedronIndices, NativeArray<SphericalHarmonicsL2> lightProbes, NativeArray<Vector4> occlusionProbes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static void CalculateInterpolatedLightAndOcclusionProbes(IntPtr lightProbeContextWrapper, IntPtr positions, IntPtr tetrahedronIndices, IntPtr lightProbes, IntPtr occlusionProbes, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static void Destroy(IntPtr lightProbeContextWrapper) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "ScheduleInterpolateProbesAndUpdateTetrahedronCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Vector3>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>"}, ReturnType = typeof(JobHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightProbesQueryDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightProbesQueryDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public JobHandle Dispose(JobHandle inputDeps) { }

}

