namespace Unity.Collections;

[BurstCompile]
internal struct NativeQueueDisposeJob : IJob
{
	public NativeQueueDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Execute() { }

}

