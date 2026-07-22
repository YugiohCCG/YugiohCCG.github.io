namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlAttributeOverrides
{
	private Hashtable overrides; //Field offset: 0x10

	public XmlAttributes Item
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 get { } //Length: 25
	}

	public XmlAttributes Item
	{
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlNodeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportPrimitiveMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetReflectionMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Xml.Serialization.XmlReflectionMember>))]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 215
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlAttributeOverrides() { }

	[CalledBy(Type = typeof(XmlTypeSerializationSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(XmlAttributeOverrides), typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlAttributes), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	internal void AddKeyHash(StringBuilder sb) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public XmlAttributes get_Item(Type type) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlNodeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportPrimitiveMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetReflectionMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Xml.Serialization.XmlReflectionMember>))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public XmlAttributes get_Item(Type type, string member) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private TypeMember GetKey(Type type, string member) { }

}

