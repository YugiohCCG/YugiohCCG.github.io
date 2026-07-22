namespace ZXing.Datamatrix.Encoder;

internal interface Encoder
{

	public int EncodingMode
	{
		 get { } //Length: 0
	}

	public void encode(EncoderContext context) { }

	public int get_EncodingMode() { }

}

