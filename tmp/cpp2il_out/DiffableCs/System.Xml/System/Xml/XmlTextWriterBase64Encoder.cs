namespace System.Xml;

internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x28

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextEncoder), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

