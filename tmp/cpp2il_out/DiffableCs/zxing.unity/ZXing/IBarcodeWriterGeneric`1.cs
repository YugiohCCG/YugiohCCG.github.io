namespace ZXing;

public interface IBarcodeWriterGeneric
{

	public BitMatrix Encode(string contents) { }

	public TOutput Write(string contents) { }

	public TOutput Write(BitMatrix matrix) { }

}

