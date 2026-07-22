namespace System.Xml.Serialization;

internal class XmlTypeSerializationSource : SerializationSource
{
	private string attributeOverridesHash; //Field offset: 0x28
	private Type type; //Field offset: 0x30
	private string rootHash; //Field offset: 0x38

	[CalledBy(Type = typeof(XmlSerializerFactory), Member = "CreateSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlAttributeOverrides), typeof(Type[]), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlSerializer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeOverrides), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlRootAttribute), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

