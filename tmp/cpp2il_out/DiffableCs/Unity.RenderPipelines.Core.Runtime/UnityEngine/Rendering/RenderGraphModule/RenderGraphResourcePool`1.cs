namespace UnityEngine.Rendering.RenderGraphModule;

internal abstract class RenderGraphResourcePool : IRenderGraphResourcePool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<Type> <>9; //Field offset: 0x0
		public static Comparison<ResourceLogInfo<Type>> <>9__15_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int <LogResources>b__15_0(ResourceLogInfo<Type> a, ResourceLogInfo<Type> b) { }

	}

	private struct ResourceLogInfo
	{
		public string name; //Field offset: 0x0
		public long size; //Field offset: 0x0

	}

	private const int kStaleResourceLifetime = 10; //Field offset: 0x0
	private static List<Int64> s_ToRemoveList; //Field offset: 0x0
	protected Dictionary<Int32, SortedList`2<Int64, PooledResourceEntry`1<Type>>> m_ResourcePool; //Field offset: 0x0
	private List<ValueTuple`2<Int32, Type>> m_FrameAllocatedResources; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static RenderGraphResourcePool`1() { }

	[CalledBy(Type = typeof(BufferPool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphResourceRegistry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraphDebugParams), typeof(RenderGraphLogger)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TexturePool), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected RenderGraphResourcePool`1() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void CheckFrameAllocation(bool onException, int frameIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public virtual void Cleanup() { }

	protected abstract string GetResourceName(in Type res) { }

	protected abstract long GetResourceSize(in Type res) { }

	protected abstract string GetResourceTypeName() { }

	protected abstract int GetSortIndex(Type res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraphLogger), Member = "LogLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 29)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void LogResources(RenderGraphLogger logger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.SortedList`2<System.Int64, UnityEngine.Rendering.RenderGraphModule.PooledResourceEntry`1<System.Object>>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	public virtual void PurgeUnusedResources(int currentFrameIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[DeduplicatedMethod]
	public void RegisterFrameAllocation(int hash, Type value) { }

	protected abstract void ReleaseInternalResource(Type res) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.SortedList`2<System.Int64, UnityEngine.Rendering.RenderGraphModule.PooledResourceEntry`1<System.Object>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.SortedList`2<System.Int64, UnityEngine.Rendering.RenderGraphModule.PooledResourceEntry`1<System.Object>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "UnityEngine.Rendering.RenderGraphModule.PooledResourceEntry`1<Object>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void ReleaseResource(int hash, Type resource, int currentFrameIndex, int currentExecutionCount) { }

	[CalledBy(Type = typeof(RenderGraphResource`2), Member = "CreatePooledGraphicsResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortedList`2), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public bool TryGetResource(int hashCode, out Type resource, int currentFrameIndex, int currentExecutionCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Object>>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.Int32, System.Object>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[DeduplicatedMethod]
	public void UnregisterFrameAllocation(int hash, Type value) { }

}

