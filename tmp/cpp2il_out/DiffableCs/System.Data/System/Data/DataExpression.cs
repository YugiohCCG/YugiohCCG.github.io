namespace System.Data;

internal sealed class DataExpression : IFilter
{
	internal string _originalExpression; //Field offset: 0x10
	private bool _parsed; //Field offset: 0x18
	private bool _bound; //Field offset: 0x19
	private ExpressionNode _expr; //Field offset: 0x20
	private DataTable _table; //Field offset: 0x28
	private readonly StorageType _storageType; //Field offset: 0x30
	private readonly Type _dataType; //Field offset: 0x38
	private DataColumn[] _dependency; //Field offset: 0x40

	internal string Expression
	{
		[CalledBy(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DataColumn), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DataTable), Member = "get_DisplayExpressionInternal", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DataTable), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DataExpression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		internal get { } //Length: 67
	}

	internal bool HasValue
	{
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	internal DataExpression(DataTable table, string expression) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataView), Member = "SetDataViewManager", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ExprException), Member = "UnsupportedDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	internal DataExpression(DataTable table, string expression, Type type) { }

	[CalledBy(Type = typeof(DataColumn), Member = "SetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void Bind(DataTable table) { }

	[CalledBy(Type = typeof(DataColumn), Member = "set_Expression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataColumnCollection), Member = "CanRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool DependsOn(DataColumn column) { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	internal object Evaluate() { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataExpression), Member = "Evaluate", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(NameNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DataExpression), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataTable), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "DatavalueConvertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataColumn), Member = "get_Expression", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataColumn), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "get_DisplayExpressionInternal", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataTable), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DataExpression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	internal string get_Expression() { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasValue() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal DataColumn[] GetDependency() { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool HasLocalAggregate() { }

	[CalledBy(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool HasRemoteAggregate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataExpression), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataExpression), Member = "get_Expression", ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "FilterConvertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "InvokeArgument", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override bool Invoke(DataRow row, DataRowVersion version) { }

	[CalledBy(Type = typeof(DataTable), Member = "EvaluateExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataColumn)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DataTable), Member = "EvaluateDependentExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Data.DataColumn>), typeof(DataRow), typeof(DataRowVersion), typeof(System.Collections.Generic.List`1<System.Data.DataRow>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool IsTableAggregate() { }

	[CalledBy(Type = typeof(UnaryNode), Member = "EvalUnaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	internal static bool IsUnknown(object value) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DataExpression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnaryNode), Member = "EvalUnaryOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionForCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExprException), Member = "DatavalueConvertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(Exception)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	internal static bool ToBoolean(object value) { }

}

