namespace UnityEngine.Rendering;

public struct GPUSort
{
	internal struct Args
	{
		public uint count; //Field offset: 0x0
		public uint maxDepth; //Field offset: 0x4
		public GraphicsBuffer inputKeys; //Field offset: 0x8
		public GraphicsBuffer inputValues; //Field offset: 0x10
		public SupportResources resources; //Field offset: 0x18
		internal int workGroupCount; //Field offset: 0x28

	}

	internal struct RenderGraphResources
	{
		public BufferHandle sortBufferKeys; //Field offset: 0x0
		public BufferHandle sortBufferValues; //Field offset: 0xC

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BufferDesc), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Target)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderGraphBuilder), Member = "CreateTransientBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&)}, ReturnType = typeof(BufferHandle))]
		[CallsUnknownMethods(Count = 2)]
		public static RenderGraphResources Create(int count, RenderGraph renderGraph, RenderGraphBuilder builder) { }

	}

	private enum Stage
	{
		LocalBMS = 0,
		LocalDisperse = 1,
		BigFlip = 2,
		BigDisperse = 3,
	}

	internal struct SupportResources
	{
		public GraphicsBuffer sortBufferKeys; //Field offset: 0x0
		public GraphicsBuffer sortBufferValues; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BufferHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferHandle)}, ReturnType = typeof(GraphicsBuffer))]
		[CallsUnknownMethods(Count = 2)]
		public static SupportResources Load(RenderGraphResources renderGraphResources) { }

	}

	internal struct SystemResources
	{
		public ComputeShader computeAsset; //Field offset: 0x0

	}

	private const uint kWorkGroupSize = 1024; //Field offset: 0x0
	private LocalKeyword[] m_Keywords; //Field offset: 0x0
	private SystemResources resources; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public GPUSort(SystemResources resources) { }

	[CalledBy(Type = typeof(GPUSort), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Args)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CopyBuffer(CommandBuffer cmd, GraphicsBuffer src, GraphicsBuffer dst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUSort), Member = "CopyBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(GraphicsBuffer), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(GPUSort), Member = "DispatchStage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Args), typeof(uint), typeof(Stage)}, ReturnType = typeof(void))]
	public void Dispatch(CommandBuffer cmd, Args args) { }

	[CalledBy(Type = typeof(GPUSort), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Args)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeIntParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void DispatchStage(CommandBuffer cmd, Args args, uint h, Stage stage) { }

	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static int DivRoundUp(int x, int y) { }

}

