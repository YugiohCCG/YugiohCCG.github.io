namespace ZXing;

public sealed class WriterException : Exception
{

	[CalledBy(Type = typeof(Encoder), Member = "appendAlphanumericBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedBasicPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedDarkDotAtLeftBottomCorner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedHorizontalSeparationPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedVerticalSeparationPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public WriterException() { }

	[CalledBy(Type = typeof(PDF417), Member = "generateBarcodeLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "makeVersionInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "makeTypeInfoBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCorrectionLevel), typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "embedDataBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MatrixUtil), Member = "maybeEmbedVersionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(ByteMatrix)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "appendKanjiBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "appendBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mode), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "appendLengthInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Version), typeof(Mode), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "interleaveWithECBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(BitArray))]
	[CalledBy(Type = typeof(Encoder), Member = "terminateBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BitArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "chooseVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCorrectionLevel)}, ReturnType = typeof(Version))]
	[CalledBy(Type = typeof(Encoder), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ErrorCorrectionLevel), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(QRCode))]
	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "encodingECI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PDF417HighLevelEncoder), Member = "determineConsecutiveBinaryCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PDF417ErrorCorrection), Member = "getRecommendedMinimumErrorCorrectionLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PDF417), Member = "determineDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Encoder), Member = "getNumDataBytesAndNumECBytesForBlockID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public WriterException(string message) { }

	[CalledBy(Type = typeof(Encoder), Member = "append8BitBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoder), Member = "appendKanjiBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BitArray)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public WriterException(string message, Exception innerExc) { }

}

