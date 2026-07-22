namespace System.Data;

internal sealed class LookupNode : ExpressionNode
{
	private readonly string _relationName; //Field offset: 0x18
	private readonly string _columnName; //Field offset: 0x20
	private DataColumn _column; //Field offset: 0x28
	private DataRelation _relation; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal LookupNode(DataTable table, string columnName, string relationName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataTable), Member = "get_ParentRelations", ReturnType = typeof(DataRelationCollection))]
	[Calls(Type = typeof(DataColumnCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DataColumn))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExprException), Member = "UnboundName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "BindFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EvaluateException))]
	[Calls(Type = typeof(ExprException), Member = "UnresolvedRelation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "ExpressionUnbound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 21)]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal virtual bool DependsOn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExprException), Member = "EvalNoContext", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual object Eval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataRow), Member = "GetParentRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRelation), typeof(DataRowVersion)}, ReturnType = typeof(DataRow))]
	[Calls(Type = typeof(DataRow), Member = "HasVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataRow), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExprException), Member = "ExpressionUnbound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExprException), Member = "ComputeNotAggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual object Eval(Int32[] recordNos) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal virtual ExpressionNode Optimize() { }

}

