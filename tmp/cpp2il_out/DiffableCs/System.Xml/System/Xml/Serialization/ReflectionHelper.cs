namespace System.Xml.Serialization;

internal class ReflectionHelper
{
	private static readonly ParameterModifier[] empty_modifiers; //Field offset: 0x0
	private Hashtable _clrTypes; //Field offset: 0x10
	private Hashtable _schemaTypes; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static ReflectionHelper() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeOverrides), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ReflectionHelper() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlNodeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportPrimitiveMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlNodeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportPrimitiveMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

}

