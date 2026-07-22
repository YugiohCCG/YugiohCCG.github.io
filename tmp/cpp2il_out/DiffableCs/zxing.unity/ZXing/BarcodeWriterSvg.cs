namespace ZXing;

public class BarcodeWriterSvg : BarcodeWriterGeneric<SvgImage>
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SvgRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BarcodeWriterSvg() { }

}

