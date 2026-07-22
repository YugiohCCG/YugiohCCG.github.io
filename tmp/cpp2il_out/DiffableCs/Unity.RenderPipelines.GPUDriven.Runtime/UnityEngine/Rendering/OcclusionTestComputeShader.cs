namespace UnityEngine.Rendering;

internal struct OcclusionTestComputeShader
{
	public ComputeShader cs; //Field offset: 0x0
	public LocalKeyword occlusionDebugKeyword; //Field offset: 0x8

	[CalledBy(Type = typeof(InstanceCuller), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerResources), typeof(DebugRendererBatcherStats)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Init(ComputeShader cs) { }

}

