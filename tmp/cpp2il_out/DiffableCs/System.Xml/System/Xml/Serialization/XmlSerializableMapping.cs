namespace System.Xml.Serialization;

internal class XmlSerializableMapping : XmlTypeMapping
{
	private XmlSchema _schema; //Field offset: 0x78
	private XmlSchemaComplexType _schemaType; //Field offset: 0x80
	private XmlQualifiedName _schemaTypeName; //Field offset: 0x88

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaSet), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaType), Member = "get_QualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 52)]
	internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

}

