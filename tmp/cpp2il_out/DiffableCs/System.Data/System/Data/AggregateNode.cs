namespace System.Data;

internal sealed class AggregateNode : ExpressionNode
{
	private readonly AggregateType _type; //Field offset: 0x18
	private readonly Aggregate _aggregate; //Field offset: 0x1C
	private readonly bool _local; //Field offset: 0x20
	private readonly string _relationName; //Field offset: 0x28
	private readonly string _columnName; //Field offset: 0x30
	private DataTable _childTable; //Field offset: 0x38
	private DataColumn _column; //Field offset: 0x40
	private DataRelation _relation; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AggregateNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(FunctionId), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName) { }

	[CalledBy(Type = typeof(AggregateNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(FunctionId), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "ParseAggregateArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId)}, ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExprException), Member = "UndefinedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_ChildRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExprException), Member = "AggregateUnbound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UnresolvedRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UnboundName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 21)]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool DependsOn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetChildRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow[]))]
	[Calls(Type = typeof(DataRowCollection), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataRow), Member = "get_RowState", ReturnType = typeof(DataRowState))]
	[Calls(Type = typeof(DataRow), Member = "GetRecordFromVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DataColumn), Member = "GetAggregateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExprException), Member = "AggregateUnbound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "EvalNoContext", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataColumn), Member = "GetAggregateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(AggregateType)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExprException), Member = "AggregateUnbound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "ComputeNotAggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 7)]
	internal virtual object Eval(Int32[] records) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal virtual ExpressionNode Optimize() { }

}

