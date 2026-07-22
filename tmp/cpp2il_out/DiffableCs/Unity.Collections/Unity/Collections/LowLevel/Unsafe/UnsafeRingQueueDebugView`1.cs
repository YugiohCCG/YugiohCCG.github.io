namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafeRingQueueDebugView
{
	private UnsafeRingQueue<T> Data; //Field offset: 0x0

	public T[] Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 401
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafeRingQueueDebugView`1(UnsafeRingQueue<T> data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public T[] get_Items() { }

}

