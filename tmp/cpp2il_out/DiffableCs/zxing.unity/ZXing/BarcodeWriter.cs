namespace ZXing;

public class BarcodeWriter : BarcodeWriterGeneric<Color32[]>, IBarcodeWriter
{

	[CalledBy(Type = "Data.QRCode", Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "UnityEngine.Color32[]")]
	[CalledBy(Type = "Data.QRCode", Member = "GenerateQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public BarcodeWriter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeWriterGeneric`1), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BitMatrix))]
	private override BitMatrix ZXing.IBarcodeWriter.Encode(string contents) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TOutput")]
	private override Color32[] ZXing.IBarcodeWriter.Write(string contents) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BarcodeWriterGeneric`1), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = "TOutput")]
	private override Color32[] ZXing.IBarcodeWriter.Write(BitMatrix matrix) { }

}

