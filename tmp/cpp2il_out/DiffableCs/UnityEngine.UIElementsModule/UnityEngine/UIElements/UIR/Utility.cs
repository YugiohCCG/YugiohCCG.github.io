namespace UnityEngine.UIElements.UIR;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal class Utility
{
	internal class GPUBuffer : IDisposable
	{
		private IntPtr buffer; //Field offset: 0x0
		private int elemCount; //Field offset: 0x0
		private int elemStride; //Field offset: 0x0

		internal IntPtr BufferPointer
		{
			[CallerCount(Count = 206)]
			[DeduplicatedMethod]
			internal get { } //Length: 7
		}

		public int ElementStride
		{
			[CallerCount(Count = 8)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CalledBy(Type = typeof(DataSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Utility), Member = "AllocateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public GPUBuffer`1(int elementCount, GPUBufferType type) { }

		[CalledBy(Type = typeof(DataSet`1), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Utility), Member = "FreeBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		internal IntPtr get_BufferPointer() { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		public int get_ElementStride() { }

		[CalledBy(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendFullRange", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendPartialRanges", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Utility), Member = "UpdateBufferRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	}

	public enum GPUBufferType
	{
		Vertex = 0,
		Index = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> GraphicsResourcesRecreate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action EngineUpdate; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action FlushPendingResources; //Field offset: 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; //Field offset: 0x18

	public static event Action EngineUpdate
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static event Action FlushPendingResources
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static event Action<Boolean> GraphicsResourcesRecreate
	{
		[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 259
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 259
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static Utility() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_EngineUpdate(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_FlushPendingResources(Action value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[CalledBy(Type = typeof(GPUBuffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GPUBufferType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static bool CPUFencePassed(uint fence) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateStencilState_Injected(in StencilState stencilState) { }

	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void DisableScissor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[CalledBy(Type = typeof(GPUBuffer`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static void FreeBuffer(IntPtr buffer) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "RectPointsToPixelsAndFlipYAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float)}, ReturnType = typeof(RectInt))]
	[CalledBy(Type = typeof(TextureBlitter), Member = "BeginBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static RectInt GetActiveViewport() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetActiveViewport_Injected(out RectInt ret) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetVertexDeclaration_Injected(ref ManagedSpanWrapper vertexAttributes) { }

	[CalledBy(Type = typeof(DataSet`1), Member = "HasMappedBufferRange", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static bool HasMappedBufferRange() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static uint InsertCPUFence() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void NotifyOfUIREvents(bool subscribe) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void ProfileDrawChainBegin() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void ProfileDrawChainEnd() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void RaiseEngineUpdate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void RaiseFlushPendingResources() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_EngineUpdate(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_FlushPendingResources(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[CalledBy(Type = typeof(TextureBlitter), Member = "DoBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.UIElements.UIR.TextureBlitter+BlitInfo>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetPropertyBlock_Injected(IntPtr props) { }

	[CalledBy(Type = typeof(RenderChainCommand), Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChainCommand), Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DrawParams), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void SetScissorRect(RectInt scissorRect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetScissorRect_Injected(in RectInt scissorRect) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void SyncRenderThread() { }

	[CalledBy(Type = typeof(GPUBuffer`1), Member = "UpdateRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static void WaitForCPUFencePassed(uint fence) { }

}

