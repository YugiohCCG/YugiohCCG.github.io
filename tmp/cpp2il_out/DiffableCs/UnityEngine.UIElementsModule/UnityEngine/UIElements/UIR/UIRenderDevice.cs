namespace UnityEngine.UIElements.UIR;

internal class UIRenderDevice : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MeshHandle> <>9__58_0; //Field offset: 0x8
		public static Action<MeshHandle> <>9__58_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshHandle), Member = ".ctor", ReturnType = typeof(void))]
		internal MeshHandle <.ctor>b__58_0() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		internal void <.ctor>b__58_1(MeshHandle mh) { }

	}

	private struct AllocToFree
	{
		public Alloc alloc; //Field offset: 0x0
		public Page page; //Field offset: 0x18
		public bool vertices; //Field offset: 0x20

	}

	public struct AllocToUpdate
	{
		public uint id; //Field offset: 0x0
		public uint allocTime; //Field offset: 0x4
		public MeshHandle meshHandle; //Field offset: 0x8
		public Alloc permAllocVerts; //Field offset: 0x10
		public Alloc permAllocIndices; //Field offset: 0x28
		public Page permPage; //Field offset: 0x40
		public bool copyBackIndices; //Field offset: 0x48

	}

	private struct DeviceToFree
	{
		public uint handle; //Field offset: 0x0
		public Page page; //Field offset: 0x8
		public List<CommandList>[] commandLists; //Field offset: 0x10

		[CalledBy(Type = typeof(UIRenderDevice), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CommandList), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public void Dispose() { }

	}

	public struct DrawStatistics
	{
		public int currentFrameIndex; //Field offset: 0x0
		public uint totalIndices; //Field offset: 0x4
		public uint commandCount; //Field offset: 0x8
		public uint skippedCommandCount; //Field offset: 0xC
		public uint drawCommandCount; //Field offset: 0x10
		public uint disableCommandCount; //Field offset: 0x14
		public uint materialSetCount; //Field offset: 0x18
		public uint drawRangeCount; //Field offset: 0x1C
		public uint drawRangeCallCount; //Field offset: 0x20
		public uint immediateDraws; //Field offset: 0x24
		public uint stencilRefChanges; //Field offset: 0x28

	}

	private struct EvaluationState
	{
		public CommandList activeCommandList; //Field offset: 0x0
		public MaterialPropertyBlock constantProps; //Field offset: 0x8
		public MaterialPropertyBlock batchProps; //Field offset: 0x10
		public Material defaultMat; //Field offset: 0x18
		public State curState; //Field offset: 0x20
		public Page curPage; //Field offset: 0x38
		public bool mustApplyMaterial; //Field offset: 0x40
		public bool mustApplyBatchProps; //Field offset: 0x41
		public bool mustApplyStencil; //Field offset: 0x42

	}

	private static LinkedList<DeviceToFree> m_DeviceFreeQueue; //Field offset: 0x0
	private static int m_ActiveDeviceCount; //Field offset: 0x8
	private static bool m_SubscribedToNotifications; //Field offset: 0xC
	private static bool m_SynchronousFree; //Field offset: 0xD
	private static readonly int s_GradientSettingsTexID; //Field offset: 0x10
	private static readonly int s_ShaderInfoTexID; //Field offset: 0x14
	private static ProfilerMarker s_MarkerAllocate; //Field offset: 0x18
	private static ProfilerMarker s_MarkerFree; //Field offset: 0x20
	private static ProfilerMarker s_MarkerAdvanceFrame; //Field offset: 0x28
	private static ProfilerMarker s_MarkerFence; //Field offset: 0x30
	private static ProfilerMarker s_MarkerBeforeDraw; //Field offset: 0x38
	private readonly bool m_MockDevice; //Field offset: 0x10
	private IntPtr m_DefaultStencilState; //Field offset: 0x18
	private IntPtr m_VertexDecl; //Field offset: 0x20
	private Page m_FirstPage; //Field offset: 0x28
	private uint m_NextPageVertexCount; //Field offset: 0x30
	private uint m_LargeMeshVertexCount; //Field offset: 0x34
	private float m_IndexToVertexCountRatio; //Field offset: 0x38
	private List<List`1<AllocToFree>> m_DeferredFrees; //Field offset: 0x40
	private List<List`1<AllocToUpdate>> m_Updates; //Field offset: 0x48
	private List<CommandList>[] m_CommandLists; //Field offset: 0x50
	private UInt32[] m_Fences; //Field offset: 0x58
	private MaterialPropertyBlock m_ConstantProps; //Field offset: 0x60
	private MaterialPropertyBlock m_BatchProps; //Field offset: 0x68
	private uint m_FrameIndex; //Field offset: 0x70
	private uint m_NextUpdateID; //Field offset: 0x74
	private DrawStatistics m_DrawStats; //Field offset: 0x78
	private readonly LinkedPool<MeshHandle> m_MeshHandles; //Field offset: 0xA8
	private readonly DrawParams m_DrawParams; //Field offset: 0xB0
	private readonly TextureSlotManager m_TextureSlotManager; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <breakBatches>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isFlat>k__BackingField; //Field offset: 0xC1
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawsInCameras>k__BackingField; //Field offset: 0xC2
	internal int currentFrameCommandListCount; //Field offset: 0xC4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0xC8

	internal bool breakBatches
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal List<CommandList>[] commandLists
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal List<CommandList> currentFrameCommandLists
	{
		[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 61
	}

	protected private bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	internal bool drawsInCameras
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal uint frameIndex
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	private bool fullyCreated
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 11
	}

	internal bool isFlat
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	internal static uint maxVerticesPerPage
	{
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private static UIRenderDevice() { }

	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	public UIRenderDevice(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawParams), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Page), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 57)]
	[ContainsUnimplementedInstructions]
	public void AdvanceFrame() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(MeshHandle))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Page), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderDevice), Member = "CompleteCreation", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, bool shortLived) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "StartNewBatch", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void ApplyBatchState(ref EvaluationState st) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureSlotManager), Member = "FindOldestSlot", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextureSlotManager), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(float), typeof(float), typeof(int), typeof(MaterialPropertyBlock), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRenderDevice), Member = "InitVertexDeclaration", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_passOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_failOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_zFailOperationFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StencilState), Member = "set_zFailOperationBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StencilOp)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void CompleteCreation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceToFree)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<UnityEngine.UIElements.UIR.UIRenderDevice+DeviceToFree>))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceToFree), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(RenderChain), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList) { }

	[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "get_currentFrameCommandLists", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.CommandList>))]
	[Calls(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ApplyBatchState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EvaluationState&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureSlotManager), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawParams), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateFenceValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, ref Exception immediateException) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void FlushAllPendingDeviceDisposes() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "FreeExtraMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public void Free(MeshHandle mesh) { }

	[CalledBy(Type = typeof(RenderChain), Member = "DrawStats", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal DrawStatistics GatherDrawStatistics() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_breakBatches() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal List<CommandList>[] get_commandLists() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal List<CommandList> get_currentFrameCommandLists() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_disposed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_drawsInCameras() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal uint get_frameIndex() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_fullyCreated() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_isFlat() { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	internal static uint get_maxVerticesPerPage() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "CompleteCreation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 4)]
	private void InitVertexDeclaration() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UIRenderDevice), Member = "DrawRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<System.UInt16>), typeof(UnityEngine.UIElements.UIR.Utility+GPUBuffer`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.DrawBufferRange>), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	private static void OnEngineUpdateGlobal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	private static void OnFlushPendingResources() { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "SendUpdates", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateFenceValue", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnFrameRenderingBegin() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void PrepareForGfxDeviceRecreate() { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "FlushAllPendingDeviceDisposes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnEngineUpdateGlobal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFlushPendingResources", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DeviceToFree), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveFirst", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static void ProcessDeviceFreeQueue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Page), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Page), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void PruneUnusedPages() { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "KickRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawBufferRange*), typeof(Int32&), typeof(Int32&), typeof(int), typeof(Page), typeof(CommandList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeSliceUnsafeUtility), Member = "ConvertExistingDataToNativeSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static NativeSlice<T> PtrToSlice(Void* p, int count) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_breakBatches(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_drawsInCameras(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_isFlat(bool value) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "PrepareNudgeVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(UIRenderDevice), typeof(MeshHandle), typeof(IntPtr&), typeof(IntPtr&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex>& vertexData) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "UpdateOrAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle&), typeof(int), typeof(int), typeof(UIRenderDevice), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(NativeSlice`1<Vertex>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet`1), Member = "RegisterUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocToUpdate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void UpdateFenceValue() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void WaitOnCpuFence(uint fence) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnGraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static void WrapUpGfxDeviceRecreate() { }

}

