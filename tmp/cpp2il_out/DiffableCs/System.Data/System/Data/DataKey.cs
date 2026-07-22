namespace System.Data;

[IsReadOnly]
internal struct DataKey
{
	private readonly DataColumn[] _columns; //Field offset: 0x0

	internal DataColumn[] ColumnsReference
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool HasValue
	{
		[CallerCount(Count = 11)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal DataTable Table
	{
		[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_Table", ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_RelatedTable", ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(RelationshipConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(UniqueConstraint), Member = "get_Table", ReturnType = typeof(DataTable))]
		[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
		[CallerCount(Count = 23)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 47
	}

	[CalledBy(Type = typeof(DataRelation), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "GetSrcKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(DataKey))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RelatedView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView), typeof(DataKey), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "HaveValuesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "HaveValuesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "GetColumnValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetColumnValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DataKey), Member = "CheckState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyDuplicateColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyTooManyColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyNoColumns", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	internal DataKey(DataColumn[] columns, bool copyColumns) { }

	[CalledBy(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRelation), Member = "CheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyTableMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnNotInAnyTable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	internal void CheckState() { }

	[CalledBy(Type = typeof(DataRelation), Member = "CheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CanBeRemovedFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstraintCollection), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool ColumnsEqual(DataKey key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_DataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumn), Member = "IsInRelation", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	internal bool ContainsColumn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object value) { }

	[CalledBy(Type = typeof(DataKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Equals(DataKey value) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal DataColumn[] get_ColumnsReference() { }

	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasValue() { }

	[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "SetParentRowToDBNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_Table", ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_RelatedTable", ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(RelationshipConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "get_Table", ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(XmlDocument)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 2)]
	internal DataTable get_Table() { }

	[CalledBy(Type = typeof(DataRelation), Member = "get_ParentColumnNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "get_ChildColumnNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_ParentColumnNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_ChildColumnNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "get_ColumnNames", ReturnType = typeof(String[]))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal String[] GetColumnNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "RemoveCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal IndexField[] GetIndexDesc() { }

	[CalledBy(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetColumnValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetColumnValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(DataRowView), Member = "CreateChildView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(bool)}, ReturnType = typeof(DataView))]
	[CalledBy(Type = typeof(RelatedView), Member = "GetParentValues", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(DataColumn), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	internal Object[] GetKeyValues(int record) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "IsConstraintViolated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CanEnableConstraint", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "ConstraintIndexInitialize", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CallsUnknownMethods(Count = 2)]
	internal Index GetSortIndex() { }

	[CalledBy(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DataKey), Member = "GetIndexDesc", ReturnType = typeof(IndexField[]))]
	[Calls(Type = typeof(DataTable), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexField[]), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(Index))]
	[CallsUnknownMethods(Count = 2)]
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	[CalledBy(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "HaveValuesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DataRow), Member = "HaveValuesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataRowVersion), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataColumn), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal bool RecordsEqual(int record1, int record2) { }

	[CalledBy(Type = typeof(DataTable), Member = "get_PrimaryKey", ReturnType = typeof(DataColumn[]))]
	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(DataTable), Member = "AddUniqueKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(DataRelation), Member = "get_ChildColumns", ReturnType = typeof(DataColumn[]))]
	[CalledBy(Type = typeof(DataRelation), Member = "get_ParentColumns", ReturnType = typeof(DataColumn[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_Columns", ReturnType = typeof(DataColumn[]))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "get_RelatedColumns", ReturnType = typeof(DataColumn[]))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "get_Columns", ReturnType = typeof(DataColumn[]))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	internal DataColumn[] ToArray() { }

}

