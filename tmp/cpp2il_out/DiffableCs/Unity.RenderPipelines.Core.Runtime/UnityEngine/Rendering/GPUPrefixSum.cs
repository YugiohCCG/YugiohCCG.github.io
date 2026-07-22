namespace UnityEngine.Rendering;

public struct GPUPrefixSum
{
	internal struct DirectArgs
	{
		public bool exclusive; //Field offset: 0x0
		public int inputCount; //Field offset: 0x4
		public GraphicsBuffer input; //Field offset: 0x8
		public SupportResources supportResources; //Field offset: 0x10

	}

	internal struct IndirectDirectArgs
	{
		public bool exclusive; //Field offset: 0x0
		public int inputCountBufferByteOffset; //Field offset: 0x4
		public ComputeBuffer inputCountBuffer; //Field offset: 0x8
		public GraphicsBuffer input; //Field offset: 0x10
		public SupportResources supportResources; //Field offset: 0x18

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
	internal struct LevelOffsets
	{
		public uint count; //Field offset: 0x0
		public uint offset; //Field offset: 0x4
		public uint parentOffset; //Field offset: 0x8

	}

	internal struct RenderGraphResources
	{
		internal int alignedElementCount; //Field offset: 0x0
		internal int maxBufferCount; //Field offset: 0x4
		internal int maxLevelCount; //Field offset: 0x8
		internal BufferHandle prefixBuffer0; //Field offset: 0xC
		internal BufferHandle prefixBuffer1; //Field offset: 0x18
		internal BufferHandle totalLevelCountBuffer; //Field offset: 0x24
		internal BufferHandle levelOffsetBuffer; //Field offset: 0x30
		internal BufferHandle indirectDispatchArgsBuffer; //Field offset: 0x3C

		public BufferHandle output
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 19
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderGraphResources), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(void))]
		public static RenderGraphResources Create(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false) { }

		[CallerCount(Count = 0)]
		public BufferHandle get_output() { }

		[CalledBy(Type = typeof(RenderGraphResources), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraph), typeof(RenderGraphBuilder), typeof(bool)}, ReturnType = typeof(RenderGraphResources))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BufferDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Target)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderGraphBuilder), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
		[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
		[Calls(Type = typeof(RenderGraphBuilder), Member = "WriteBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle&)}, ReturnType = typeof(BufferHandle))]
		[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 6)]
		private void Initialize(int newMaxElementCount, RenderGraph renderGraph, RenderGraphBuilder builder, bool outputIsTemp = false) { }

	}

	[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\Utilities\\GPUPrefixSum\\GPUPrefixSum.Data.cs")]
	public static class ShaderDefs
	{
		public const int GroupSize = 128; //Field offset: 0x0
		public const int ArgsBufferStride = 16; //Field offset: 0x0
		public const int ArgsBufferUpper = 0; //Field offset: 0x0
		public const int ArgsBufferLower = 8; //Field offset: 0x0

		[CallerCount(Count = 0)]
		public static int AlignUpGroup(int value) { }

		[CallerCount(Count = 0)]
		public static void CalculateTotalBufferSize(int maxElementCount, out int totalSize, out int levelCounts) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public static int DivUpGroup(int value) { }

	}

	private static class ShaderIDs
	{
		public static readonly int _InputBuffer; //Field offset: 0x0
		public static readonly int _OutputBuffer; //Field offset: 0x4
		public static readonly int _InputCountBuffer; //Field offset: 0x8
		public static readonly int _TotalLevelsBuffer; //Field offset: 0xC
		public static readonly int _OutputTotalLevelsBuffer; //Field offset: 0x10
		public static readonly int _OutputDispatchLevelArgsBuffer; //Field offset: 0x14
		public static readonly int _LevelsOffsetsBuffer; //Field offset: 0x18
		public static readonly int _OutputLevelsOffsetsBuffer; //Field offset: 0x1C
		public static readonly int _PrefixSumIntArgs; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderIDs() { }

	}

	internal struct SupportResources
	{
		internal bool ownsResources; //Field offset: 0x0
		internal int alignedElementCount; //Field offset: 0x4
		internal int maxBufferCount; //Field offset: 0x8
		internal int maxLevelCount; //Field offset: 0xC
		internal GraphicsBuffer prefixBuffer0; //Field offset: 0x10
		internal GraphicsBuffer prefixBuffer1; //Field offset: 0x18
		internal GraphicsBuffer totalLevelCountBuffer; //Field offset: 0x20
		internal GraphicsBuffer levelOffsetBuffer; //Field offset: 0x28
		internal GraphicsBuffer indirectDispatchArgsBuffer; //Field offset: 0x30

		public GraphicsBuffer output
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal static void <Dispose>g__TryFreeBuffer|15_0(GraphicsBuffer resource) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SupportResources), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		public static SupportResources Create(int maxElementCount) { }

		[CalledBy(Type = typeof(SupportResources), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		public void Dispose() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public GraphicsBuffer get_output() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SupportResources), Member = "LoadFromShaderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResources)}, ReturnType = typeof(void))]
		public static SupportResources Load(RenderGraphResources shaderGraphResources) { }

		[CalledBy(Type = typeof(SupportResources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResources)}, ReturnType = typeof(SupportResources))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private void LoadFromShaderGraph(RenderGraphResources shaderGraphResources) { }

		[CalledBy(Type = typeof(SupportResources), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SupportResources))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SupportResources), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Marshal), Member = "SizeOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		internal void Resize(int newMaxElementCount) { }

	}

	internal struct SystemResources
	{
		public ComputeShader computeAsset; //Field offset: 0x0
		internal int kernelCalculateLevelDispatchArgsFromConst; //Field offset: 0x8
		internal int kernelCalculateLevelDispatchArgsFromBuffer; //Field offset: 0xC
		internal int kernelPrefixSumOnGroup; //Field offset: 0x10
		internal int kernelPrefixSumOnGroupExclusive; //Field offset: 0x14
		internal int kernelPrefixSumNextInput; //Field offset: 0x18
		internal int kernelPrefixSumResolveParent; //Field offset: 0x1C
		internal int kernelPrefixSumResolveParentExclusive; //Field offset: 0x20

		[CalledBy(Type = typeof(GPUPrefixSum), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SystemResources)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal void LoadKernels() { }

	}

	private SystemResources resources; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemResources), Member = "LoadKernels", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public GPUPrefixSum(SystemResources resources) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUPrefixSum), Member = "ExecuteCommonIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(SupportResources&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public void DispatchDirect(CommandBuffer cmdBuffer, in DirectArgs arguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUPrefixSum), Member = "ExecuteCommonIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(SupportResources&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public void DispatchIndirect(CommandBuffer cmdBuffer, in IndirectDirectArgs arguments) { }

	[CalledBy(Type = typeof(GPUPrefixSum), Member = "DispatchDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(DirectArgs&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUPrefixSum), Member = "DispatchIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(IndirectDirectArgs&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "DispatchCompute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(GraphicsBuffer), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	internal void ExecuteCommonIndirect(CommandBuffer cmdBuffer, GraphicsBuffer inputBuffer, in SupportResources supportResources, bool isExclusive) { }

	[CallerCount(Count = 0)]
	private Vector4 PackPrefixSumArgs(int a, int b, int c, int d) { }

}

