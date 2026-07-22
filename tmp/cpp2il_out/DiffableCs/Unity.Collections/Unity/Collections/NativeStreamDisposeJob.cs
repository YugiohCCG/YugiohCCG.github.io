namespace Unity.Collections;

[BurstCompile]
internal struct NativeStreamDisposeJob : IJob
{
	public NativeStreamDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Execute() { }

}

