namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
internal struct NativeQueueDispose
{
	[NativeDisableUnsafePtrRestriction]
	public UnsafeQueue<Int32>* m_QueueData; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeQueue`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.UnsafeQueue`1<T>*"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Dispose() { }

}

