namespace Unity.Collections;

public struct DoubleRewindableAllocators : IDisposable
{
	private RewindableAllocator* Pointer; //Field offset: 0x0
	private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper0; //Field offset: 0x8
	private AllocatorHelper<RewindableAllocator> UpdateAllocatorHelper1; //Field offset: 0x18

	public RewindableAllocator Allocator
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 55
	}

	internal bool EnableBlockFree
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewindableAllocator), Member = "get_EnableBlockFree", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 68
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewindableAllocator), Member = "set_EnableBlockFree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		internal set { } //Length: 114
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoubleRewindableAllocators), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	public DoubleRewindableAllocators(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckIsCreated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewindableAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHelper`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	public RewindableAllocator get_Allocator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewindableAllocator), Member = "get_EnableBlockFree", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool get_EnableBlockFree() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCreated() { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AllocatorHelper`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RewindableAllocator), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleRewindableAllocators), Member = "Update", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Initialize(AllocatorHandle backingAllocator, int initialSizeInBytes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewindableAllocator), Member = "set_EnableBlockFree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void set_EnableBlockFree(bool value) { }

	[CalledBy(Type = typeof(DoubleRewindableAllocators), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewindableAllocator), Member = "Rewind", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update() { }

}

