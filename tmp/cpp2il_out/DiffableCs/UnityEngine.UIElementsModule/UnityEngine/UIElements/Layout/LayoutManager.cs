namespace UnityEngine.UIElements.Layout;

internal class LayoutManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventHandler <>9__7_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutManager), Member = "Shutdown", ReturnType = typeof(void))]
		internal void <Initialize>b__7_0(object _, EventArgs __) { }

	}

	private static bool s_Initialized; //Field offset: 0x0
	private static bool s_AppDomainUnloadRegistered; //Field offset: 0x1
	private static LayoutManager s_SharedInstance; //Field offset: 0x8
	private static readonly List<LayoutManager> s_Managers; //Field offset: 0x10
	private readonly int m_Index; //Field offset: 0x10
	private LayoutDataStore m_Nodes; //Field offset: 0x18
	private LayoutDataStore m_Configs; //Field offset: 0x28
	private readonly object m_SyncRoot; //Field offset: 0x38
	private readonly Stack<LayoutHandle> m_NodesToFree; //Field offset: 0x40
	private readonly LayoutHandle m_DefaultConfig; //Field offset: 0x48
	private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions; //Field offset: 0x50
	private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions; //Field offset: 0x58
	private readonly ManagedObjectStore<WeakReference`1<VisualElement>> m_ManagedOwners; //Field offset: 0x60
	private int m_HighMark; //Field offset: 0x68

	private static int DefaultCapacity
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	public static LayoutManager SharedManager
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static LayoutManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	public LayoutManager(Allocator allocator) { }

	[CalledBy(Type = typeof(LayoutManager), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutNodeData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutStyleData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutComputedData)}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(ComponentType), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(ComponentType))]
	[Calls(Type = typeof(LayoutDataStore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComponentType[]), typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public LayoutManager(Allocator allocator, int initialNodeCapacity) { }

	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&"}, ReturnType = typeof(LayoutHandle))]
	[ContainsUnimplementedInstructions]
	public LayoutConfig CreateConfig() { }

	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	public LayoutNode CreateNode() { }

	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNode", ReturnType = typeof(LayoutNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutManager), Member = "TryFreeNodes", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Allocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0&", "T1&", "T2&", "T3&"}, ReturnType = typeof(LayoutHandle))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private LayoutNode CreateNodeInternal(LayoutHandle configHandle) { }

	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	public void DestroyConfig(ref LayoutConfig config) { }

	[CalledBy(Type = typeof(VisualElement), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void DestroyNode(ref LayoutNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void FreeNode(LayoutHandle handle) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static int get_DefaultCapacity() { }

	[CallerCount(Count = 0)]
	public static LayoutManager get_SharedManager() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private LayoutDataAccess GetAccess() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Baseline", ReturnType = typeof(LayoutBaselineFunction))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle) { }

	[CalledBy(Type = typeof(VisualElement), Member = "HasChangedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutConfig GetDefaultConfig() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Measure", ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Baseline", ReturnType = typeof(LayoutBaselineFunction))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetBaselineFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutBaselineFunction))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static LayoutManager GetManager(int index) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "get_Measure", ReturnType = typeof(LayoutMeasureFunction))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutMeasureFunction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutNode), Member = "GetOwner", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public VisualElement GetOwner(LayoutHandle handle) { }

	[CalledBy(Type = typeof(LayoutManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "add_DomainUnload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void Initialize() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutDataAccess), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetOwner(LayoutHandle handle, VisualElement value) { }

	[CalledBy(Type = typeof(<>c), Member = "<Initialize>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void Shutdown() { }

	[CalledBy(Type = typeof(LayoutManager), Member = "CreateNodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle)}, ReturnType = typeof(LayoutNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(ManagedObjectStore`1), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutDataStore), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void TryFreeNodes() { }

}

