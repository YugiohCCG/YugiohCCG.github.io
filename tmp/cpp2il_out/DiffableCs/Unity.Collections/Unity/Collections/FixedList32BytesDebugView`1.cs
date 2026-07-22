namespace Unity.Collections;

internal sealed class FixedList32BytesDebugView
{
	private FixedList32Bytes<T> m_List; //Field offset: 0x0

	public T[] Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedList32BytesDebugView`1(FixedList32Bytes<T> list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public T[] get_Items() { }

}

