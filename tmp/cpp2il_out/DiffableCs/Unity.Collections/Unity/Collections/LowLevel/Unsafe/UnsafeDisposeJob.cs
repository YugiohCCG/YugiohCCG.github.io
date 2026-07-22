namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompile]
internal struct UnsafeDisposeJob : IJob
{
	[NativeDisableUnsafePtrRestriction]
	public Void* Ptr; //Field offset: 0x0
	public AllocatorHandle Allocator; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorManager), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle), typeof(Void*)}, ReturnType = typeof(void))]
	public override void Execute() { }

}

