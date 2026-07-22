namespace System.Data;

internal sealed class FunctionNode : ExpressionNode
{
	private static readonly Function[] s_funcs; //Field offset: 0x0
	internal readonly string _name; //Field offset: 0x18
	internal readonly int _info; //Field offset: 0x20
	internal int _argumentCount; //Field offset: 0x24
	internal ExpressionNode[] _arguments; //Field offset: 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; //Field offset: 0x30

	internal FunctionId Aggregate
	{
		[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FunctionNode), Member = "get_IsAggregate", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 147
	}

	internal bool IsAggregate
	{
		[CalledBy(Type = typeof(FunctionNode), Member = "get_Aggregate", ReturnType = typeof(FunctionId))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 583
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Function), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FunctionId), typeof(Type), typeof(bool), typeof(bool), typeof(int), typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	private static FunctionNode() { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeLimiter), Member = "Capture", ReturnType = typeof(TypeLimiter))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExprException), Member = "UndefinedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal FunctionNode(DataTable table, string name) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 9)]
	internal void AddArgument(ExpressionNode argument) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FunctionNode), Member = "Check", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataColumn>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "InWithoutList", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "UndefinedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 12)]
	internal void Check() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual bool DependsOn(DataColumn column) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionNode), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FunctionNode), Member = "GetDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionNode)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(FunctionNode), Member = "EvalFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FunctionId), typeof(Object[]), typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExprException), Member = "ArgumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 51)]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExprException), Member = "ComputeNotAggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual object Eval(Int32[] recordNos) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "UndefinedFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "FunctionArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "DatatypeConvertion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "ArgumentTypeInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "NYI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "MismatchKindandTimeSpan", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "InvalidTimeZoneRange", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ExprException), Member = "InvalidMinutesArgument", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SqlString), Member = "get_Value", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataExpression), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DataStorage), Member = "GetStorageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(StorageType))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExpressionNode), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(SqlConvert), Member = "ConvertStringToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsFloatSql", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionNode), Member = "IsIntegerSql", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ExprException), Member = "InvalidHoursArgument", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 147)]
	[ContainsUnimplementedInstructions]
	private object EvalFunction(FunctionId id, Object[] argumentValues, DataRow row, DataRowVersion version) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FunctionNode), Member = "get_IsAggregate", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal FunctionId get_Aggregate() { }

	[CalledBy(Type = typeof(FunctionNode), Member = "get_Aggregate", ReturnType = typeof(FunctionId))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool get_IsAggregate() { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeLimiter), Member = "EnsureTypeIsAllowed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(TypeLimiter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "InvalidType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExprException), Member = "ArgumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Type)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private Type GetDataType(ExpressionNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExprException), Member = "NonConstantArgument", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal virtual ExpressionNode Optimize() { }

}

