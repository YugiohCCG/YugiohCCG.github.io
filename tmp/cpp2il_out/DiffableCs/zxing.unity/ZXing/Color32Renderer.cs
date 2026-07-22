namespace ZXing;

public class Color32Renderer : IBarcodeRenderer<Color32[]>
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Color32Renderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "getRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CallsUnknownMethods(Count = 2)]
	public override Color32[] Render(BitMatrix matrix, BarcodeFormat format, string content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "getRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(BitArray))]
	[CallsUnknownMethods(Count = 2)]
	public override Color32[] Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options) { }

}

