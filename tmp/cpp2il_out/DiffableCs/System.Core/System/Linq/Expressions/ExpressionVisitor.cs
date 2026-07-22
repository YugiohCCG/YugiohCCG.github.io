namespace System.Linq.Expressions;

public abstract class ExpressionVisitor
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ExpressionVisitor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "ValidateChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "MustRewriteWithoutMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "ValidateUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression), typeof(UnaryExpression)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "ValidateBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(BinaryExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "MustRewriteChildToSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private static void ValidateChildType(Type before, Type after, string methodName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "ValidateChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "MustRewriteWithoutMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public static ReadOnlyCollection<T> Visit(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Expression Visit(Expression node) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitNewArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NewArrayExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CatchBlock)}, ReturnType = typeof(CatchBlock))]
	[CalledBy(Type = typeof(ExpressionVisitorUtils), Member = "VisitParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IParameterProvider), typeof(string)}, ReturnType = typeof(ParameterExpression[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "MustRewriteToSameNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T VisitAndConvert(T node, string callerName) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "MustRewriteToSameNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public ReadOnlyCollection<T> VisitAndConvert(ReadOnlyCollection<T> nodes, string callerName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(ExpressionVisitor), Member = "ValidateChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "MustRewriteWithoutMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 5)]
	protected private override Expression VisitBinary(BinaryExpression node) { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler+QuoteVisitor", Member = "VisitBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitBlockExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(BlockExpression)}, ReturnType = typeof(Expression[]))]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<T>", typeof(string)}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitBlock(BlockExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.NoThrowExpressionVisitor", Member = "VisitConditional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConditionalExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitConditional(ConditionalExpression node) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private override Expression VisitConstant(ConstantExpression node) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private override Expression VisitDefault(DefaultExpression node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private override Expression VisitExtension(Expression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitGoto(GotoExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	[Calls(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitIndex(IndexExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitInvocation(InvocationExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitLabel(LabelExpression node) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override LabelTarget VisitLabelTarget(LabelTarget node) { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler+QuoteVisitor", Member = "VisitLambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<T>"}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "VisitParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IParameterProvider), typeof(string)}, ReturnType = typeof(ParameterExpression[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private override Expression VisitLambda(Expression<T> node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(LoopExpression))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitLoop(LoopExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitMember(MemberExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IArgumentProvider)}, ReturnType = typeof(Expression[]))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitMethodCall(MethodCallExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "Visit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "SameElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>&", "System.Collections.Generic.IReadOnlyList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	protected private override Expression VisitNewArray(NewArrayExpression node) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected private override Expression VisitParameter(ParameterExpression node) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitLambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<T>"}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionVisitorUtils), Member = "VisitParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor), typeof(IParameterProvider), typeof(string)}, ReturnType = typeof(ParameterExpression[]))]
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionVisitor), Member = "Visit", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<T>", "System.Func`2<T, T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ExpressionUtils), Member = "SameElements", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>&", "System.Collections.Generic.IReadOnlyList`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected private override Expression VisitTry(TryExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "TypeEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(TypeBinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "TypeIs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(TypeBinaryExpression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(ExpressionVisitor), Member = "ValidateChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "MustRewriteWithoutMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	protected private override Expression VisitUnary(UnaryExpression node) { }

}

