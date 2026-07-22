namespace System.Xml.Serialization;

public class XmlElementEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private XmlElement elem; //Field offset: 0x18
	private string qnames; //Field offset: 0x20
	private int lineNumber; //Field offset: 0x28
	private int linePosition; //Field offset: 0x2C

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlElement), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal XmlElementEventArgs(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

