namespace Unity.Collections;

[BurstCompile]
[GenerateTestsForBurstCompatibility]
internal struct NativeListDisposeJob : IJob
{
	internal NativeListDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Int32>), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeList`1<Int32>*)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Execute() { }

}

