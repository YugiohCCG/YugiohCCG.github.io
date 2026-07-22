namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
public class RenderGraph
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<ProfilingScopePassData, RenderGraphContext> <>9__115_0; //Field offset: 0x8
		public static BaseRenderFunc<ProfilingScopePassData, RenderGraphContext> <>9__116_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <BeginProfilingSampler>b__115_0(ProfilingScopePassData data, RenderGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProfilingSampler), Member = "End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <EndProfilingSampler>b__116_0(ProfilingScopePassData data, RenderGraphContext ctx) { }

	}

	public class CompiledGraph : ICompiledGraph
	{
		public DynamicArray<CompiledResourceInfo>[] compiledResourcesInfos; //Field offset: 0x10
		public DynamicArray<CompiledPassInfo> compiledPassInfos; //Field offset: 0x18
		public int lastExecutionFrame; //Field offset: 0x20

		[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public CompiledGraph() { }

		[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledGraph), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public override void Clear() { }

		[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CompiledGraph), Member = "InitResourceInfosData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
		[Calls(Type = typeof(CompiledPassInfo), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public void InitializeCompilationData(List<RenderGraphPass> passes, RenderGraphResourceRegistry resources) { }

		[CalledBy(Type = typeof(CompiledGraph), Member = "InitializeCompilationData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count) { }

	}

	[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
	public struct CompiledPassInfo
	{
		public string name; //Field offset: 0x0
		public int index; //Field offset: 0x8
		public List<Int32>[] resourceCreateList; //Field offset: 0x10
		public List<Int32>[] resourceReleaseList; //Field offset: 0x18
		public GraphicsFence fence; //Field offset: 0x20
		public int refCount; //Field offset: 0x30
		public int syncToPassIndex; //Field offset: 0x34
		public int syncFromPassIndex; //Field offset: 0x38
		public bool enableAsyncCompute; //Field offset: 0x3C
		public bool allowPassCulling; //Field offset: 0x3D
		public bool needGraphicsFence; //Field offset: 0x3E
		public bool culled; //Field offset: 0x3F
		public bool culledByRendererList; //Field offset: 0x40
		public bool hasSideEffect; //Field offset: 0x41
		public bool enableFoveatedRasterization; //Field offset: 0x42

		[CalledBy(Type = typeof(CompiledGraph), Member = "InitializeCompilationData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		public void Reset(RenderGraphPass pass, int index) { }

	}

	public struct CompiledResourceInfo
	{
		public List<Int32> producers; //Field offset: 0x0
		public List<Int32> consumers; //Field offset: 0x8
		public int refCount; //Field offset: 0x10
		public bool imported; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public void Reset() { }

	}

	public class DebugData
	{
		internal class BufferResourceData
		{
			public int count; //Field offset: 0x10
			public int stride; //Field offset: 0x14
			public Target target; //Field offset: 0x18
			public UsageFlags usage; //Field offset: 0x1C

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public BufferResourceData() { }

		}

		[DebuggerDisplay("PassDebug: {name}")]
		internal struct PassData
		{
			internal class NRPInfo
			{
				internal class NativeRenderPassInfo
				{
					internal class AttachmentInfo
					{
						public string resourceName; //Field offset: 0x10
						public string loadReason; //Field offset: 0x18
						public string storeReason; //Field offset: 0x20
						public string storeMsaaReason; //Field offset: 0x28
						public int attachmentIndex; //Field offset: 0x30
						public NativePassAttachment attachment; //Field offset: 0x34

						[CallerCount(Count = 2180)]
						[CallsDeduplicatedMethods(Count = 1)]
						[DeduplicatedMethod]
						public AttachmentInfo() { }

					}

					internal struct PassCompatibilityInfo
					{
						public string message; //Field offset: 0x0
						public bool isCompatible; //Field offset: 0x8

					}

					public string passBreakReasoning; //Field offset: 0x10
					public List<AttachmentInfo> attachmentInfos; //Field offset: 0x18
					public Dictionary<Int32, PassCompatibilityInfo> passCompatibility; //Field offset: 0x20
					public List<Int32> mergedPassIds; //Field offset: 0x28

					[CallerCount(Count = 2180)]
					[CallsDeduplicatedMethods(Count = 1)]
					[DeduplicatedMethod]
					public NativeRenderPassInfo() { }

				}

				public NativeRenderPassInfo nativePassInfo; //Field offset: 0x10
				public List<Int32> textureFBFetchList; //Field offset: 0x18
				public List<Int32> setGlobals; //Field offset: 0x20
				public int width; //Field offset: 0x28
				public int height; //Field offset: 0x2C
				public int volumeDepth; //Field offset: 0x30
				public int samples; //Field offset: 0x34
				public bool hasDepth; //Field offset: 0x38

				[CallerCount(Count = 0)]
				[CallsDeduplicatedMethods(Count = 3)]
				[CallsUnknownMethods(Count = 2)]
				public NRPInfo() { }

			}

			public string name; //Field offset: 0x0
			public RenderGraphPassType type; //Field offset: 0x8
			public List<Int32>[] resourceReadLists; //Field offset: 0x10
			public List<Int32>[] resourceWriteLists; //Field offset: 0x18
			public bool culled; //Field offset: 0x20
			public bool async; //Field offset: 0x21
			public int nativeSubPassIndex; //Field offset: 0x24
			public int syncToPassIndex; //Field offset: 0x28
			public int syncFromPassIndex; //Field offset: 0x2C
			public bool generateDebugData; //Field offset: 0x30
			public NRPInfo nrpInfo; //Field offset: 0x38
			public PassScriptInfo scriptInfo; //Field offset: 0x40

		}

		internal class PassScriptInfo
		{
			public string filePath; //Field offset: 0x10
			public int line; //Field offset: 0x18

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public PassScriptInfo() { }

		}

		[DebuggerDisplay("ResourceDebug: {name} [{creationPassIndex}:{releasePassIndex}]")]
		internal struct ResourceData
		{
			public string name; //Field offset: 0x0
			public bool imported; //Field offset: 0x8
			public int creationPassIndex; //Field offset: 0xC
			public int releasePassIndex; //Field offset: 0x10
			public List<Int32> consumerList; //Field offset: 0x18
			public List<Int32> producerList; //Field offset: 0x20
			public bool memoryless; //Field offset: 0x28
			public TextureResourceData textureData; //Field offset: 0x30
			public BufferResourceData bufferData; //Field offset: 0x38

		}

		internal class TextureResourceData
		{
			public int width; //Field offset: 0x10
			public int height; //Field offset: 0x14
			public int depth; //Field offset: 0x18
			public bool bindMS; //Field offset: 0x1C
			public int samples; //Field offset: 0x20
			public GraphicsFormat format; //Field offset: 0x24
			public bool clearBuffer; //Field offset: 0x28

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public TextureResourceData() { }

		}

		internal static readonly Dictionary<Object, PassScriptInfo> s_PassScriptMetadata; //Field offset: 0x0
		public readonly List<PassData> passList; //Field offset: 0x10
		public readonly List<ResourceData>[] resourceLists; //Field offset: 0x18
		public bool isNRPCompiler; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static DebugData() { }

		[CalledBy(Type = typeof(RenderGraph), Member = "GenerateDebugData", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		public DebugData() { }

		[CalledBy(Type = typeof(RenderGraph), Member = "GenerateDebugData", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public void Clear() { }

	}

	public interface ICompiledGraph
	{

		public void Clear() { }

	}

	public sealed class OnExecutionRegisteredDelegate : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public OnExecutionRegisteredDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(RenderGraph graph, string executionName, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(RenderGraph graph, string executionName) { }

	}

	public sealed class OnGraphRegisteredDelegate : MulticastDelegate
	{

		[CallerCount(Count = 412)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public OnGraphRegisteredDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(RenderGraph graph) { }

	}

	private class ProfilingScopePassData
	{
		public ProfilingSampler sampler; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ProfilingScopePassData() { }

	}

	public static readonly int kMaxMRTCount; //Field offset: 0x0
	private const string k_BeginProfilingSamplerPassName = "BeginProfile"; //Field offset: 0x0
	private const string k_EndProfilingSamplerPassName = "EndProfile"; //Field offset: 0x0
	private static List<RenderGraph> s_RegisteredGraphs; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <isRenderGraphViewerActive>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static bool <enableValidityChecks>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private static OnGraphRegisteredDelegate onGraphRegistered; //Field offset: 0x18
	[CompilerGenerated]
	private static OnGraphRegisteredDelegate onGraphUnregistered; //Field offset: 0x20
	[CompilerGenerated]
	private static OnExecutionRegisteredDelegate onExecutionRegistered; //Field offset: 0x28
	[CompilerGenerated]
	private static OnExecutionRegisteredDelegate onExecutionUnregistered; //Field offset: 0x30
	[CompilerGenerated]
	private static Action onDebugDataCaptured; //Field offset: 0x38
	private NativePassCompiler nativeCompiler; //Field offset: 0x10
	private readonly String[] k_PassNameDebugIgnoreList; //Field offset: 0x18
	[CompilerGenerated]
	private bool <nativeRenderPassesEnabled>k__BackingField; //Field offset: 0x20
	internal RenderGraphResourceRegistry m_Resources; //Field offset: 0x28
	private RenderGraphObjectPool m_RenderGraphPool; //Field offset: 0x30
	private RenderGraphBuilders m_builderInstance; //Field offset: 0x38
	internal List<RenderGraphPass> m_RenderPasses; //Field offset: 0x40
	private List<RendererListHandle> m_RendererLists; //Field offset: 0x48
	private RenderGraphDebugParams m_DebugParameters; //Field offset: 0x50
	private RenderGraphLogger m_FrameInformationLogger; //Field offset: 0x58
	private RenderGraphDefaultResources m_DefaultResources; //Field offset: 0x60
	private Dictionary<Int32, ProfilingSampler> m_DefaultProfilingSamplers; //Field offset: 0x68
	private InternalRenderGraphContext m_RenderGraphContext; //Field offset: 0x70
	private CommandBuffer m_PreviousCommandBuffer; //Field offset: 0x78
	private List<Int32>[] m_ImmediateModeResourceList; //Field offset: 0x80
	private RenderGraphCompilationCache m_CompilationCache; //Field offset: 0x88
	private RenderTargetIdentifier[][] m_TempMRTArrays; //Field offset: 0x90
	private Stack<Int32> m_CullingStack; //Field offset: 0x98
	private string m_CurrentExecutionName; //Field offset: 0xA0
	private int m_ExecutionCount; //Field offset: 0xA8
	private int m_CurrentFrameIndex; //Field offset: 0xAC
	private int m_CurrentImmediatePassIndex; //Field offset: 0xB0
	private bool m_ExecutionExceptionWasRaised; //Field offset: 0xB4
	private bool m_HasRenderGraphBegun; //Field offset: 0xB5
	private bool m_RendererListCulling; //Field offset: 0xB6
	private bool m_EnableCompilationCaching; //Field offset: 0xB7
	private CompiledGraph m_DefaultCompiledGraph; //Field offset: 0xB8
	private CompiledGraph m_CurrentCompiledGraph; //Field offset: 0xC0
	private string m_CaptureDebugDataForExecution; //Field offset: 0xC8
	private Dictionary<String, DebugData> m_DebugData; //Field offset: 0xD0
	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0xD8
	private Dictionary<Int32, TextureHandle> registeredGlobals; //Field offset: 0xE0

	internal static event Action onDebugDataCaptured
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 242
	}

	internal static event OnExecutionRegisteredDelegate onExecutionRegistered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 242
	}

	internal static event OnExecutionRegisteredDelegate onExecutionUnregistered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 242
	}

	internal static event OnGraphRegisteredDelegate onGraphRegistered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 242
	}

	internal static event OnGraphRegisteredDelegate onGraphUnregistered
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal add { } //Length: 242
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		internal remove { } //Length: 242
	}

	internal bool areAnySettingsActive
	{
		[CalledBy(Type = typeof(DebugDisplaySettingsRenderGraph), Member = "get_AreAnySettingsActive", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 58
	}

	internal RenderGraphDebugParams debugParams
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public RenderGraphDefaultResources defaultResources
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal static bool enableValidityChecks
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public internal static bool isRenderGraphViewerActive
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 84
	}

	public private string name
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

	public bool nativeRenderPassesEnabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static RenderGraph() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphDefaultResources), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsSettings), Member = "TryGetRenderPipelineSettings", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphDebugParams), typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	public RenderGraph(string name = "RenderGraph") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onDebugDataCaptured(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onExecutionUnregistered(OnExecutionRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void add_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.OcclusionCullingSettings&", "System.ReadOnlySpan`1<SubviewOcclusionTest>", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.OccluderParameters&", "System.ReadOnlySpan`1<OccluderSubviewUpdate>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphPass), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(RenderGraphResourceRegistry), typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public IComputeRenderGraphBuilder AddComputePass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddComputePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IComputeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IComputeRenderGraphBuilder AddComputePass(string passName, out PassData passData, string file = "", int line = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("UNITY_EDITOR")]
	private void AddPassDebugMetadata(RenderGraphPass renderPass, string file, int line) { }

	[CallerCount(Count = 55)]
	[Calls(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphPass), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(RenderGraphResourceRegistry), typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public IRasterRenderGraphBuilder AddRasterRenderPass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "BlitEmptyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IRasterRenderGraphBuilder AddRasterRenderPass(string passName, out PassData passData, string file = "", int line = 0) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[CalledBy(Type = typeof(RenderGraph), Member = "BeginProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "EndProfilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(RenderGraphPass), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(RenderGraphResourceRegistry), typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RenderFragmentationOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(DebugOverlay)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RenderGraphBuilder AddRenderPass(string passName, out PassData passData, string file = "", int line = 0) { }

	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(BlitFilterMode), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(BlitMaterialParameters), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "UpdateCameraResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderDoFGaussian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle&), typeof(TextureHandle), typeof(Material&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderDoFBokeh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle&), typeof(TextureHandle&), typeof(Material&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IUnsafeRenderGraphBuilder AddUnsafePass(string passName, out PassData passData, string file = "", int line = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupRenderGraphLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderLensFlareScreenSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Camera), typeof(TextureHandle&), typeof(TextureHandle), typeof(TextureHandle), typeof(bool), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderLensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.HDRDebugViewPass", Member = "RenderHDRDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), "UnityEngine.Rendering.Universal.HDRDebugMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass", Member = "RenderOffscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(GraphicsFormat), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.CapturePass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetEditorTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "ProcessVFXCameraCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "InitRenderGraphFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass", Member = "RenderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(RenderGraphPass), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilders), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(RenderGraphResourceRegistry), typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphObjectPool+SharedObjectPool`1", Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public IUnsafeRenderGraphBuilder AddUnsafePass(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ValueCollection<Int32, TextureHandle> AllGlobals() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "GetFirstValidConsumerIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "FindTextureProducer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompiledResourceInfo&), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[Calls(Type = typeof(RenderGraph), Member = "GetImportedFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void AllocateCulledPassResources(ref CompiledPassInfo passInfo) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "TryCullPassAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle&)}, ReturnType = typeof(RendererList))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "QueryRendererListStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(RendererListStatus))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool AreRendererListsEmpty(List<RendererListHandle> rendererLists) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "AllowPassCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "GenerateDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "SetRenderFunc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc`2<PassData, RenderGraphContext>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void BeginProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RecordAndExecuteRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderer", typeof(CommandBuffer), typeof(Camera), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "BeginRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "LogFrameInformation", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "BeginExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "EnableIntraFrameMemoryAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	public void BeginRecording(in RenderGraphParameters parameters) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "ClearRenderPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphDefaultResources), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativePassCompiler), Member = "Cleanup", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Cleanup() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateDebugData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupDebugData() { }

	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "ClearRenderPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ClearCompiledGraph(CompiledGraph compiledGraph, bool useCompilationCaching) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "ClearRenderPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void ClearCompiledGraph() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void ClearGlobalBindings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("UNITY_EDITOR")]
	private void ClearPassDebugMetadata() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ClearCompiledGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ClearRenderPasses() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphCompilationCache)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativePassCompiler), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	internal NativePassCompiler CompileNativeRenderGraph(int graphHash) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "OnPassAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ExecutePassImmediately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicArray`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(CompiledPassInfo), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.ResourceHandle>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsGraphicsResourceCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRendererListCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	private CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "TryCullPassAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "UpdateSharedResourceLastFrameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "GetFirstValidWriteIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "GetLatestValidReadIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetSharedResourceCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "CullUnusedPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "CountReferences", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = "InitializeCompilationData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompiledGraph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	internal void CompileRenderGraph(int graphHash) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphPass), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashFNV1A32&), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal int ComputeGraphHash() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 24)]
	private void CountReferences() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public BufferHandle CreateBuffer(in BufferHandle graphicsBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferDesc&), typeof(int)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public BufferHandle CreateBuffer(in BufferDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateGizmoRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(GizmoSubset&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateGizmoRendererList(in Camera camera, in GizmoSubset gizmoSubset) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DBufferRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalForwardEmissivePass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalPreviewPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalGBufferRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListObjectsWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(Camera), typeof(FilteringSettings), typeof(SortingCriteria), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), typeof(RendererListHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DepthOnlyPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(uint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateRendererList(in RendererListParams desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListDesc&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateRendererList(in RendererListDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>), typeof(ScriptableRenderContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void CreateRendererLists() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CullingResults&), "PassData&", typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateShadowRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(ShadowDrawingSettings&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateShadowRendererList(ref ShadowDrawingSettings shadowDrawingSettings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease = false) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawSkyboxPass", Member = "CreateSkyBoxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(RendererListHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateSkyboxRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateSkyboxRendererList(in Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 3)]
	public TextureHandle CreateTexture(TextureHandle texture, string name, bool clear = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle CreateTexture(TextureHandle texture) { }

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyDepthPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateAfterPostProcessTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderingLayersTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraNormalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateMotionVectorTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateCameraDepthCopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(Color), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(Color), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature+FullScreenRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle CreateTexture(in TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureDesc&), typeof(int)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 2)]
	public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(UISubset&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateUIOverlayRendererList(in Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass", Member = "RenderOffscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(GraphicsFormat), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass", Member = "RenderOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateUIOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&), typeof(UISubset&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateUIOverlayRendererList(in Camera camera, in UISubset uiSubset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreateWireOverlayRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera&)}, ReturnType = typeof(RendererListHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RendererListHandle CreateWireOverlayRendererList(in Camera camera) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "TryCullPassAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void CullRendererLists() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "LogCulledPasses", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void CullUnusedPasses() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "PurgeUnusedGraphicsResources", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "GetAllLogs", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "FlushLogs", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EndFrame() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(RenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "AllowPassCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "GenerateDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphBuilder), Member = "SetRenderFunc", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc`2<PassData, RenderGraphContext>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void EndProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RecordAndExecuteRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.ScriptableRenderer", typeof(CommandBuffer), typeof(Camera), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	public void EndRecordingAndExecute() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "EndRecordingAndExecute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "LogFrameInformation", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ComputeGraphHash", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "CompileNativeRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NativePassCompiler))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "BeginExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ExecuteRenderGraph", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ExecuteNativeRenderGraph", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "ClearGlobalBindings", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	internal void Execute() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "OnPassAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ExecutePassImmediately", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteRenderGraph", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraph), Member = "LogRenderPassBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphLogger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "PostRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 20)]
	private void ExecuteCompiledPass(ref CompiledPassInfo passInfo) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativePassCompiler), Member = "ExecuteGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(RenderGraphResourceRegistry), typeof(List`1<RenderGraphPass>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void ExecuteNativeRenderGraph() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	private void ExecutePassImmediately(RenderGraphPass pass) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void ExecuteRenderGraph() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsUnknownMethods(Count = 1)]
	private int FindTextureProducer(int consumerPass, in CompiledResourceInfo info, out int index) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateDebugData", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "UpdateImportedResourceLifeTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceData&), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[Calls(Type = typeof(ResourceHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderGraphResourceType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderGraphResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 50)]
	private void GenerateCompilerDebugData(ref DebugData debugData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DebugData), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "CleanupDebugData", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void GenerateDebugData() { }

	[CalledBy(Type = typeof(DebugDisplaySettingsRenderGraph), Member = "get_AreAnySettingsActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_areAnySettingsActive() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal RenderGraphDebugParams get_debugParams() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public RenderGraphDefaultResources get_defaultResources() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static bool get_enableValidityChecks() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static bool get_isRenderGraphViewerActive() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_nativeRenderPassesEnabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetBufferResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(BufferDesc))]
	[CallsUnknownMethods(Count = 1)]
	public BufferDesc GetBufferDesc(in BufferHandle graphicsBuffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal DebugData GetDebugData(string executionName) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private ProfilingSampler GetDefaultProfilingSampler(string name) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private int GetFirstValidConsumerIndex(int passIndex, in CompiledResourceInfo info) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateAllSharedResourceLastFrameIndex", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsUnknownMethods(Count = 1)]
	private int GetFirstValidWriteIndex(in CompiledResourceInfo info) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "UseGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal TextureHandle GetGlobal(int globalPropertyId) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "ReadTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureDesc), Member = "get_depthBufferBits", ReturnType = typeof(DepthBits))]
	[Calls(Type = typeof(TextureXR), Member = "get_dimension", ReturnType = typeof(TextureDimension))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceSynchronization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(int), typeof(CompiledResourceInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateAllSharedResourceLastFrameIndex", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsUnknownMethods(Count = 1)]
	private int GetLatestValidReadIndex(in CompiledResourceInfo info) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsUnknownMethods(Count = 1)]
	private int GetLatestValidWriteIndex(in CompiledResourceInfo info) { }

	[CallerCount(Count = 0)]
	public static List<RenderGraph> GetRegisteredRenderGraphs() { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "CheckFrameBufferFetchEmulationIsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "IsFramebufferFetchSupportedOnCurrentPlatform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.CopyDepthPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetRenderTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(RenderTargetInfo&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public RenderTargetInfo GetRenderTargetInfo(TextureHandle texture) { }

	[CalledBy(Type = typeof(TextureHandle), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureDesc))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddCopyPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle), typeof(TextureHandle), typeof(Vector2), typeof(Vector2), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(BlitFilterMode), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphUtils), Member = "AddBlitPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(BlitMaterialParameters), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.FullScreenPassRendererFeature+FullScreenRenderPass", Member = "RecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[CallsUnknownMethods(Count = 1)]
	public TextureDesc GetTextureDesc(TextureHandle texture) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsRenderGraph+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphDebugParams), Member = "GetWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[CallsUnknownMethods(Count = 1)]
	internal List<Widget> GetWidgetList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo&), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBackbuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetInfo&), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, RenderTargetInfo info, ImportResourceParams importParams = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = "UnityEngine.Rendering.OccluderHandles")]
	[CalledBy(Type = "UnityEngine.Rendering.IndirectBufferContextStorage", Member = "ImportBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = "UnityEngine.Rendering.IndirectBufferContextHandles")]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "RenderDebugOcclusionTestOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.DebugDisplayGPUResidentDrawer", typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.OccluderParameters&"}, ReturnType = "UnityEngine.Rendering.OccluderHandles")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(bool)}, ReturnType = typeof(BufferHandle))]
	[CallsUnknownMethods(Count = 1)]
	public BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportRayTracingAccelerationStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayTracingAccelerationStructure&), typeof(string)}, ReturnType = typeof(RayTracingAccelerationStructureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure(in RayTracingAccelerationStructure accelStruct, string name = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupAfterPostRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(ImportResourceParams&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle ImportTexture(RTHandle rt, ImportResourceParams importParams) { }

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderLensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalResourceData", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "TryGetCachedUserLutTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupRenderGraphFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalResourceData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle ImportTexture(RTHandle rt) { }

	[CalledBy(Type = typeof(STP), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Config&)}, ReturnType = typeof(TextureHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "ImportXRMotionColorAndDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = "UnityEngine.Rendering.OccluderHandles")]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "PrepareOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.OccluderParameters&"}, ReturnType = "UnityEngine.Rendering.OccluderHandles")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTargetInfo), typeof(ImportResourceParams&)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	public TextureHandle ImportTexture(RTHandle rt, RenderTargetInfo info, ImportResourceParams importParams = null) { }

	[CalledBy(Type = typeof(RenderGraphDefaultResources), Member = "InitializeForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal TextureHandle ImportTexture(RTHandle rt, bool isBuiltin) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void InvalidateContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool IsGlobal(int globalPropertyId) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CullUnusedPasses", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphLogger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private void LogCulledPasses() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private void LogFrameInformation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void LogRendererListsCreation() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphLogger), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphLogIndent), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private void LogRenderPassBegin(in CompiledPassInfo passInfo) { }

	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilder), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void OnPassAdded(RenderGraphPass pass) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.ValueTuple`2<UnityEngine.Rendering.RenderGraphModule.TextureHandle, System.Int32>>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "CreateAsyncGraphicsFence", ReturnType = typeof(GraphicsFence))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBufferAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeQueueType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraphObjectPool), Member = "ReleaseAllTempAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ReleasePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "ExecuteCompiledPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "CreateGraphicsFence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFenceType), typeof(SynchronisationStageFlags)}, ReturnType = typeof(GraphicsFence))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "CreatePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderGraph), Member = "PreRenderPassSetRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderContext), Member = "ExecuteCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBufferPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CommandBuffer))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "WaitOnAsyncGraphicsFence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFence), typeof(SynchronisationStageFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "PreRenderPassExecute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&), typeof(RenderGraphPass), typeof(InternalRenderGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "RefreshSharedTextureDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&), typeof(TextureDesc&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshSharedTextureDesc(TextureHandle handle, in TextureDesc desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphDebugParams), Member = "GetWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterDebug(Panel panel = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas+<>c", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ReleasePooledResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalRenderGraphContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ReleaseImmediateModeResources() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "ReleaseSharedTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void ReleaseSharedTexture(TextureHandle texture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onDebugDataCaptured(Action value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onExecutionRegistered(OnExecutionRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onExecutionUnregistered(OnExecutionRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onGraphRegistered(OnGraphRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	internal static void remove_onGraphUnregistered(OnGraphRegisteredDelegate value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void RequestCaptureDebugData(string executionName) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private static void set_enableValidityChecks(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal static void set_isRenderGraphViewerActive(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_name(string value) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_nativeRenderPassesEnabled(bool value) { }

	[CalledBy(Type = typeof(RenderGraphBuilders), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Rendering.RenderGraphModule.TextureHandle>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal void SetGlobal(TextureHandle h, int globalPropertyId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "EnableIntraFrameMemoryAliasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SetIntraFrameMemoryAliasing(bool enabled) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CullRendererLists", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "AreRendererListsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RendererListHandle>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void TryCullPassAtIndex(int passIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObservableList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public void UnRegisterDebug() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetSharedResourceCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(RenderGraph), Member = "GetLatestValidReadIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "GetFirstValidWriteIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "UpdateSharedResourceLastFrameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateAllSharedResourceLastFrameIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompiledGraph&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching = false) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "GenerateCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateImportedResourceLifeTime(ref ResourceData data, List<Int32> passList) { }

	[CallerCount(Count = 0)]
	private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "UpdateSharedResourceLastFrameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "GetLatestValidWriteIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "GetLatestValidReadIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraph), Member = "GetFirstValidWriteIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceForceReleased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceShared", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceType), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "UpdateResourceSynchronization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(int), typeof(CompiledResourceInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledResourceInfo&))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(RenderGraph), Member = "AllocateCulledPassResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompiledPassInfo&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateResourceAllocationAndSynchronization() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateResourceAllocationAndSynchronization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraph), Member = "GetLatestProducerIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompiledResourceInfo&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledPassInfo>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CompiledPassInfo&))]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource) { }

}

