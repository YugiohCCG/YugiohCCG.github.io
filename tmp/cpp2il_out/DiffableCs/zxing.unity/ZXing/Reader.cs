namespace ZXing;

public interface Reader
{

	public Result decode(BinaryBitmap image) { }

	public Result decode(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

	public void reset() { }

}

