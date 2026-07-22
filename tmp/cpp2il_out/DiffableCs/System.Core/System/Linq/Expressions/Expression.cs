namespace System.Linq.Expressions;

public abstract class Expression
{
	public class BinaryExpressionProxy
	{

	}

	public class BlockExpressionProxy
	{

	}

	public class CatchBlockProxy
	{

	}

	public class ConditionalExpressionProxy
	{

	}

	public class ConstantExpressionProxy
	{

	}

	public class DebugInfoExpressionProxy
	{

	}

	public class DefaultExpressionProxy
	{

	}

	private class ExtensionInfo
	{
		internal readonly ExpressionType NodeType; //Field offset: 0x10
		internal readonly Type Type; //Field offset: 0x18

	}

	public class GotoExpressionProxy
	{

	}

	public class IndexExpressionProxy
	{

	}

	public class InvocationExpressionProxy
	{

	}

	public class LabelExpressionProxy
	{

	}

	public class LambdaExpressionProxy
	{

	}

	public class ListInitExpressionProxy
	{

	}

	public class LoopExpressionProxy
	{

	}

	public class MemberExpressionProxy
	{

	}

	public class MemberInitExpressionProxy
	{

	}

	public class MethodCallExpressionProxy
	{

	}

	public class NewArrayExpressionProxy
	{

	}

	public class NewExpressionProxy
	{

	}

	public class ParameterExpressionProxy
	{

	}

	public class RuntimeVariablesExpressionProxy
	{

	}

	public class SwitchCaseProxy
	{

	}

	public class SwitchExpressionProxy
	{

	}

	public class TryExpressionProxy
	{

	}

	public class TypeBinaryExpressionProxy
	{

	}

	public class UnaryExpressionProxy
	{

	}

	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; //Field offset: 0x0
	private static CacheDict<Type, Func`5<Expression, String, Boolean, ReadOnlyCollection`1<ParameterExpression>, LambdaExpression>> s_lambdaFactories; //Field offset: 0x8
	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable; //Field offset: 0x10

