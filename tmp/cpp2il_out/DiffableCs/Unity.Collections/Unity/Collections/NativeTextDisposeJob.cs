namespace Unity.Collections;

[BurstCompile]
internal struct NativeTextDisposeJob : IJob
{
	public NativeTextDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeTextDispose), Member = "Dispose", ReturnType = typeof(void))]
	public override void Execute() { }

}

