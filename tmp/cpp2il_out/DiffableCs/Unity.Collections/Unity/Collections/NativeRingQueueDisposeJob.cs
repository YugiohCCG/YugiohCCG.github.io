namespace Unity.Collections;

[BurstCompile]
internal struct NativeRingQueueDisposeJob : IJob
{
	public NativeRingQueueDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeRingQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Execute() { }

}

