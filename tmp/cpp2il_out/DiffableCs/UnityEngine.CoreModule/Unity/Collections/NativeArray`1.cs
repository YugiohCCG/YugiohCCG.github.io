namespace Unity.Collections;

[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeArray : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray`1<T>>
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeArray<T> m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0
		private T value; //Field offset: 0x0

		public override T Current
		{
			[CallerCount(Count = 88)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 94
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public Enumerator(ref NativeArray<T>& array) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 88)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView`1))]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[ExcludeFromDocs]
		internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private ReadOnly<T> m_Array; //Field offset: 0x0
			private int m_Index; //Field offset: 0x0
			private T value; //Field offset: 0x0

			public override T Current
			{
				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				 get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[CallsUnknownMethods(Count = 2)]
				[DeduplicatedMethod]
				private get { } //Length: 94
			}

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			public Enumerator(in ReadOnly<T> array) { }

			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			public override void Dispose() { }

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public override T get_Current() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override bool MoveNext() { }

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public override void Reset() { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[NativeDisableUnsafePtrRestriction]
		internal Void* m_Buffer; //Field offset: 0x0
		internal int m_Length; //Field offset: 0x0

		public T Item
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 48
		}

		public int Length
		{
			[CallerCount(Count = 45)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CallerCount(Count = 371)]
		[DeduplicatedMethod]
		internal ReadOnly(Void* buffer, int length) { }

		[CallerCount(Count = 0)]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public ReadOnlySpan<T> AsReadOnlySpan() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public T get_Item(int index) { }

		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		public int get_Length() { }

		[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystemBurst", Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadOnly<Int32>&", "UnityEngine.Rendering.InstanceAllocators&", "UnityEngine.Rendering.CPUInstanceData&", "UnityEngine.Rendering.CPUSharedInstanceData&", "Unity.Collections.NativeParallelMultiHashMap`2<Int32, InstanceHandle>&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystemBurst", Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ReadOnly<InstanceHandle>&", "UnityEngine.Rendering.InstanceAllocators&", "UnityEngine.Rendering.CPUInstanceData&", "UnityEngine.Rendering.CPUSharedInstanceData&", "Unity.Collections.NativeParallelMultiHashMap`2<Int32, InstanceHandle>&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator<T> GetEnumerator() { }

		[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public static ReadOnlySpan<T> op_Implicit(in ReadOnly<T> source) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CalledBy(Type = "UnityEngine.Rendering.CullingJob", Member = "CalculateLODVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.InstanceFlags"}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.CullingJob", Member = "CalculateVisibilityMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "UnityEngine.Rendering.InstanceFlags"}, ReturnType = typeof(uint))]
		[CalledBy(Type = "UnityEngine.Rendering.DrawCommandOutputPerBatch", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public T UnsafeElementAt(int index) { }

	}

	[NativeDisableUnsafePtrRestriction]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule"})]
	internal Void* m_Buffer; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public T Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 48
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[WriteAccessRequired]
		 set { } //Length: 61
	}

	public int Length
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "CreateRendererListWithRenderStateBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(CullingResults&), typeof(DrawingSettings), typeof(FilteringSettings), typeof(RenderStateBlock), "UnityEngine.Rendering.RenderGraphModule.RendererListHandle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.GBufferPass", Member = "InitRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(ScriptableRenderContext), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequest", Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.UnityWebRequest", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.UploadHandlerRaw", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public NativeArray`1(T[] array, Allocator allocator) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>", "Unity.Collections.NativeArray`1<Brick>", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "ResolvePerScenarioCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>", typeof(string), "System.Collections.Generic.List`1<Int32>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectDispatcher), Member = "DispatchCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDispatchData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectDispatcher), Member = "DispatchCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformDispatchData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>", "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<InstanceHandle>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "DestroyMaterialDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<UInt32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public NativeArray`1(NativeArray<T> array, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "AlignOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MallocTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void Allocate(int length, Allocator allocator, out NativeArray<T>& array) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "FindRenderersFromMaterialsOrMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeHashSet`1<Int32>", "Unity.Collections.NativeArray`1<Int32>", typeof(Allocator)}, ReturnType = "System.ValueTuple`2<NativeList`1<Int32>, NativeList`1<Int32>>")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "SchedulePackedMaterialCacheUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>"}, ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUInstanceData+ReadOnly", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CPUInstanceData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUSharedInstanceData+ReadOnly", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CPUSharedInstanceData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "FreeInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<InstanceHandle>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "get_defaultDescriptions", ReturnType = "Unity.Collections.NativeArray`1<GPUInstanceComponentDesc>+ReadOnly<GPUInstanceComponentDesc>")]
	[CalledBy(Type = "UnityEngine.Physics", Member = "OnSceneContact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.PhysicsScene", typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rigidbody2D", Member = "set_velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnly<T> AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public ReadOnlySpan<T> AsReadOnlySpan() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	[WriteAccessRequired]
	public Span<T> AsSpan() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputControlList`1", Member = "AddSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TList", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlList`1", Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TControl>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }

	[CalledBy(Type = "UnityEngine.Rendering.ArrayExtensions", Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessRendererMaterialAndMeshChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>", "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ParallelBitArray", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.ITilemap", Member = "RefreshTile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Tilemaps.TileBase", Member = "RefreshTile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int), "UnityEngine.Tilemaps.ITilemap"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, T[] dst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static void Copy(T[] src, NativeArray<T> dst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static void Copy(NativeArray<T> src, NativeArray<T> dst) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCulledSystem", Member = "Execute", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCulledSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[WriteAccessRequired]
	public void CopyFrom(T[] array) { }

	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventBuffer", Member = "Clone", ReturnType = "UnityEngine.InputSystem.LowLevel.InputEventBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateActiveRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateDataLocationTexture", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SilhouettePlaneCache", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<Plane>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[WriteAccessRequired]
	public void CopyFrom(NativeArray<T> array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void CopyTo(T[] array) { }

	[CallerCount(Count = 249)]
	[Calls(Type = typeof(UnsafeUtility), Member = "FreeTracked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[WriteAccessRequired]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArrayDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArrayDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(NativeArray<T> other) { }

	[CalledBy(Type = typeof(Nullable`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T get_Item(int index) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CalledBy(Type = "UnityEngine.Rendering.UI.UIFoldout", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetSubPassAttachmentIndicesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScriptableRenderPass"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawerBurst", Member = "ClassifyMaterials$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "ReadOnly<Int32, BatchMaterialID>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<Int32>&", "Unity.Collections.NativeList`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "DestroyMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+WriteInstanceDataParameterJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferGrower", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer", "UnityEngine.Rendering.InstanceNumInfo&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LODGroupDataPoolBurst", Member = "FreeLODGroupData$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeList`1<LODGroupData>&", "Unity.Collections.NativeParallelHashMap`2<Int32, GPUInstanceIndex>&", "Unity.Collections.NativeList`1<GPUInstanceIndex>&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CalledBy(Type = typeof(Nullable`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Collections.Generic.GenericEqualityComparer`1", Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeArray<T> GetSubArray(int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private NativeArray<U> InternalReinterpret(int length) { }

	[CalledBy(Type = typeof(RendererListParams), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererListParams)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(NativeArray<T> left, NativeArray<T> right) { }

	[CalledBy(Type = typeof(GPUDrivenProcessor), Member = "ClassifyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static Span<T> op_Implicit(in NativeArray<T>& source) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "ProcessRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeDispatchData), "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "LoadCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+Cell", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.XRSRPSettings", Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.NativePassData", Member = "GraphPasses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.CompilerContextData", "Unity.Collections.NativeArray`1<PassData>&"}, ReturnType = "System.ReadOnlySpan`1<PassData>")]
	[CalledBy(Type = typeof(CommandBuffer), Member = "BeginRenderPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.AttachmentDescriptor>), typeof(int), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.SubPassDescriptor>), typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUDrivenProcessor), Member = "ClassifyMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<System.Int32>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.GPUDrivenPackedMaterialData>)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<InstanceHandle>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "FreeRendererGroupInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCullingBatcher", Member = "RegisterBatchMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>&", "Unity.Collections.NativeArray`1<GPUDrivenPackedMaterialData>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "UpdateLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.RenderersBatchersContext", Member = "TransformLODGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static ReadOnlySpan<T> op_Implicit(in NativeArray<T>& source) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalDrawSystem", Member = "DrawInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.CameraData&", "UnityEngine.Rendering.Universal.DecalEntityChunk", "UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalDrawCallChunk"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "DestroyDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<InstanceHandle>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CPUDrawInstanceData", Member = "DestroyMaterialDrawInstances", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<UInt32>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public NativeArray<U> Reinterpret() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "ProcessDiskStreamingRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdatePool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<BrickChunkAlloc>", "UnityEngine.Rendering.ProbeReferenceVolume+CellData+PerScenarioData", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<UInt16>", "Unity.Collections.NativeArray`1<Byte>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "UpdateSharedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<BrickChunkAlloc>", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<UInt16>", "Unity.Collections.NativeArray`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "ReleaseStreamableAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "ResolveSharedCellData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Int32>", "Unity.Collections.NativeArray`1<Brick>", "Unity.Collections.NativeArray`1<Byte>", "Unity.Collections.NativeArray`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public NativeArray<U> Reinterpret(int expectedTypeSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetData", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "InternalGetByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.DownloadHandler"}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

}

