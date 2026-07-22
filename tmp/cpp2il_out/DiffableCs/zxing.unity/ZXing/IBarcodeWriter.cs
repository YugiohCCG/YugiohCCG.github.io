namespace ZXing;

public interface IBarcodeWriter
{

	public BitMatrix Encode(string contents) { }

	public Color32[] Write(string contents) { }

	public Color32[] Write(BitMatrix matrix) { }

}

