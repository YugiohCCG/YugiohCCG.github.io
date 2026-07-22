namespace ZXing.Multi;

public interface MultipleBarcodeReader
{

	public Result[] decodeMultiple(BinaryBitmap image) { }

	public Result[] decodeMultiple(BinaryBitmap image, IDictionary<DecodeHintType, Object> hints) { }

}