	public override bool CanReduce
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Error), Member = "ExtensionNodeMustOverrideProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 234
	}

	public override Type Type
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Error), Member = "ExtensionNodeMustOverrideProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 235
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheDict`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Expression() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Expression() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private override Expression Accept(ExpressionVisitor visitor) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 10)]
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = "SQLite.TableQuery`1", Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<T, Boolean>>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "SQLite.TableQuery`1", Member = "AddWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingRestrictions)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "ToExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TestBuilder", Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+MergedRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeArrayIndexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfIndexes", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfIndexes", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeArrayIndexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeSingleDimensionalArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public static UnaryExpression ArrayLength(Expression array) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 47)]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public static BinaryExpression Assign(Expression left, Expression right) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Block5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Block3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Block4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Expression), Member = "GetOptimizedBlockExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallsUnknownMethods(Count = 2)]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Expression), Member = "GetOptimizedBlockExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "VariableMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "DuplicateVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Scope1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScopeWithType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public static GotoExpression Break(LabelTarget target) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(MethodCallExpression5), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(InstanceMethodCallExpression3), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceMethodCallExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Expression[]), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(Type[]), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(InstanceMethodCallExpressionN), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Error), Member = "OnlyStaticMethodsHaveNullInstance", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(InstanceMethodCallExpression0), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceMethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateCallInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 23)]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(MethodCallExpression4), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[CalledBy(Type = typeof(InstanceMethodCallExpression2), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceMethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	[CalledBy(Type = typeof(MethodCallExpressionN), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	[CalledBy(Type = typeof(MethodCallExpression1), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	[CalledBy(Type = typeof(MethodCallExpression0), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static MethodCallExpression Call(MethodInfo method) { }

	[CalledBy(Type = typeof(MethodCallExpression2), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	[CalledBy(Type = typeof(MethodCallExpression3), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(MethodCallExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	[CalledBy(Type = typeof(InstanceMethodCallExpression0), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileInvocationExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceMethodCallExpression0), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	[CalledBy(Type = typeof(InstanceMethodCallExpression1), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOperatorMustNotBeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "CoalesceUsedOnNonNullType", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(TypeUtils), Member = "IsImplicitlyConvertibleTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 25)]
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.NoThrowExpressionVisitor", Member = "VisitConditional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConditionalExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConditionalExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(Expression), Member = "IfThen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(ConditionalExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitConditional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConditionalExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ConditionalExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicUtils", Member = "GetDynamicMemberNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDynamicMetaObjectProvider)}, ReturnType = "System.Collections.Generic.IEnumerable`1<String>")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.NoThrowExpressionVisitor", Member = "VisitConditional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConditionalExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = typeof(Utils), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ConstantExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public static ConstantExpression Constant(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder)}, ReturnType = typeof(ConstantExpression))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypedConstantExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstantExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static ConstantExpression Constant(object value, Type type) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c", Member = "<GetArgs>b__18_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Dynamic.DynamicMetaObject[]", typeof(DynamicMetaObject)}, ReturnType = "System.Linq.Expressions.Expression[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression Convert(Expression expression, Type type) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "HasIdentityPrimitiveOrNullableConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedCoercionOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "HasIdentityPrimitiveOrNullableConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedCoercionOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(ParameterExpression[])}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CacheDict`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CacheDict`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CacheDict`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public static DefaultExpression Default(Type type) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(Utils), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DefaultExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	public static DefaultExpression Empty() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	public static BinaryExpression Equal(Expression left, Expression right) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetEqualityComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemberExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(FieldExpression))]
	[Calls(Type = typeof(Error), Member = "FieldInfoNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OnlyStaticFieldsHaveNullInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "InstanceFieldNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	public static MemberExpression Field(Expression expression, string fieldName) { }

	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(Type[]), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "IsCompatible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Expression[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "MethodWithMoreThanOneMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "GenericMethodWithArgsDoesNotExistOnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodWithArgsDoesNotExistOnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_CanReduce() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "ExtensionNodeMustOverrideProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public override ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalWeakTable`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "ExtensionNodeMustOverrideProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public override Type get_Type() { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	[CalledBy(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "IsBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "HasBuiltInEqualityOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "IsNullComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 9)]
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "FindGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeNotInvocable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PowerAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ExclusiveOrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ModuloAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "DivideAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ValidateOpAssignConversionLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression), typeof(Expression), typeof(MethodInfo), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOpMustHaveValidReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 12)]
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	[CalledBy(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ConvertChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "UnaryPlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NegateChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Not", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OnesComplement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	[CalledBy(Type = typeof(Expression), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	[CalledBy(Type = typeof(Expression), Member = "AddAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ExclusiveOrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ModuloAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "DivideAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ValidateOpAssignConversionLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression), typeof(Expression), typeof(MethodInfo), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOpMustHaveValidReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrElse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetEqualityComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 3)]
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ExclusiveOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "And", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Modulo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "GetUserDefinedCoercionMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	[CalledBy(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ConvertChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "GetUserDefinedCoercionMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "CoercionOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Not", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	[CalledBy(Type = typeof(Expression), Member = "Negate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OnesComplement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Not", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NegateChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "UnaryPlus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "UnaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "GetUpdateExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DefaultExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(InvocationExpression5), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[CalledBy(Type = typeof(InvocationExpressionN), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvocationExpressionN), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(InvocationExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvocationExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression0), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	[CalledBy(Type = typeof(InvocationExpression2), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	[CalledBy(Type = typeof(InvocationExpression0), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvocationExpression0), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static InvocationExpression Invoke(Expression expression) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(InvocationExpression1), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	[CalledBy(Type = typeof(InvocationExpression3), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	[CalledBy(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[CalledBy(Type = typeof(InvocationExpression4), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(InvocationExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[Calls(Type = typeof(InvocationExpression4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[CalledBy(Type = typeof(Expression), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[]), typeof(Expression[]), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "IsSameOrSubclass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	[CalledBy(Type = typeof(Expression), Member = "GetEqualityComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsNullComparison(Expression left, Expression right) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsNullConstant(Expression e) { }

	[CalledBy(Type = typeof(Expression), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TypeUtils), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsSimpleShift(Type left, Type right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(LabelTarget))]
	public static LabelTarget Label(string name) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(LabelTarget))]
	public static LabelTarget Label(Type type) { }

	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LabelTarget))]
	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(LabelTarget))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static LabelTarget Label(Type type, string name) { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "ValidateGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression&), typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LabelExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(void))]
	public static LabelExpression Label(LabelTarget target) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[ContainsInvalidInstructions]
	public static LabelTarget Label() { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LabelExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Expression), Member = "ValidateGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression&), typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LabelExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(void))]
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static Expression<TDelegate> Lambda(Expression body, IEnumerable<ParameterExpression> parameters) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Expression<TDelegate> Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Expression<TDelegate> Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static Expression<TDelegate> Lambda(Expression body, ParameterExpression[] parameters) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "IsSimpleShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetResultTypeOfShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "IsSimpleShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetResultTypeOfShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LoopExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(LoopExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LoopExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(LoopExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "LabelTypeMustBeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LambdaExpression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "AddAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "AndAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "DivideAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ExclusiveOrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ModuloAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "MultiplyAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "OrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_Math_Pow_Double_Double", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "SubtractChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "SubtractAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "AddAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "MultiplyAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "SubtractAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "UnhandledBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "OrElse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "AddChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "And", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ArrayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ExclusiveOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "LeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Modulo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "MultiplyChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "RightShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CalledBy(Type = "SQLite.TableQuery`1", Member = "CompileExpr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Collections.Generic.List`1<Object>"}, ReturnType = "SQLite.TableQuery`1<T>+CompileResult<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right) { }

	[CalledBy(Type = typeof(CatchBlock), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CatchBlock)}, ReturnType = typeof(CatchBlock))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.QuoteInstruction+ExpressionQuoter", Member = "VisitCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CatchBlock)}, ReturnType = typeof(CatchBlock))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "Requires", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CatchBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "VariableMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	[CalledBy(Type = typeof(Expression), Member = "Break", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(GotoExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Expression), Member = "ValidateGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression&), typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GotoExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(void))]
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(IndexExpression), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(MemberExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(MemberExpression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Error), Member = "MemberNotFieldOrProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	[CalledBy(Type = typeof(Expression), Member = "PreIncrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PreIncrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PreDecrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PostIncrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PostDecrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOpMustHaveValidReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "TryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(TryExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(TryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>), typeof(Expression), typeof(Expression)}, ReturnType = typeof(TryExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNullItems", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateTryAndCatchHaveSameType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "FaultCannotHaveCatchOrFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "TryMustHaveCatchFinallyOrFault", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Unbox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsUnsignedInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsUnsignedInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitNewArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NewArrayExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(NewArrayExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NewArrayExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(Error), Member = "ArgumentCannotBeOfTypeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustBeInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "BoundsCannotBeLessThanOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Dynamic.DynamicMetaObject[]"}, ReturnType = "System.Linq.Expressions.Expression[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Dynamic.DynamicMetaObject[]", typeof(DynamicMetaObject)}, ReturnType = "System.Linq.Expressions.Expression[]")]
	[CalledBy(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression[])}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitNewArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NewArrayExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(NewArrayExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeCannotInitializeArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentCannotBeOfTypeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(NewArrayExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static UnaryExpression Not(Expression expression) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetEqualityComparisonOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsIntegerOrBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 10)]
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+InstanceRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSite`1+<>c", Member = "<CreateCustomUpdateDelegate>b__20_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSite`1+<>c", Member = "<CreateCustomNoMatchDelegate>b__21_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(UnaryExpression), Member = "ReduceVariable", ReturnType = typeof(Expression))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ParameterExpression Parameter(Type type, string name) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static ParameterExpression Parameter(Type type) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "VerifyOpTrueFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Coalesce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_Math_Pow_Double_Double", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ValidateParamswithOperandsOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(ExpressionType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 9)]
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_Math_Pow_Double_Double", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "BinaryOperatorNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(void))]
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Error), Member = "PropertyDoesNotHaveAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OnlyStaticPropertiesHaveNullInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "PropertyNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(MemberExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(PropertyExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsValidInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Error), Member = "InstancePropertyNotDefinedForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static MemberExpression Property(Expression expression, string propertyName) { }

	[CalledBy(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "QuotedExpressionMustBeLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static UnaryExpression Quote(Expression expression) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "ReducibleMustOverrideReduce", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override Expression Reduce() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "MustBeReducible", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ReducedNotCompatible", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MustReduceToDifferent", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public Expression ReduceAndCheck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceEquality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ReferenceEqualityNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "HasReferenceEquality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ReferenceEqualityNotDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeOpAssignUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PowerAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ExclusiveOrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AndAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "LeftShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "RightShiftAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ModuloAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "DivideAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "SubtractAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssignChecked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "AddAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MultiplyAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ExpressionMustBeWriteable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public static GotoExpression Return(LabelTarget target) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "IsSimpleShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetResultTypeOfShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "IsSimpleShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "GetResultTypeOfShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Error), Member = "ConversionIsNotSupportedForArithmeticTypes", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ArgumentMustNotHaveValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static UnaryExpression Throw(Expression value, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionStringBuilder), Member = "ExpressionToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "IncorrectTypeForTypeAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitTypeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeBinaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(TypeBinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(TypeBinaryExpression))]
	[CalledBy(Type = "System.Dynamic.BindingRestrictions+TypeRestriction", Member = "GetExpression", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeBinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "TypeMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	[CalledBy(Type = typeof(ExpressionVisitor), Member = "VisitTypeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeBinaryExpression)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(TypeBinaryExpression), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(TypeBinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeBinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type), typeof(ExpressionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "TypeMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(TypeUtils), Member = "IsArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeUnary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "InvalidUnboxType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Variable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "ArgumentCannotBeOfTypeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Validate(Type type, bool allowByRef) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateIndexedProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(ReadOnlyCollection`1<Expression>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateCallInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateAccessorArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "OnlyStaticPropertiesHaveNullInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "AccessorsCannotHaveVarArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodIsGeneric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodContainsGenericParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchMethodParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "AccessorsCannotHaveByRefArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(int), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateArgumentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression>& arguments, string methodParamName) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateMethodAndGetParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(ParameterInfo[]))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateStaticOrInstanceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TypeUtils), Member = "IsValidInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "InstanceAndMethodTypeMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsImplicitlyConvertibleTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "CoalesceUsedOnNonNullType", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 5)]
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoExpressionKind), typeof(LabelTarget), typeof(Expression), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "LabelMustBeVoidOrHaveExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceIndex", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CalledBy(Type = typeof(Expression), Member = "MakeIndexProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo), typeof(string), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "PropertyTypeCannotBeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "SetterHasNoParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "PropertyCannotHaveRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "SetterMustBeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "PropertyTypeMustMatchSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "BothAccessorsMustBeStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IndexesOfSetGetMustMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "PropertyTypeMustMatchGetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "RemoveLast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Expression), Member = "ValidateAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(ParameterInfo[]), typeof(ReadOnlyCollection`1<Expression>&), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "PropertyDoesNotHaveAccessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 24)]
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression>& argList) { }

	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(ParameterExpression[])}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "LambdaTypeMustBeDerivedFromSystemDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "DuplicateVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ParameterExpressionNotValidAsDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ExpressionTypeDoesNotMatchReturn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfLambdaDeclarationParameters", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExpressionUtils), Member = "TryQuote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CacheDict`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CacheDict`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "ValidateType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 27)]
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceUserdefinedLifted", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(MethodCallExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateCallInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpressionUtils), Member = "GetParametersForValidation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Error), Member = "OnlyStaticMethodsHaveNullInstance", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodIsGeneric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodContainsGenericParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(MethodCallExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Error), Member = "MethodIsGeneric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodContainsGenericParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ValidateOneArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ExpressionType), typeof(Expression), typeof(ParameterInfo), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(Expression))]
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedAssignOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedAssignOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(LambdaExpression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "OverloadOperatorTypeDoesNotMatchConversionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedCoercionOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOperatorMustNotBeVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOperatorMustBeStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodIsGeneric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MethodContainsGenericParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private static void ValidateOperator(MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedBinaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedBinaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression), typeof(Expression), typeof(bool)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetUserDefinedUnaryOperatorOrThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(string), typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "GetMethodBasedUnaryOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(UnaryExpression))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "ValidateCallInstanceType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "OnlyStaticMethodsHaveNullInstance", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "ArgumentTypesMustMatch", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "BodyOfCatchMustHaveSameTypeAsBodyOfTry", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 36)]
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	[CalledBy(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "OrElse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "LogicalOperatorMustHaveBooleanOperators", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Expression), Member = "VerifyOpTrueFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(MethodInfo), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "UserDefinedOpMustHaveConsistentTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ValidateOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 35)]
	[ContainsInvalidInstructions]
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	[CalledBy(Type = typeof(ScopeExpression), Member = "ReuseOrValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression>))]
	[CalledBy(Type = typeof(Scope1), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(ScopeN), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(ScopeWithType), Member = "Rewrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "DuplicateVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "VariableMustNotBeByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	[CalledBy(Type = typeof(BinaryExpression), Member = "ReduceMember", ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Expression), Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterExpression), Member = "Make", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(ParameterExpression))]
	public static ParameterExpression Variable(Type type, string name) { }

	[CalledBy(Type = typeof(Expression), Member = "ValidateUserDefinedConditionalLogicOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Type), typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "ParameterIsAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "OperandTypesDoNotMatchParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "IncorrectNumberOfMethodCallArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 9)]
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "MustBeReducible", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ReducedNotCompatible", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "MustReduceToDifferent", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	protected private override Expression VisitChildren(ExpressionVisitor visitor) { }

}

