namespace System.Linq.Expressions;

internal static class Error
{

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessorArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception AmbiguousJump(object p0) { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ArrayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustBeArray(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ArrayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static Exception ArgumentMustBeInteger(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	[CalledBy(Type = typeof(Expression), Member = "ArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	[CalledBy(Type = typeof(Block2), Member = "GetExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Block3), Member = "GetExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Block4), Member = "GetExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Block5), Member = "GetExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Scope1), Member = "GetExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BlockExpressionList), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression0`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression1`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression2`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression3`1), Member = "GetParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(ListProvider`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentOutOfRange(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateCoalesceArgTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateTryAndCatchHaveSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ArgumentTypesMustMatch() { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetEqualityComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrElse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PowerAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BindingCannotBeNull() { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateTryAndCatchHaveSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "NewArrayBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateCoalesceArgTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CoalesceUsedOnNonNullType() { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedCoercionOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	[CalledBy(Type = "System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1+Enumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1+Enumerator", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "CheckVersion", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection+<GetEnumerator>d__15", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "CheckVersion", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+<GetExpandoEnumerator>d__51", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CollectionModifiedWhileEnumerating() { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception CollectionReadOnly() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ControlCannotEnterExpression() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ControlCannotEnterTry() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ControlCannotLeaveFilterTest() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ControlCannotLeaveFinally() { }

	[CalledBy(Type = typeof(Expression), Member = "AddAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "DivideAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ModuloAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ExclusiveOrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static Exception DuplicateVariable(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Strings), Member = "DynamicObjectResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	[CalledBy(Type = "System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1+Enumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception EnumerationIsDone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	[CalledBy(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression&), typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateGotoType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessorArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "get_NodeType", ReturnType = typeof(ExpressionType))]
	[CalledBy(Type = typeof(Expression), Member = "get_Type", ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception FirstArgumentMustBeCallSite() { }

	[CalledBy(Type = typeof(Expression), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Expression[]), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	[CalledBy(Type = typeof(Error), Member = "AccessorsCannotHaveByRefArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "VariableMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "DuplicateVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ArgumentMustBeInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "TypeContainsGenericParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "TypeIsGeneric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchMethodParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchConstructorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Error), Member = "ExpressionMustBeReadable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	private static string GetParamName(string paramName, int index) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	[CalledBy(Type = typeof(Expression), Member = "ArrayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectNumberOfIndexes() { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "VerifyOpTrueFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateOpAssignConversionLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression), typeof(Expression), typeof(MethodInfo), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessorArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "TypeAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateCallInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	[CalledBy(Type = typeof(GetMemberBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(SetIndexBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(SetMemberBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(UnaryOperationBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(ContractUtils), Member = "Requires", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidArgumentValue(string paramName) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAssignBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	[CalledBy(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidMetaObjectCreated(object p0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidProgramException), Member = ".ctor", ReturnType = typeof(void))]
	internal static Exception InvalidProgram() { }

	[CalledBy(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Unbox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception InvalidUnboxType(string paramName) { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression&), typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateFinish", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "MakeInterpreter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Interpreter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LabelTargetUndefined(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(LoopExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LabelTypeMustBeVoid(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Expression[]), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Expression[]), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "VisitChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "ReduceAndCheck", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MustBeReducible() { }

	[CalledBy(Type = typeof(Expression), Member = "VisitChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "ReduceAndCheck", ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MustReduceToDifferent() { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "ValidateChildType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitAndConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.ObjectModel.ReadOnlyCollection`1<T>", typeof(string)}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "ValidateUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression), typeof(UnaryExpression)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "ValidateBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(BinaryExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception NonAbstractConstructorRequired() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception NonLocalJumpWithValue(object p0) { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception NoOrInvalidRuleProduced() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	internal static Exception NotSupported() { }

	[CalledBy(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateStaticOrInstanceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "VerifyOpTrueFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateOpAssignConversionLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression), typeof(Expression), typeof(MethodInfo), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OutOfRange(string paramName, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateOpAssignConversionLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression), typeof(Expression), typeof(MethodInfo), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Quote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "VisitChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionVisitor)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "ReduceAndCheck", ReturnType = typeof(Expression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ReducedNotCompatible() { }

	[CalledBy(Type = typeof(Expression), Member = "Reduce", ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ReducibleMustOverrideReduce() { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ReferenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ReferenceNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CheckRethrow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileThrowUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception RethrowRequiresCatch() { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception SameKeyExistsInExpando(object key) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception SetterHasNoParams(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception SetterMustBeVoid(string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeMustBeDerivedFromSystemDelegate() { }

	[CalledBy(Type = typeof(Expression), Member = "TypeIs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(TypeBinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "TypeEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(TypeBinaryExpression))]
	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	[CalledBy(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeMustNotBePointer(string paramName) { }

	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception TypeParameterIsNotDelegate(object p0) { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

}

