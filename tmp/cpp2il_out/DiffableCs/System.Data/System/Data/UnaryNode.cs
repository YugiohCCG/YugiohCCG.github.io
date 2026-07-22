namespace System.Data;

internal sealed class UnaryNode : ExpressionNode
{
	internal readonly int _op; //Field offset: 0x18
	internal ExpressionNode _right; //Field offset: 0x20

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "BuildExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal UnaryNode(DataTable table, int op, ExpressionNode right) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual bool DependsOn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnaryNode), Member = "EvalUnaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual object Eval(Int32[] recordNos) { }

	[CalledBy(Type = typeof(UnaryNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataExpression), Member = "IsUnknown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataExpression), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsNumericSql", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private object EvalUnaryOp(int op, object vl) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual ExpressionNode Optimize() { }

}

