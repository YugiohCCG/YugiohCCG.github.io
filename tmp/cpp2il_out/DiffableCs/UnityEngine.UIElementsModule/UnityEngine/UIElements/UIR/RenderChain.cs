namespace UnityEngine.UIElements.UIR;

internal class RenderChain : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RenderChainCommand> <>9__31_0; //Field offset: 0x8
		public static Action<RenderChainCommand> <>9__31_1; //Field offset: 0x10
		public static Func<ExtraRenderChainVEData> <>9__31_2; //Field offset: 0x18
		public static Action<ExtraRenderChainVEData> <>9__31_3; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderChainCommand), Member = ".ctor", ReturnType = typeof(void))]
		internal RenderChainCommand <.ctor>b__31_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderChainCommand), Member = "Reset", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.ctor>b__31_1(RenderChainCommand r) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal ExtraRenderChainVEData <.ctor>b__31_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal void <.ctor>b__31_3(ExtraRenderChainVEData e) { }

	}

	private struct DepthOrderedDirtyTracking
	{
		public List<VisualElement> heads; //Field offset: 0x0
		public List<VisualElement> tails; //Field offset: 0x8
		public Int32[] minDepths; //Field offset: 0x10
		public Int32[] maxDepths; //Field offset: 0x18
		public uint dirtyID; //Field offset: 0x20

		[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "ChildWillBeRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

		[CalledBy(Type = typeof(RenderChain), Member = "EnsureFitsDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void EnsureFits(int maxDepth) { }

		[CalledBy(Type = typeof(RenderChain), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnOpacityIdChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "UIEOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

		[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void Reset() { }

	}

	private class VisualChangesProcessor : IDisposable
	{
		private struct EntryProcessingInfo
		{
			public VisualElement visualElement; //Field offset: 0x0
			public VisualsProcessingType type; //Field offset: 0x8
			public Entry rootEntry; //Field offset: 0x10

		}

		private enum VisualsProcessingType
		{
			Head = 0,
			Tail = 1,
		}

		private static readonly ProfilerMarker k_GenerateEntriesMarker; //Field offset: 0x0
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; //Field offset: 0x8
		private static readonly ProfilerMarker k_UpdateOpacityIdMarker; //Field offset: 0x10
		private RenderChain m_RenderChain; //Field offset: 0x10
		private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x18
		private BaseElementBuilder m_ElementBuilder; //Field offset: 0x20
		private List<EntryProcessingInfo> m_EntryProcessingList; //Field offset: 0x28
		private List<EntryProcessor> m_Processors; //Field offset: 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <disposed>k__BackingField; //Field offset: 0x38

		protected private bool disposed
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		public BaseElementBuilder elementBuilder
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public MeshGenerationContext meshGenerationContext
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
		private static VisualChangesProcessor() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutManager), Member = "GetManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(LayoutManager))]
		[Calls(Type = typeof(LayoutManager), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
		[Calls(Type = typeof(LayoutManager), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
		[Calls(Type = typeof(LayoutManager), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(LayoutManager), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutManager), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		public VisualChangesProcessor(RenderChain renderChain) { }

		[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(EntryProcessor), Member = "ProcessTail", ReturnType = typeof(void))]
		[Calls(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = "ProcessHead", ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryProcessor), Member = "ClearReferences", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public void ConvertEntriesToCommands(ref ChainBuilderStats stats) { }

		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "ProcessOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(RenderChainVEData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
		[Calls(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[Calls(Type = typeof(RenderChain), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(ExtraRenderChainVEData))]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(MeshHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		private void DepthFirstOnVisualsChanged(VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		protected void Dispose(bool disposing) { }

		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualChangesProcessor), Member = "UpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(NativeSlice`1<Vertex>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "OpacityAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
		[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.OpacityIdAccelerator+OpacityIdUpdateJob"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.OpacityIdAccelerator+OpacityIdUpdateJob", typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
		[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		protected bool get_disposed() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public BaseElementBuilder get_elementBuilder() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public MeshGenerationContext get_meshGenerationContext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public void ProcessOnVisualsChanged(VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void ScheduleMeshGenerationJobs() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_disposed(bool value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(MeshHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderChain), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(ExtraRenderChainVEData))]
		[CallsUnknownMethods(Count = 1)]
		public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private static void UpdateWorldFlipsWinding(VisualElement ve) { }

	}

	private static EntryPool s_SharedEntryPool; //Field offset: 0x0
	private static readonly ProfilerMarker k_MarkerProcess; //Field offset: 0x8
	private static readonly ProfilerMarker k_MarkerClipProcessing; //Field offset: 0x10
	private static readonly ProfilerMarker k_MarkerOpacityProcessing; //Field offset: 0x18
	private static readonly ProfilerMarker k_MarkerColorsProcessing; //Field offset: 0x20
	private static readonly ProfilerMarker k_MarkerTransformProcessing; //Field offset: 0x28
	private static readonly ProfilerMarker k_MarkerVisualsProcessing; //Field offset: 0x30
	private static readonly ProfilerMarker k_MarkerSerialize; //Field offset: 0x38
	private RenderChainCommand m_FirstCommand; //Field offset: 0x10
	private DepthOrderedDirtyTracking m_DirtyTracker; //Field offset: 0x18
	private VisualChangesProcessor m_VisualChangesProcessor; //Field offset: 0x40
	private LinkedPool<RenderChainCommand> m_CommandPool; //Field offset: 0x48
	private LinkedPool<ExtraRenderChainVEData> m_ExtraDataPool; //Field offset: 0x50
	private BasicNodePool<MeshHandle> m_MeshHandleNodePool; //Field offset: 0x58
	private BasicNodePool<TextureEntry> m_TexturePool; //Field offset: 0x60
	private Dictionary<VisualElement, ExtraRenderChainVEData> m_ExtraData; //Field offset: 0x68
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x70
	private Material m_DefaultMat; //Field offset: 0x78
	private bool m_BlockDirtyRegistration; //Field offset: 0x80
	private ChainBuilderStats m_Stats; //Field offset: 0x84
	private uint m_StatsElementsAdded; //Field offset: 0xE0
	private uint m_StatsElementsRemoved; //Field offset: 0xE4
	private TextureRegistry m_TextureRegistry; //Field offset: 0xE8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private BaseVisualElementPanel <panel>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UIRenderDevice <device>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AtlasBase <atlas>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VectorImageManager <vectorImageManager>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TempMeshAllocatorImpl <tempMeshAllocator>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly MeshWriteDataPool <meshWriteDataPool>k__BackingField; //Field offset: 0x128
	public EntryRecorder entryRecorder; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private MeshGenerationNodeManager <meshGenerationNodeManager>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private JobManager <jobManager>k__BackingField; //Field offset: 0x140
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; //Field offset: 0x148
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawStats>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <drawInCameras>k__BackingField; //Field offset: 0x151
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <isFlat>k__BackingField; //Field offset: 0x152
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <forceGammaRendering>k__BackingField; //Field offset: 0x153

	internal AtlasBase atlas
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal UIRenderDevice device
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
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

	internal bool drawInCameras
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal bool drawStats
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public BaseElementBuilder elementBuilder
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	internal EntryPool entryPool
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 78
	}

	public bool forceGammaRendering
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal bool isFlat
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal JobManager jobManager
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public MeshGenerationDeferrer meshGenerationDeferrer
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private MeshGenerationNodeManager meshGenerationNodeManager
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal MeshWriteDataPool meshWriteDataPool
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	public private OpacityIdAccelerator opacityIdAccelerator
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal BaseVisualElementPanel panel
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal ChainBuilderStats statsByRef
	{
		[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal get { } //Length: 8
	}

	internal TempMeshAllocatorImpl tempMeshAllocator
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	internal VectorImageManager vectorImageManager
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	private static RenderChain() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "CreateRenderChain", ReturnType = typeof(RenderChain))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRenderDevice), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VectorImageManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel), typeof(UIRenderDevice), typeof(AtlasBase), typeof(VectorImageManager)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public RenderChain(BaseVisualElementPanel panel) { }

	[CalledBy(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shaders), Member = "GetOrCreateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(string)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntryRecorder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryRecorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntryPool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImplicitPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BasicNodePool`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 39)]
	protected RenderChain(BaseVisualElementPanel panel, UIRenderDevice device, AtlasBase atlas, VectorImageManager vectorImageManager) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "CreateMeshDrawCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(int), typeof(int), typeof(Material), typeof(TextureId)}, ReturnType = typeof(RenderChainCommand))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	internal RenderChainCommand AllocCommand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "ClearDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal void ChildWillBeRemoved(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderChain), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(RenderChain), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TempAllocator`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.TempAllocator`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	protected void Dispose(bool disposing) { }

	[CalledBy(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "GatherDrawStatistics", ReturnType = typeof(DrawStatistics))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DrawStats() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "EnsureFits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	internal void EnsureFitsDepth(int depth) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveSingleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RenderChainCommand), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FreeCommand(RenderChainCommand cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void FreeExtraData(VisualElement ve) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void FreeExtraMeshes(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal AtlasBase get_atlas() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal UIRenderDevice get_device() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_disposed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_drawInCameras() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_drawStats() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public BaseElementBuilder get_elementBuilder() { }

	[CallerCount(Count = 0)]
	internal EntryPool get_entryPool() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public bool get_forceGammaRendering() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_isFlat() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal JobManager get_jobManager() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public MeshGenerationDeferrer get_meshGenerationDeferrer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MeshGenerationNodeManager get_meshGenerationNodeManager() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal MeshWriteDataPool get_meshWriteDataPool() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal BaseVisualElementPanel get_panel() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.EntryPreProcessor+AllocSize>), typeof(MeshHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal ChainBuilderStats get_statsByRef() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal TempMeshAllocatorImpl get_tempMeshAllocator() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal VectorImageManager get_vectorImageManager() { }

	[CallerCount(Count = 0)]
	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }

	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "UpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public ExtraRenderChainVEData GetOrAddExtraData(VisualElement ve) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessNextAlloc", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderChain), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(ExtraRenderChainVEData))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(BasicNode`1), Member = "InsertFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BasicNode`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void InsertExtraMesh(VisualElement ve, MeshHandle mesh) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(BasicNode`1), Member = "InsertFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BasicNode`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "InjectCommandInBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(RenderChainCommand), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	[CalledBy(Type = typeof(CommandManipulator), Member = "ReplaceCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(EntryProcessor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(RenderChainCommand), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandManipulator), Member = "RemoveSingleCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "IssuePendingStorageChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GradientSettingsAtlas), Member = "Commit", ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPool), Member = "ReturnAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(ImplicitPool`1), Member = "ReturnAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(TempMeshAllocatorImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationNodeManager), Member = "ResetAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobManager), Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualChangesProcessor), Member = "ConvertEntriesToCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationDeferrer), Member = "ProcessDeferredWork", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "ClearDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "ProcessOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "SerializeCommandsForCameras", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void ProcessChanges() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "get_atlas", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(GL), Member = "set_modelview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "LoadProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProjectionUtils), Member = "Ortho", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "DrawStats", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GL), Member = "set_invertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "get_invertCulling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImmediateModeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void Render() { }

	[CalledBy(Type = typeof(AtlasBase), Member = "RepaintTexturedElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void RepaintTexturedElements() { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextureRegistry), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ResetTextures(VisualElement ve) { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "get_atlas", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(UIRenderDevice), Member = "EvaluateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand), typeof(Material), typeof(Material), typeof(Texture), typeof(Texture), typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "get_currentFrameCommandLists", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.CommandList>))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderer), Member = "SetNativeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private void SerializeCommandsForCameras() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_atlas(AtlasBase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_device(UIRenderDevice value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_drawStats(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_jobManager(JobManager value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_meshGenerationNodeManager(MeshGenerationNodeManager value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_panel(BaseVisualElementPanel value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_tempMeshAllocator(TempMeshAllocatorImpl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_vectorImageManager(VectorImageManager value) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "InitRenderChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Hierarchy), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public void UIEOnChildAdded(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnChildRemoving(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public void UIEOnChildrenReordered(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnColorChanged(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_disableRendering", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandManipulator), Member = "DisableElementRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnDisableRenderingChanged(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "MarkRenderHintsClean", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DepthOrderedDirtyTracking), Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

}

