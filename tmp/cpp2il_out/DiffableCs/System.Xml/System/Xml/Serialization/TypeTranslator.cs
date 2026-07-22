namespace System.Xml.Serialization;

internal class TypeTranslator
{
	private static Hashtable nameCache; //Field offset: 0x0
	private static Hashtable primitiveTypes; //Field offset: 0x8
	private static Hashtable primitiveArrayTypes; //Field offset: 0x10
	private static Hashtable nullableTypes; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable)}, ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(TypeData), typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaPatternFacet), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 60)]
	[CallsUnknownMethods(Count = 36)]
	private static TypeTranslator() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	[CalledBy(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(TypeData), typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(CultureInfo)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetArrayName(string elemName) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeTranslator), Member = "GetPrimitiveTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	[CalledBy(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[CalledBy(Type = typeof(TypeTranslator), Member = "GetPrimitiveTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TypeData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	[CalledBy(Type = typeof(XmlAttributes), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetReflectionMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Xml.Serialization.XmlReflectionMember>))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportAnyElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlReflectionMember), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTextElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfoList), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	public static TypeData GetTypeData(Type type) { }

	[CalledBy(Type = typeof(ReflectionHelper), Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportTextElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfoList), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportElementInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(Type), typeof(XmlTypeMapMemberElement), typeof(XmlAttributes)}, ReturnType = typeof(XmlTypeMapElementInfoList))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[CalledBy(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeData))]
	[CalledBy(Type = typeof(TypeData), Member = "get_ListItemTypeData", ReturnType = typeof(TypeData))]
	[CalledBy(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(TypeData), typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CodeIdentifier), Member = "MakePascal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "EncodeLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(TypeData), typeof(XmlSchemaPatternFacet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetArrayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetPrimitiveTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 26)]
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ParseWsdlArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriter), Member = "WriteXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

