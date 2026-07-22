namespace System.Xml;

internal class ReadContentAsBinaryHelper
{
	private enum State
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2,
	}

	private XmlReader reader; //Field offset: 0x10
	private State state; //Field offset: 0x18
	private int valueOffset; //Field offset: 0x1C
	private bool isEnd; //Field offset: 0x20

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "FinishReadBinary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToElement", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlNodeReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdValidatingReader), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IXmlLineInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	internal void Finish() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	[CallerCount(Count = 0)]
	internal void Reset() { }

}

