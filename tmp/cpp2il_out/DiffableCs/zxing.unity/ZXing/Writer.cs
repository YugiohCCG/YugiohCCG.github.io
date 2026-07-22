namespace ZXing;

public interface Writer
{

	public BitMatrix encode(string contents, BarcodeFormat format, int width, int height) { }

	public BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

}

