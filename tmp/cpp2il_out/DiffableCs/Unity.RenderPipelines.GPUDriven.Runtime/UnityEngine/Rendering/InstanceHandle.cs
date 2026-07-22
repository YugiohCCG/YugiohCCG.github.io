namespace UnityEngine.Rendering;

internal struct InstanceHandle : IEquatable<InstanceHandle>, IComparable<InstanceHandle>
{
	public static readonly InstanceHandle Invalid; //Field offset: 0x0
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x0

	public private int index
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 3
	}

	public int instanceIndex
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 68
	}

	public InstanceType type
	{
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+GetVisibleNonProcessedTreeInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 69
	}

	public bool valid
	{
		[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+ProbesUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 70
	}

	[CallerCount(Count = 0)]
	private static InstanceHandle() { }

	[CalledBy(Type = typeof(DefaultComparer`1), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public override int CompareTo(InstanceHandle other) { }

	[CallerCount(Count = 0)]
	public static InstanceHandle Create(int instanceIndex, InstanceType instanceType) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InstanceHandle other) { }

	[CalledBy(Type = typeof(AllocateBinsPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "EncodeGPUInstanceIndexAndCrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "IsInstanceFlipped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DrawCommandOutputPerBatch), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public static InstanceHandle FromInt(int value) { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_index() { }

	[CallerCount(Count = 0)]
	public int get_instanceIndex() { }

	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+GetVisibleNonProcessedTreeInstancesJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public InstanceType get_type() { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem+ProbesUpdateJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_index(int value) { }

}

