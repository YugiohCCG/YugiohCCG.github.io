namespace ZXing.Rendering;

public interface IBarcodeRenderer
{

	public TOutput Render(BitMatrix matrix, BarcodeFormat format, string content) { }

	public TOutput Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options) { }

}

