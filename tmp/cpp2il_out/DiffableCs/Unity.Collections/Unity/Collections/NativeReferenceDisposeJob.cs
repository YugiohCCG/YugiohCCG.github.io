namespace Unity.Collections;

[BurstCompile]
internal struct NativeReferenceDisposeJob : IJob
{
	internal NativeReferenceDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeReferenceDispose), Member = "Dispose", ReturnType = typeof(void))]
	public override void Execute() { }

}

