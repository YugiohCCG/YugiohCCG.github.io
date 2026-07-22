namespace System.Xml.Serialization;

internal class XmlSerializationWriterInterpreter : XmlSerializationWriter
{
	private class CallbackInfo
	{
		private XmlSerializationWriterInterpreter _swi; //Field offset: 0x10
		private XmlTypeMapping _typeMap; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void WriteEnum(object ob) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void WriteObject(object ob) { }

	}

	private XmlMapping _typeMap; //Field offset: 0x48
	private SerializationFormat _format; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public XmlSerializationWriterInterpreter(XmlMapping typeMap) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumMap), Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int GetListCount(TypeData listType, object ob) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveValueEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlTypeMapping), typeof(TypeData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WritePrimitiveElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "FromXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(EnumMap), Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	internal static object ImplicitConvert(object obj, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "AddWriteCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(string), typeof(XmlSerializationWriteCallback)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	protected virtual void InitCallbacks() { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValueSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(XmlTypeMapMemberAnyElement), Member = "IsElementDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "CreateUnknownAnyElementException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 27)]
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObjectElementAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXmlAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClassMap), Member = "get_AttributeMembers", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteObjectElementElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "MemberHasValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMember), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMemberElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAnyElementContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapMemberAnyElement), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTypeMapMemberElement), Member = "get_ElementInfo", ReturnType = typeof(XmlTypeMapElementInfoList))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 20)]
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumMap), Member = "GetXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "CreateUnknownTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeData), Member = "GetIndexerProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteMemberElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ListMap), Member = "FindElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object)}, ReturnType = typeof(XmlTypeMapElementInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 35)]
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(ListMap), Member = "GetArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "FromXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected override void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeData), typeof(ListMap), typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "TopLevelElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	protected override void WriteMessage(XmlMembersMapping membersMap, Object[] parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "ImplicitConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteXsiType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable), typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullTagLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	protected override void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTypeMapMember), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNamespaceDeclarations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected override void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteElementMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected override void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullableStringEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameEncoded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteElementQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullableStringLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteNullableQualifiedNameLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSerializationWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteStartDocument", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "TopLevelElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WritePotentiallyReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(object), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "WriteReferencedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "CreateUnknownTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void WriteRoot(object ob) { }

}

