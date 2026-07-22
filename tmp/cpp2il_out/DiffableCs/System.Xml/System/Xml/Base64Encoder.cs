namespace System.Xml;

internal abstract class Base64Encoder
{
	private Byte[] leftOverBytes; //Field offset: 0x10
	private int leftOverBytesCount; //Field offset: 0x18
	private Char[] charsLine; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Base64Encoder() { }

	[CalledBy(Type = typeof(XmlEncodedRawTextWriterIndent), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlRawWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	internal void Encode(Byte[] buffer, int index, int count) { }

	[CalledBy(Type = typeof(XmlRawWriter), Member = "WriteEndBase64", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "WriteEndDocument", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlTextWriter+Token"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "AutoCompleteAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextWriter), Member = "FlushEncoders", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Convert), Member = "ToBase64CharArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Char[]), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Flush() { }

	internal abstract void WriteChars(Char[] chars, int index, int count) { }

}

