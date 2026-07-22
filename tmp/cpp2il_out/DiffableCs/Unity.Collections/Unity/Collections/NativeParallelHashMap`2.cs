namespace Unity.Collections;

[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[NativeContainer]
public struct NativeParallelHashMap : INativeDisposable, IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct Enumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue<TKey, TValue> Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 79
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			private get { } //Length: 153
		}

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override KeyValue<TKey, TValue> get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "MoveNextSearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		internal ParallelWriter<TKey, TValue> m_Writer; //Field offset: 0x0

		public int Capacity
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 49
		}

		[Obsolete("'m_ThreadIndex' has been deprecated; use 'ThreadIndex' instead. (UnityUpgradable) -> ThreadIndex")]
		public int m_ThreadIndex
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public int ThreadIndex
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		public int get_m_ThreadIndex() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		public int get_ThreadIndex() { }

		[CalledBy(Type = "UnityEngine.Rendering.RegisterNewMeshesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RegisterNewMaterialsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public bool TryAdd(TKey key, TValue item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAddAtomic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public bool TryAdd(TKey key, TValue item, int threadIndexOverride) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

		public int Capacity
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 49
		}

		public bool IsCreated
		{
			[CallerCount(Count = 5)]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 40
		}

		public bool IsEmpty
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 161
		}

		public TValue Item
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 142
		}

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void CheckRead() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "Count", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int Count() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Capacity() { }

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsCreated() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public TValue get_Item(TKey key) { }

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void ThrowKeyNotPresent(TKey key) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	public const int MaxCapacity = 1073741823; //Field offset: 0x0
	internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 49
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 40
	}

	public bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 161
	}

	public TValue Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.DrawCommandOutputPerBatch", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.BuildDrawListsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "Execute", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst+RemoveDrawInstanceIndices_00000184$BurstDirectCall", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<DrawInstance>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawInstanceIndices$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<DrawInstance>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 138
		[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.UpdatePackedMaterialDataCacheJob", Member = "ProcessMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 128
	}

	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContext", "UnityEngine.Rendering.InstanceCullingBatcherDesc", typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferBuilder", Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.InstanceNumInfo&"}, ReturnType = "UnityEngine.Rendering.GPUInstanceDataBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "InternalSanityCheckStates", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPool", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContextDesc&", "UnityEngine.Rendering.GPUDrivenProcessor", "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderersBatchersContext", "UnityEngine.Rendering.InstanceCullingBatcherDesc", typeof(OnFinishedCulling)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "EditDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", typeof(SubMeshDescriptor&), "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = "UnityEngine.Rendering.DrawBatch&")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(TKey key, TValue item) { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<TKey, TValue> AsReadOnly() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckRead() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckWrite() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = "UnityEngine.Rendering.FindNonRegisteredMeshesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FindNonRegisteredMaterialsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "HasOccluderContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool ContainsKey(TKey key) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "Count", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapDataDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapDataDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBuffer", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPool", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_Capacity() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapData), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsEmpty() { }

	[CalledBy(Type = "UnityEngine.Rendering.DrawCommandOutputPerBatch", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.BuildDrawListsJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst+RemoveDrawInstanceIndices_00000184$BurstDirectCall", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<DrawInstance>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "ProcessRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUDrivenRendererGroupData&), "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMeshID>", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUDrivenPackedMaterialData>", "Unity.Collections.NativeParallelHashMap`2<Int32, BatchMaterialID>", "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeList`1<DrawInstance>", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>", "Unity.Collections.NativeList`1<DrawRange>", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>", "Unity.Collections.NativeList`1<DrawBatch>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawInstanceIndices$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<DrawInstance>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue get_Item(TKey key) { }

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TKey>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetKeyValueArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeKeyValueArrays`2<TKey, TValue>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "GetValueArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = "Unity.Collections.NativeArray`1<TValue>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPoolBurst", Member = "FreeLODGroupData$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<LODGroupData>&", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUInstanceIndex>&", "Unity.Collections.NativeList`1<GPUInstanceIndex>&"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "FreeUnusedSlots", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "DeleteContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool Remove(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.RemoveDrawInstanceIndicesJob", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UpdatePackedMaterialDataCacheJob", Member = "ProcessMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcherBurst", Member = "RemoveDrawBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey&", "Unity.Collections.NativeList`1<DrawRange>&", "Unity.Collections.NativeParallelHashMap`2<RangeKey, Int32>&", "Unity.Collections.NativeParallelHashMap`2<DrawKey, Int32>&", "Unity.Collections.NativeList`1<DrawBatch>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Item(TKey key, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void ThrowAtMaxCapacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void ThrowKeyAlreadyAdded(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[DeduplicatedMethod]
	private void ThrowKeyNotPresent(TKey key) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPoolBurst", Member = "AllocateOrGetLODGroupDataInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<LODGroupData>&", "Unity.Collections.NativeList`1<LODGroupCullingData>&", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUInstanceIndex>&", "Unity.Collections.NativeList`1<GPUInstanceIndex>&", "Unity.Collections.NativeArray`1<GPUInstanceIndex>&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeParallelHashMapBase`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeParallelHashMapData*), "TKey", "TValue", typeof(bool), typeof(AllocatorHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool TryAdd(TKey key, TValue item) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeParallelHashMap`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool TryGetValue(TKey key, out TValue item) { }

}

