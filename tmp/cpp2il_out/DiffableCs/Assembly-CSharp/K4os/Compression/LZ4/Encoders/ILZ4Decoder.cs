namespace K4os.Compression.LZ4.Encoders;

public interface ILZ4Decoder : IDisposable
{

	public int BlockSize
	{
		 get { } //Length: 0
	}

	public int BytesReady
	{
		 get { } //Length: 0
	}

	public int Decode(Byte* source, int length, int blockSize = 0) { }

	public void Drain(Byte* target, int offset, int length) { }

	public int get_BlockSize() { }

	public int get_BytesReady() { }

	public int Inject(Byte* source, int length) { }

}

