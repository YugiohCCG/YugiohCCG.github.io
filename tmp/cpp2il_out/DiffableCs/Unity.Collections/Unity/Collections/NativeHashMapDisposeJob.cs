namespace Unity.Collections;

[BurstCompile]
internal struct NativeHashMapDisposeJob : IJob
{
	internal NativeHashMapDispose Data; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<TKey>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Execute() { }

}

