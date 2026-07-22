namespace System.Xml.Serialization;

internal class XmlSerializationReaderInterpreter : XmlSerializationReader
{
	private class FixupCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		private ClassMap _map; //Field offset: 0x18
		private bool _isValueList; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "FixupMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void FixupMembers(object fixup) { }

	}

	private class ReaderCallbackInfo
	{
		private XmlSerializationReaderInterpreter _sri; //Field offset: 0x10
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object ReadObject() { }

	}

	private static readonly XmlQualifiedName AnyType; //Field offset: 0x0
	private static readonly Object[] empty_array; //Field offset: 0x8
	private XmlMapping _typeMap; //Field offset: 0xD0
	private SerializationFormat _format; //Field offset: 0xD8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static XmlSerializationReaderInterpreter() { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(XmlSerializationReader))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public XmlSerializationReaderInterpreter(XmlMapping typeMap) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeData), Member = "ConvertForAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateReadOnlyCollectionException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "FillList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateReadOnlyCollectionException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	private void CopyEnumerableList(object source, object dest) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	private object CreateInstance(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	private static object CreateInstance(Type type, bool nonPublic) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private object CreateList(Type listType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "CopyEnumerableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	private void FillList(object list, object items) { }

	[CalledBy(Type = typeof(FixupCallbackInfo), Member = "FixupMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEnumElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTypeMapping), Member = "get_TypeFullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(EnumMap), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownConstantException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetListMembersDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ToXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "AddReadCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Type), typeof(XmlSerializationReadCallback)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	protected virtual void InitCallbacks() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetListMembersDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private object InitializeList(TypeData listType) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected virtual void InitIDs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override void ProcessUnknownAttribute(object target) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override void ProcessUnknownElement(object target) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClassMap), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapMemberAttribute))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "IsXmlnsAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ParseWsdlArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "AddListValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(Object&), typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 3)]
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetXsiType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlTypeMapping), Member = "GetRealElementMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	protected override object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected override void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownNodeException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ListMap), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "AddListValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(Object&), typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTypeMapping), Member = "get_TypeFullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateReadOnlyCollectionException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 7)]
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstanceMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "AddListValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(Object&), typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClassMap), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "SetChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlTypeMapElementInfo), Member = "get_MultiReferenceType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeData), Member = "get_IsListType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ClassMap), Member = "GetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(CollectionFixup), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSerializationCollectionFixupCallback), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "AddFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionFixup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ShrinkArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Type), typeof(bool)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "CreateList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ClassMap), Member = "get_IsOrderDependentMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetListMembersDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "InitializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "get_ElementInfo", ReturnType = typeof(XmlTypeMapElementInfoList))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ListMap), Member = "FindTextElement", ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(TypeData), Member = "get_ListItemTypeData", ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateReadOnlyCollectionException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 44)]
	[CallsUnknownMethods(Count = 112)]
	[ContainsUnimplementedInstructions]
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeData), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValueFromAttr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	protected override object ReadMessage(XmlMembersMapping typeMap) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	protected override object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadElementQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable)}, ReturnType = typeof(IXmlSerializable))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetXsiType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadElementQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSerializationReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownNodeException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsInvalidInstructions]
	public object ReadRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownNodeException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private object ReadRoot(XmlTypeMapping rootMap) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable)}, ReturnType = typeof(IXmlSerializable))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CreateUnknownNodeException", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "InitializeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetListMembersDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "FixupMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "ImplicitConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "SetValueSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

}

