namespace Unity.Collections;

[BurstCompile]
internal struct NativeBitArrayDisposeJob : IJob
{
	public NativeBitArrayDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
	public override void Execute() { }

}

