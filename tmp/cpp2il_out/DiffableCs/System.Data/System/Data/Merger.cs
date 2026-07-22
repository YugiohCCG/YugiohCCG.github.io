namespace System.Data;

internal sealed class Merger
{
	private DataSet _dataSet; //Field offset: 0x10
	private DataTable _dataTable; //Field offset: 0x18
	private bool _preserveChanges; //Field offset: 0x20
	private MissingSchemaAction _missingSchemaAction; //Field offset: 0x24
	private bool _isStandAlonetable; //Field offset: 0x28
	private bool _IgnoreNSforTableLookup; //Field offset: 0x29

	[CalledBy(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[CalledBy(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MergeConstraints(DataSet source) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(ConstraintCollection), Member = "FindConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(Constraint))]
	[Calls(Type = typeof(Constraint), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(Merger), Member = "MergeExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyCollection), typeof(PropertyCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataSet), Member = "RaiseMergeFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstraintCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private void MergeConstraints(DataTable table) { }

	[CalledBy(Type = typeof(DataSet), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", ReturnType = typeof(void))]
	[Calls(Type = typeof(Merger), Member = "MergeExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyCollection), typeof(PropertyCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Merger), Member = "MergeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 61)]
	internal void MergeDataSet(DataSet source) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[CalledBy(Type = typeof(Merger), Member = "MergeConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MergeMissingDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Merger), Member = "MergeExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyCollection), typeof(PropertyCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataSet), Member = "RaiseMergeFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataRelation), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(DataRelationCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRelation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataColumn[]), typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataRelation), Member = "get_ParentKey", ReturnType = typeof(DataKey))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataRelationCollection), Member = "InternalIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 17)]
	private void MergeRelation(DataRelation relation) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "MergeMissingDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataTableCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(DataTable), Member = "set_PrimaryKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(CultureInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "get_PrimaryKey", ReturnType = typeof(DataColumn[]))]
	[Calls(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Merger), Member = "MergeExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyCollection), typeof(PropertyCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumn), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(DataSet), Member = "RaiseMergeFailed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataColumnCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 22)]
	private DataTable MergeSchema(DataTable table) { }

	[CalledBy(Type = typeof(DataTable), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(bool), typeof(MissingSchemaAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataSet), Member = "set_EnforceConstraints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Merger), Member = "MergeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "get_Namespace", ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTableCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(DataTable), Member = "EvaluateExpressions", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_EnforceConstraints", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataTable), Member = "EnableConstraints", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal void MergeTable(DataTable src) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataTable), Member = "SuspendIndexEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(DataKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataKey), Member = "GetSortIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewRowState)}, ReturnType = typeof(Index))]
	[Calls(Type = typeof(DataTable), Member = "FindMergeTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataKey), typeof(Index)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataTable), Member = "MergeRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRow), typeof(bool), typeof(Index)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataTable), Member = "RestoreIndexEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_ExtendedProperties", ReturnType = typeof(PropertyCollection))]
	[Calls(Type = typeof(Merger), Member = "MergeExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyCollection), typeof(PropertyCollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	private void MergeTable(DataTable src, DataTable dst) { }

	[CalledBy(Type = typeof(Merger), Member = "MergeDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Merger), Member = "MergeSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(DataTable))]
	[Calls(Type = typeof(Merger), Member = "MergeTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(DataTable)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void MergeTableData(DataTable src) { }

}

