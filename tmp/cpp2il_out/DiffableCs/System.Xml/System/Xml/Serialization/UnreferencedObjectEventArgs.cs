namespace System.Xml.Serialization;

public class UnreferencedObjectEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private string id; //Field offset: 0x18

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnreferencedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UnreferencedObjectEventArgs(object o, string id) { }

}

