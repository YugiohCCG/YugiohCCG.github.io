namespace System.Xml.Serialization;

public class XmlNodeEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private XmlNode xmlNode; //Field offset: 0x18
	private int lineNumber; //Field offset: 0x20
	private int linePosition; //Field offset: 0x24

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

