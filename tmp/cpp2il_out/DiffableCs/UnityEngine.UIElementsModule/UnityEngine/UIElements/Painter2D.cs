namespace UnityEngine.UIElements;

public class Painter2D : IDisposable
{
	private struct Painter2DJob : IJobParallelFor
	{
		[NativeDisableUnsafePtrRestriction]
		public IntPtr painterHandle; //Field offset: 0x0
		[ReadOnly]
		public TempMeshAllocator allocator; //Field offset: 0x8
		[ReadOnly]
		public NativeSlice<Painter2DJobData> jobParameters; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeSlice`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(UIPainter2D), Member = "ExecuteSnapshotFromJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryRecorder), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public override void Execute(int i) { }

	}

	private struct Painter2DJobData
	{
		public UnsafeMeshGenerationNode node; //Field offset: 0x0
		public int snapshotIndex; //Field offset: 0x8

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <isPainterActive>k__BackingField; //Field offset: 0x0
	private static readonly ProfilerMarker s_StrokeMarker; //Field offset: 0x8
	private static readonly ProfilerMarker s_FillMarker; //Field offset: 0x10
	private MeshGenerationContext m_Ctx; //Field offset: 0x10
	internal DetachedAllocator m_DetachedAllocator; //Field offset: 0x18
	internal SafeHandleAccess m_Handle; //Field offset: 0x20
	private List<Painter2DJobData> m_JobSnapshots; //Field offset: 0x28
	private NativeArray<Painter2DJobData> m_JobParameters; //Field offset: 0x30
	private bool m_Disposed; //Field offset: 0x40
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x48

	internal static bool isPainterActive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 83
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static Painter2D() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIPainter2D), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal Painter2D(MeshGenerationContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(DetachedAllocator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIPainter2D), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public Painter2D() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DetachedAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "ClearSnapshots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPainter2D), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void Reset() { }

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "ScheduleMeshGenerationJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "CreateNativeHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Painter2DJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Painter2DJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void ScheduleJobs(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_isPainterActive(bool value) { }

}

