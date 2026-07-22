namespace K4os.Compression.LZ4.Encoders;

public interface ILZ4Encoder : IDisposable
{

	public int BlockSize
	{
		 get { } //Length: 0
	}

	public int BytesReady
	{
		 get { } //Length: 0
	}

	public int Encode(Byte* target, int length, bool allowCopy) { }

	public int get_BlockSize() { }

	public int get_BytesReady() { }

	public int Topup(Byte* source, int length) { }

}

