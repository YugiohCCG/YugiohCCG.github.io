namespace System.Dynamic;

[DebuggerDisplay("{DebugView}")]
[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
public abstract class BindingRestrictions
{
	private sealed class BindingRestrictionsProxy
	{

	}

	private sealed class CustomRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal CustomRestriction(Expression expression) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal virtual Expression GetExpression() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	private sealed class InstanceRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10
		private readonly object _instance; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal InstanceRestriction(Expression parameter, object instance) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
		[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
		[Calls(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
		[CallsUnknownMethods(Count = 14)]
		internal virtual Expression GetExpression() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	private sealed class MergedRestriction : BindingRestrictions
	{
		internal readonly BindingRestrictions Left; //Field offset: 0x10
		internal readonly BindingRestrictions Right; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal MergedRestriction(BindingRestrictions left, BindingRestrictions right) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
		[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
		[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		internal virtual Expression GetExpression() { }

	}

	private sealed class TestBuilder
	{
		private struct AndNode
		{
			internal int Depth; //Field offset: 0x0
			internal Expression Node; //Field offset: 0x8

		}

		private readonly HashSet<BindingRestrictions> _unique; //Field offset: 0x10
		private readonly Stack<AndNode> _tests; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public TestBuilder() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
		[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
		[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal void Append(BindingRestrictions restrictions) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
		[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
		[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private void Push(Expression node, int depth) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
		[Calls(Type = typeof(Expression), Member = "AndAlso", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
		[CallsUnknownMethods(Count = 1)]
		internal Expression ToExpression() { }

	}

	private sealed class TypeRestriction : BindingRestrictions
	{
		private readonly Expression _expression; //Field offset: 0x10
		private readonly Type _type; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal TypeRestriction(Expression parameter, Type type) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TypeUtils), Member = "AreEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Expression), Member = "TypeEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(TypeBinaryExpression))]
		internal virtual Expression GetExpression() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

	}

	public static readonly BindingRestrictions Empty; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConstantExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static BindingRestrictions() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private BindingRestrictions() { }

	internal abstract Expression GetExpression() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Expression ToExpression() { }

}

