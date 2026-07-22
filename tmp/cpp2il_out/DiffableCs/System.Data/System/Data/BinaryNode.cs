namespace System.Data;

internal class BinaryNode : ExpressionNode
{
	private enum DataTypePrecedence
	{
		SqlDateTime = 25,
		DateTimeOffset = 24,
		DateTime = 23,
		TimeSpan = 20,
		SqlDouble = 19,
		Double = 18,
		SqlSingle = 17,
		Single = 16,
		SqlDecimal = 15,
		Decimal = 14,
		SqlMoney = 13,
		UInt64 = 12,
		SqlInt64 = 11,
		Int64 = 10,
		UInt32 = 9,
		SqlInt32 = 8,
		Int32 = 7,
		UInt16 = 6,
		SqlInt16 = 5,
		Int16 = 4,
		Byte = 3,
		SqlByte = 2,
		SByte = 1,
		Error = 0,
		SqlBoolean = -1,
		Boolean = -2,
		SqlGuid = -3,
		SqlString = -4,
		String = -5,
		SqlXml = -6,
		SqlChars = -7,
		Char = -8,
		SqlBytes = -9,
		SqlBinary = -10,
	}

	internal int _op; //Field offset: 0x18
	internal ExpressionNode _left; //Field offset: 0x20
	internal ExpressionNode _right; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "BinaryCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(StorageType), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStorage), Member = "IsSqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryNode), Member = "BinaryCompare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(StorageType), typeof(int), typeof(CompareInfo)}, ReturnType = typeof(int))]
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool DependsOn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryNode), Member = "EvalBinaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExpressionNode), typeof(ExpressionNode), typeof(DataRow), typeof(DataRowVersion), typeof(Int32[])}, ReturnType = typeof(object))]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryNode), Member = "EvalBinaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExpressionNode), typeof(ExpressionNode), typeof(DataRow), typeof(DataRowVersion), typeof(Int32[])}, ReturnType = typeof(object))]
	internal virtual object Eval(Int32[] recordNos) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, Int32[] recordNos) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CalledBy(Type = typeof(BinaryNode), Member = "ResultSqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsMixed(StorageType left, StorageType right) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsMixedSql(StorageType left, StorageType right) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZeroOpNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "InvalidIsSyntax", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	internal virtual ExpressionNode Optimize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryNode), Member = "GetPrecedence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(DataTypePrecedence))]
	[Calls(Type = typeof(Operators), Member = "IsLogical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Operators), Member = "IsRelational", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryNode), Member = "GetPrecedence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(DataTypePrecedence))]
	[Calls(Type = typeof(Operators), Member = "IsLogical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryNode), Member = "GetPrecedenceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTypePrecedence)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(Operators), Member = "IsArithmetical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataStorage), Member = "GetTypeStorage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExprException), Member = "AmbiguousBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExprException), Member = "TypeMismatchInBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int SqlResultType(int typeCode) { }

}

