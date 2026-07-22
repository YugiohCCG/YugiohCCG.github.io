namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
internal struct NativeStreamDispose
{
	public UnsafeStream m_StreamData; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeStream), Member = "Deallocate", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Dispose() { }

}

