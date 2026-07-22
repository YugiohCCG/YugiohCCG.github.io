namespace System.Buffers;

public interface IBufferWriter
{

	public void Advance(int count) { }

	public Span<T> GetSpan(int sizeHint = 0) { }

}

