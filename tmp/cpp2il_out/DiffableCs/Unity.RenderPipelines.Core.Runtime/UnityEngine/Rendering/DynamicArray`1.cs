namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
[DefaultMember("Item")]
public class DynamicArray
{
	internal struct Iterator
	{
		private readonly DynamicArray<T> owner; //Field offset: 0x0
		private int index; //Field offset: 0x0

		public T Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 79
		}

		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Iterator(DynamicArray<T> setOwner) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public T get_Current() { }

		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeBestToBeLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeStreamingScoreAndWorseLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void Reset() { }

	}

	internal struct RangeEnumerable
	{
		internal struct RangeIterator
		{
			private readonly DynamicArray<T> owner; //Field offset: 0x0
			private int index; //Field offset: 0x0
			private int first; //Field offset: 0x0
			private int last; //Field offset: 0x0

			public T Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
				[CallsUnknownMethods(Count = 2)]
				[DeduplicatedMethod]
				 get { } //Length: 79
			}

			[CalledBy(Type = typeof(DynamicArray`1), Member = "SubRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "UnityEngine.Rendering.DynamicArray`1<T>+RangeEnumerable<T>")]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public RangeIterator(DynamicArray<T> setOwner, int first, int numItems) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public T get_Current() { }

			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			public bool MoveNext() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public void Reset() { }

		}

		public RangeIterator<T> iterator; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public RangeIterator<T> GetEnumerator() { }

	}

	internal sealed class SortComparer : MulticastDelegate
	{

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public SortComparer(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(T x, T y, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke(T x, T y) { }

	}

	protected T[] m_Array; //Field offset: 0x0
	[CompilerGenerated]
	private int <size>k__BackingField; //Field offset: 0x0

	public int capacity
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public T Item
	{
		[CalledBy(Type = typeof(CompilerContextData), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Iterator), Member = "get_Current", ReturnType = "T&")]
		[CalledBy(Type = typeof(RangeIterator), Member = "get_Current", ReturnType = "T&")]
		[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CompilerContextData), Member = "GetFullPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Name))]
		[CalledBy(Type = typeof(CompilerContextData), Member = "GetPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "MakeAttachmentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(int)}, ReturnType = typeof(AttachmentInfo))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "MakePassBreakInfoMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "MakePassMergeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(PassData&), typeof(PassData&), typeof(PassBreakAudit)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PassData), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData)}, ReturnType = typeof(Name))]
		[CalledBy(Type = typeof(NativePassData), Member = "GetGraphPassNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 49
	}

	public int size
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicString), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompiledGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphObjectPool), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry+RenderGraphResourcesData", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphDebugParams), typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DynamicArray`1() { }

	[CalledBy(Type = typeof(NativePassCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphCompilationCache)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourcesData), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DynamicArray`1(int size) { }

	[CalledBy(Type = typeof(DynamicString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompilerContextData), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphCompilationCache)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public DynamicArray`1(int capacity, bool resize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public DynamicArray`1(DynamicArray<T> deepCopy) { }

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public int Add(in T value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void AddRange(DynamicArray<T> array) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected private void BumpVersion() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Widget), Member = "set_nameAndTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndTooltip)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeBestToBeLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeStreamingScoreAndWorseLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateBlendingCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "StartIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllCells", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnloadAllBlendingCells", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompiledGraph), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(bool), typeof(string), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Contains(T item) { }

	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_capacity() { }

	[CalledBy(Type = typeof(CompilerContextData), Member = "GetResourceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassData), Member = "GetGraphPassNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.Name>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PassData), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData)}, ReturnType = typeof(Name))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "GenerateNativeCompilerDebugData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "MakePassMergeMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(PassData&), typeof(PassData&), typeof(PassBreakAudit)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "MakePassBreakInfoMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "MakeAttachmentInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompilerContextData), typeof(NativePassData&), typeof(int)}, ReturnType = typeof(AttachmentInfo))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "GetFullPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Name))]
	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RangeIterator), Member = "get_Current", ReturnType = "T&")]
	[CalledBy(Type = typeof(Iterator), Member = "get_Current", ReturnType = "T&")]
	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphCompilationCache), Member = "GetCompilationCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "T&", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>", "System.Collections.Generic.Stack`1<T>", "UnityEngine.Rendering.DynamicArray`1<HashEntry`1<T>>+SortComparer<HashEntry`1<T>>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "GetPassName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 22)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public T get_Item(int index) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_size() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeBestToBeLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeStreamingScoreAndWorseLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(ProbeVolumesOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphObjectPool), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Iterator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int IndexOf(T item, int index, int count) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int IndexOf(T item, int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int IndexOf(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public void Insert(int index, T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("This is deprecated because it returns an incorrect value. It may returns an array with elements beyond the size. Please use Span/ReadOnly if you want safe raw access to the DynamicArray memory.", False)]
	public static T[] op_Implicit(DynamicArray<T> array) { }

	[CallerCount(Count = 1)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> op_Implicit(DynamicArray<T> array) { }

	[CallerCount(Count = 1)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Span<T> op_Implicit(DynamicArray<T> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool Remove(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateBlendingCellStreaming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void RemoveRange(int index, int count) { }

	[CalledBy(Type = typeof(DynamicString), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeBestToBeLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeStreamingScoreAndWorseLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompilerContextData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePassCompiler), Member = "SetupContextData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void Reserve(int newCapacity, bool keepContent = false) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeBestToBeLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "ComputeStreamingScoreAndWorseLoadedCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UpdateIndexDefragmentation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompiledGraph), Member = "InitResourceInfosData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Rendering.DynamicArray`1<UnityEngine.Rendering.RenderGraphModule.RenderGraph+CompiledResourceInfo>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompiledGraph), Member = "InitializeCompilationData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.RenderGraphModule.RenderGraphPass>), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "BeginRecording", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphParameters&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "CompilePassImmediatly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphPass)}, ReturnType = typeof(CompiledPassInfo&))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry+RenderGraphResourcesData", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry+RenderGraphResourcesData", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.RenderGraphResourceRegistry+RenderGraphResourcesData", Member = "AddNewRenderGraphResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ResType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ResType&", typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphDebugParams), typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ResourcesData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Resize(int newSize, bool keepContent = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void ResizeAndClear(int newSize) { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_size(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RangeIterator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DynamicArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public RangeEnumerable<T> SubRange(int first, int numItems) { }

}

