namespace System.Data;

internal sealed class XDRSchema : XMLSchema
{
	private sealed class NameType : IComparable
	{
		public string name; //Field offset: 0x10
		public Type type; //Field offset: 0x18

		[CallerCount(Count = 40)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public NameType(string n, Type t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int CompareTo(object obj) { }

	}

	private static readonly Char[] s_colonArray; //Field offset: 0x0
	private static NameType[] s_mapNameTypeXdr; //Field offset: 0x8
	private static NameType s_enumerationNameType; //Field offset: 0x10
	internal string _schemaName; //Field offset: 0x10
	internal string _schemaUri; //Field offset: 0x18
	internal XmlElement _schemaRoot; //Field offset: 0x20
	internal DataSet _ds; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XDRSchema), Member = "FindNameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameType))]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 113)]
	private static XDRSchema() { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal XDRSchema(DataSet ds, bool fInline) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UndefinedDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	private static NameType FindNameType(string name) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XMLSchema), Member = "FEqualIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 3)]
	internal XmlElement FindTypeNode(XmlElement node) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MissingAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	internal string GetInstanceName(XmlElement node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "IsXDRField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AttributeValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTypeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_SimpleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SimpleType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_AllowDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeTypeForXML", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(MappingType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_DefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MissingAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SimpleType), Member = "CreateByteArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SimpleType))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CannotConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SimpleType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XDRSchema), Member = "FindNameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameType))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XMLSchema), Member = "FEqualIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(XDRSchema), Member = "GetInstanceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XDRSchema), Member = "FindTypeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "UndefinedDatatype", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	internal void HandleColumn(XmlElement node, DataTable table) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "LoadSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTypeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable), typeof(ArrayList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XDRSchema), Member = "FindTypeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XDRSchema), Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XDRSchema), Member = "IsXDRField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal DataTable HandleTable(XmlElement node) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(XmlElement), typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XMLSchema), Member = "FEqualIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "DuplicateDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "set_ColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(XDRSchema), Member = "HandleColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XDRSchema), Member = "GetInstanceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn), typeof(DataColumn), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "AddForeignKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTable), Member = "AddUniqueKey", ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(XMLSchema), Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlAttributeCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XDRSchema), Member = "HandleTypeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(DataTable), typeof(ArrayList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "GetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XDRSchema), Member = "GetInstanceName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	internal bool IsTextOnlyContent(XmlElement node) { }

	[CalledBy(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XMLSchema), Member = "FEqualIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XDRSchema), Member = "GetMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(bool), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	[CalledBy(Type = typeof(DataSet), Member = "ReadXDRSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = "set_Namespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XMLSchema), Member = "FEqualIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XDRSchema), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataSet), Member = "set_DataSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XDRSchema), Member = "FindNameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameType))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MissingAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	private Type ParseDataType(string dt, string dtValues) { }

}

