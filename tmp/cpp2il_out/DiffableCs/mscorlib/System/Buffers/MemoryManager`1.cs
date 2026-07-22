namespace System.Buffers;

public abstract class MemoryManager
{

	public abstract Span<T> GetSpan() { }

	public abstract MemoryHandle Pin(int elementIndex = 0) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private override bool TryGetArray(out ArraySegment<T>& segment) { }

}

