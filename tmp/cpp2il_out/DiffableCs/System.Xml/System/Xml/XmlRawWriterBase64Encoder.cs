namespace System.Xml;

internal class XmlRawWriterBase64Encoder : Base64Encoder
{
	private XmlRawWriter rawWriter; //Field offset: 0x28

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

