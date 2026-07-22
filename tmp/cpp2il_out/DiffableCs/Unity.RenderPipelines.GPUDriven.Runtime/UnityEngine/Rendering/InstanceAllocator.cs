namespace UnityEngine.Rendering;

internal struct InstanceAllocator
{
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	private NativeList<Int32> m_FreeInstances; //Field offset: 0x10
	private int m_BaseInstanceOffset; //Field offset: 0x18
	private int m_InstanceStride; //Field offset: 0x1C

	public int length
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool valid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 50
	}

	[CalledBy(Type = typeof(InstanceAllocators), Member = "AllocateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(InstanceHandle))]
	[CalledBy(Type = typeof(InstanceAllocators), Member = "AllocateSharedInstance", ReturnType = typeof(SharedInstanceHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeList`1), Member = "RemoveAtSwapBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public int AllocateInstance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<System.Int32>), Member = "Dispose", ReturnType = typeof(void))]
	public void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	public void FreeInstance(int instance) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_length() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumAllocated() { }

	[CalledBy(Type = typeof(InstanceAllocators), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceDataSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public void Initialize(int baseInstanceOffset = 0, int instanceStride = 1) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_length(int value) { }

}

