namespace System.Data;

internal abstract class ExpressionNode
{
	private DataTable _table; //Field offset: 0x10

	internal IFormatProvider FormatProvider
	{
		[CalledBy(Type = typeof(FunctionNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		internal get { } //Length: 93
	}

	internal override bool IsSqlColumn
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	protected DataTable table
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ExpressionNode(DataTable table) { }

	internal abstract void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void BindTable(DataTable table) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool DependsOn(DataColumn column) { }

	internal abstract object Eval() { }

	internal abstract object Eval(DataRow row, DataRowVersion version) { }

	internal abstract object Eval(Int32[] recordNos) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	internal IFormatProvider get_FormatProvider() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_IsSqlColumn() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected DataTable get_table() { }

	internal abstract bool HasLocalAggregate() { }

	internal abstract bool HasRemoteAggregate() { }

	internal abstract bool IsConstant() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsFloat(StorageType type) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsFloatSql(StorageType type) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsInteger(StorageType type) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsIntegerSql(StorageType type) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsNumeric(StorageType type) { }

	[CalledBy(Type = typeof(UnaryNode), Member = "EvalUnaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsNumericSql(StorageType type) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSigned(StorageType type) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSignedSql(StorageType type) { }

	internal abstract bool IsTableConstant() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsUnsigned(StorageType type) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool IsUnsignedSql(StorageType type) { }

	internal abstract ExpressionNode Optimize() { }

}

