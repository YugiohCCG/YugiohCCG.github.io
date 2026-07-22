//Type is in global namespace

internal class RenderGraphCompilationCache
{
	[CompilerGenerated]
	private sealed class <>c__11
	{
		public static readonly <>c__11<T> <>9; //Field offset: 0x0
		public static Predicate<HashEntry`1<T>> <>9__11_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c__11`1() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__11`1() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <GetCompilationCache>b__11_0(HashEntry<T> value) { }

	}

	private struct HashEntry
	{
		public int hash; //Field offset: 0x0
		public int lastFrameUsed; //Field offset: 0x0
		public T compiledGraph; //Field offset: 0x0

	}

	private static SortComparer<HashEntry<CompiledGraph>> s_EntryComparer; //Field offset: 0x0
	private const int k_CachedGraphCount = 20; //Field offset: 0x0
	private static SortComparer<HashEntry<CompilerContextData>> s_NativeEntryComparer; //Field offset: 0x8
	private static int s_Hash; //Field offset: 0x10
	private DynamicArray<HashEntry`1<CompiledGraph>> m_HashEntries; //Field offset: 0x10
	private DynamicArray<HashEntry`1<CompilerContextData>> m_NativeHashEntries; //Field offset: 0x18
	private Stack<CompiledGraph> m_CompiledGraphPool; //Field offset: 0x20
	private Stack<CompilerContextData> m_NativeCompiledGraphPool; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static RenderGraphCompilationCache() { }

	[CalledBy(Type = typeof(RenderGraph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CompiledGraph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompilerContextData), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public RenderGraphCompilationCache() { }

	[CalledBy(Type = typeof(RenderGraph), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "ToArray", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CompilerContextData), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Cleanup() { }

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompiledGraph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CompilerContextData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicArray`1), Member = "FindIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DynamicArrayExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DynamicArray`1<T>", "UnityEngine.Rendering.DynamicArray`1<T>+SortComparer<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(DynamicArray`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	private bool GetCompilationCache(int hash, int frameIndex, out T outGraph, DynamicArray<HashEntry`1<T>> hashEntries, Stack<T> pool, SortComparer<HashEntry<T>> comparer) { }

	[CalledBy(Type = typeof(RenderGraph), Member = "UpdateCurrentCompiledGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompileRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	public bool GetCompilationCache(int hash, int frameIndex, out CompiledGraph outGraph) { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	public bool GetCompilationCache(int hash, int frameIndex, out CompilerContextData outGraph) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int HashEntryComparer(HashEntry<T> a, HashEntry<T> b) { }

}

