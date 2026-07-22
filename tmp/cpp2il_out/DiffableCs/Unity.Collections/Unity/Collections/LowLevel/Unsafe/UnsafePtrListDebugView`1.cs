namespace Unity.Collections.LowLevel.Unsafe;

internal sealed class UnsafePtrListDebugView
{
	private UnsafePtrList<T> Data; //Field offset: 0x0

	public T*[] Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 169
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UnsafePtrListDebugView`1(UnsafePtrList<T> data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T*[] get_Items() { }

}

