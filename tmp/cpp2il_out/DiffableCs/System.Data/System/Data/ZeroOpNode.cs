namespace System.Data;

internal sealed class ZeroOpNode : ExpressionNode
{
	internal readonly int _op; //Field offset: 0x18

	[CalledBy(Type = typeof(BinaryNode), Member = "Optimize", ReturnType = typeof(ExpressionNode))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "BuildExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal ZeroOpNode(int op) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	internal virtual object Eval() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval(Int32[] recordNos) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal virtual ExpressionNode Optimize() { }

}

