namespace K4os.Compression.LZ4.Streams;

public interface ILZ4Descriptor
{

	public bool BlockChecksum
	{
		 get { } //Length: 0
	}

	public int BlockSize
	{
		 get { } //Length: 0
	}

	public bool Chaining
	{
		 get { } //Length: 0
	}

	public bool ContentChecksum
	{
		 get { } //Length: 0
	}

	public Nullable<Int64> ContentLength
	{
		 get { } //Length: 0
	}

	public Nullable<UInt32> Dictionary
	{
		 get { } //Length: 0
	}

	public bool get_BlockChecksum() { }

	public int get_BlockSize() { }

	public bool get_Chaining() { }

	public bool get_ContentChecksum() { }

	public Nullable<Int64> get_ContentLength() { }

	public Nullable<UInt32> get_Dictionary() { }

}

