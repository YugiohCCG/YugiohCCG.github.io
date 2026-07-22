namespace Unity.Collections;

[BurstCompile]
internal struct UnsafeQueueDisposeJob : IJob
{
	public UnsafeQueueDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueueDispose), Member = "Dispose", ReturnType = typeof(void))]
	public override void Execute() { }

}

