namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
public class BinaryExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; //Field offset: 0x18

	public virtual bool CanReduce
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 34
	}

	public LambdaExpression Conversion
	{
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public bool IsLifted
	{
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 420
	}

	internal bool IsLiftedLogical
	{
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 371
	}

	public bool IsLiftedToNull
	{
		[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 499
	}

	internal bool IsReferenceComparison
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 208
	}

	public Expression Left
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public MethodInfo Method
	{
		[CallerCount(Count = 44)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public Expression Right
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal BinaryExpression(Expression left, Expression right) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_CanReduce() { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public LambdaExpression get_Conversion() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_IsLifted() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsLiftedLogical() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_IsLiftedToNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_IsReferenceComparison() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Left() { }

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MethodInfo get_Method() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Right() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override LambdaExpression GetConversion() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override MethodInfo GetMethod() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsOpAssignment(ExpressionType op) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Expression Reduce() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexExpression), Member = "GetArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexExpression), Member = "get_ArgumentCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	private Expression ReduceIndex() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Variable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	private Expression ReduceMember() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(MethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(Type[]), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 29)]
	internal Expression ReduceUserdefinedLifted() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BinaryExpression), Member = "GetBinaryOpFromAssignmentOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType)}, ReturnType = typeof(ExpressionType))]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 3)]
	private Expression ReduceVariable() { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceEquality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExpression), Member = "get_IsLiftedToNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ReferenceEqualityNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 15)]
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

}

