namespace UnityEngine.Rendering;

internal struct InstanceAllocators
{
	private InstanceAllocator m_InstanceAlloc_MeshRenderer; //Field offset: 0x0
	private InstanceAllocator m_InstanceAlloc_SpeedTree; //Field offset: 0x20
	private InstanceAllocator m_SharedInstanceAlloc; //Field offset: 0x40

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InstanceAllocator), Member = "AllocateInstance", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public InstanceHandle AllocateInstance(InstanceType type) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstanceAllocator), Member = "AllocateInstance", ReturnType = typeof(int))]
	public SharedInstanceHandle AllocateSharedInstance() { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public void Dispose() { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	public void FreeInstance(InstanceHandle instance) { }

	[CalledBy(Type = typeof(WriteInstanceDataParameterJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "ReallocateInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<GPUDrivenPackedRendererData>&), typeof(NativeArray`1<Int32>&), typeof(NativeArray`1<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeArray`1<InstanceHandle>&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeRendererGroupInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<Int32>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystemBurst), Member = "FreeInstances$BurstManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly<InstanceHandle>&), typeof(InstanceAllocators&), typeof(CPUInstanceData&), typeof(CPUSharedInstanceData&), typeof(NativeParallelMultiHashMap`2<Int32, InstanceHandle>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	public void FreeSharedInstance(SharedInstanceHandle instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private InstanceAllocator GetInstanceAllocator(InstanceType type) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "GetMaxInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public int GetInstanceHandlesLength(InstanceType type) { }

	[CalledBy(Type = typeof(InstanceDataSystem), Member = "GetAliveInstancesOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public int GetInstancesLength(InstanceType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceAllocator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void Initialize() { }

}

