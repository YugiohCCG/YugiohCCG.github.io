namespace System.Data;

[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint
{
	internal Rule _deleteRule; //Field offset: 0x38
	internal Rule _updateRule; //Field offset: 0x3C
	internal AcceptRejectRule _acceptRejectRule; //Field offset: 0x40
	private DataKey _childKey; //Field offset: 0x48
	private DataKey _parentKey; //Field offset: 0x50
	internal string _constraintName; //Field offset: 0x58
	internal String[] _parentColumnNames; //Field offset: 0x60
	internal String[] _childColumnNames; //Field offset: 0x68
	internal string _parentTableName; //Field offset: 0x70

	[DefaultValue(AcceptRejectRule::None (0))]
	public override AcceptRejectRule AcceptRejectRule
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ADP), Member = "InvalidAcceptRejectRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AcceptRejectRule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 77
	}

	internal String[] ChildColumnNames
	{
		[CalledBy(Type = typeof(ConstraintConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataKey), Member = "GetColumnNames", ReturnType = typeof(String[]))]
		internal get { } //Length: 11
	}

	internal DataKey ChildKey
	{
		[CalledBy(Type = typeof(ConstraintCollection), Member = "FindForeignKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(ForeignKeyConstraint))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataColumn[] Columns
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	public override Rule DeleteRule
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ADP), Member = "InvalidRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 77
	}

	internal String[] ParentColumnNames
	{
		[CalledBy(Type = typeof(ConstraintConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DataKey), Member = "GetColumnNames", ReturnType = typeof(String[]))]
		internal get { } //Length: 11
	}

	internal DataKey ParentKey
	{
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataColumn[] RelatedColumns
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
		 get { } //Length: 32
	}

	internal DataColumn[] RelatedColumnsReference
	{
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal get { } //Length: 26
	}

	[ReadOnly(True)]
	public override DataTable RelatedTable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
		 get { } //Length: 32
	}

	[ReadOnly(True)]
	public virtual DataTable Table
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
		 get { } //Length: 32
	}

	[DefaultValue(Rule::Cascade (1))]
	public override Rule UpdateRule
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ADP), Member = "InvalidRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 77
	}

	[CalledBy(Type = typeof(DataSetRelationCollection), Member = "AddCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Constraint), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[CalledBy(Type = typeof(DataTable), Member = "DeserializeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XSDSchema), Member = "HandleKeyref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaKeyref)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Constraint), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public ForeignKeyConstraint(string constraintName, string parentTableName, String[] parentColumnNames, String[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "GetUniqueKeyValues", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual bool CanEnableConstraint() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void CascadeCommit(DataRow row) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "DeleteRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Index), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "FailedCascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal void CascadeDelete(DataRow row) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRow), Member = "RejectChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "FailedCascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	internal void CascadeRollback(DataRow row) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataColumn), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRow), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "FailedCascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal void CascadeUpdate(DataRow row) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "CaseLocaleMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ConstraintAddFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual void CheckCanAddToCollection(ConstraintCollection constraints) { }

	[CalledBy(Type = typeof(DataTable), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "FailedClearParentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	internal void CheckCanClearParentTable(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "RemoveRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RemoveParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForeignKeyConstraint)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void CheckCanRemoveParentRow(DataRow row) { }

	[CalledBy(Type = typeof(DataTable), Member = "CascadeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CascadeRollback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRow), Member = "AcceptChanges", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ForeignKeyViolation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataColumn), Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumn), Member = "ConvertValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "IsKeyNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataKey), Member = "RecordsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "NewRecord", ReturnType = typeof(int))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataRowVersion)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRelation), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(DataKey), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "GetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataRow), Member = "HasKeyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "SetKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey), typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal virtual void CheckConstraint(DataRow childRow, DataRowAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	internal virtual void CheckState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 22)]
	internal virtual Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	[CalledBy(Type = typeof(DataTable), Member = "CloneTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataSet), typeof(bool)}, ReturnType = typeof(DataTable))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataColumnCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 21)]
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual Constraint Clone(DataSet destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = "ContainsColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(bool))]
	internal virtual bool ContainsColumn(DataColumn column) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool)}, ReturnType = typeof(Constraint))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(ForeignKeyConstraint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ForeignKeyConstraint), Member = "NonVirtualCheckState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ExpressionInConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyLengthMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyLengthZero", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "ColumnsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object key) { }

	[CalledBy(Type = typeof(XmlTreeGen), Member = "AutoGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ForeignKeyConstraint), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTreeGen), Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(XmlDocument), typeof(XmlElement), typeof(bool)}, ReturnType = typeof(XmlElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal DataRelation FindParentRelation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	public override AcceptRejectRule get_AcceptRejectRule() { }

	[CalledBy(Type = typeof(ConstraintConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataKey), Member = "GetColumnNames", ReturnType = typeof(String[]))]
	internal String[] get_ChildColumnNames() { }

	[CalledBy(Type = typeof(ConstraintCollection), Member = "FindForeignKeyConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(ForeignKeyConstraint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	internal DataKey get_ChildKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
	public override DataColumn[] get_Columns() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	public override Rule get_DeleteRule() { }

	[CalledBy(Type = typeof(ConstraintConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataKey), Member = "GetColumnNames", ReturnType = typeof(String[]))]
	internal String[] get_ParentColumnNames() { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DataKey get_ParentKey() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "ToArray", ReturnType = typeof(DataColumn[]))]
	public override DataColumn[] get_RelatedColumns() { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DataColumn[] get_RelatedColumnsReference() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	public override DataTable get_RelatedTable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	public virtual DataTable get_Table() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Constraint), Member = "CheckStateForProperty", ReturnType = typeof(void))]
	public override Rule get_UpdateRule() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", ReturnType = typeof(Index))]
	[Calls(Type = typeof(Index), Member = "GetUniqueKeyValues", ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[Calls(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeysToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataRow), Member = "set_RowError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual bool IsConstraintViolated() { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeCommit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CascadeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckCascade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool IsKeyNull(Object[] values) { }

	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "CheckState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ForeignKeyConstraint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataKey), Member = "CheckState", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "get_Table", ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataKey), Member = "ColumnsEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ColumnsTypeMismatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "KeyColumnsIdentical", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TablesInDifferentSets", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void NonVirtualCheckState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ADP), Member = "InvalidAcceptRejectRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AcceptRejectRule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_AcceptRejectRule(AcceptRejectRule value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ADP), Member = "InvalidRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_DeleteRule(Rule value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ADP), Member = "InvalidRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rule)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsUnknownMethods(Count = 4)]
	public override void set_UpdateRule(Rule value) { }

}

