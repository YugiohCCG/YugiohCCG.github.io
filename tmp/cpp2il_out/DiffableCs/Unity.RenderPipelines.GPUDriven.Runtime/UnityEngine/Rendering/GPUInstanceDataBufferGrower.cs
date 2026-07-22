namespace UnityEngine.Rendering;

internal struct GPUInstanceDataBufferGrower : IDisposable
{
	private static class CopyInstancesKernelIDs
	{
		public static readonly int _InputValidComponentCounts; //Field offset: 0x0
		public static readonly int _InstanceCounts; //Field offset: 0x4
		public static readonly int _InstanceOffset; //Field offset: 0x8
		public static readonly int _OutputInstanceOffset; //Field offset: 0xC
		public static readonly int _ValidComponentIndices; //Field offset: 0x10
		public static readonly int _ComponentByteCounts; //Field offset: 0x14
		public static readonly int _InputComponentAddresses; //Field offset: 0x18
		public static readonly int _OutputComponentAddresses; //Field offset: 0x1C
		public static readonly int _InputComponentInstanceIndexRanges; //Field offset: 0x20
		public static readonly int _InputBuffer; //Field offset: 0x24
		public static readonly int _OutputBuffer; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static CopyInstancesKernelIDs() { }

	}

	internal struct GPUResources : IDisposable
	{
		public ComputeShader cs; //Field offset: 0x0
		public int kernelId; //Field offset: 0x8

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void CreateResources() { }

		[CallerCount(Count = 66)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public void LoadShaders(GPUResidentDrawerResources resources) { }

	}

	private GPUInstanceDataBuffer m_SrcBuffer; //Field offset: 0x0
	private GPUInstanceDataBuffer m_DstBuffer; //Field offset: 0x8

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.NativeArray`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.GPUInstanceComponentDesc>), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public GPUInstanceDataBufferGrower(GPUInstanceDataBuffer sourceBuffer, in InstanceNumInfo instanceNumInfo) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputeShader), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public GPUInstanceDataBuffer SubmitToGpu(ref GPUResources gpuResources) { }

}

