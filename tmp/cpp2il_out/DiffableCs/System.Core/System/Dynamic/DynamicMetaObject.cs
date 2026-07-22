namespace System.Dynamic;

public class DynamicMetaObject
{
	public static readonly DynamicMetaObject[] EmptyMetaObjects; //Field offset: 0x0
	private static readonly object s_noValueSentinel; //Field offset: 0x8
	private readonly object _value; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; //Field offset: 0x20

	public Expression Expression
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool HasValue
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
		[CalledBy(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 92
	}

	public Type LimitType
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 216
	}

	public BindingRestrictions Restrictions
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type RuntimeType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 203
	}

	public object Value
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetDynamicMemberNames", ReturnType = "System.Collections.Generic.IEnumerable`1<String>")]
		[CalledBy(Type = typeof(BindingRestrictions), Member = "GetTypeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(BindingRestrictions))]
		[CalledBy(Type = typeof(DynamicMetaObject), Member = "get_RuntimeType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(DynamicMetaObject), Member = "get_LimitType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__6", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetClassEnsureIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject), typeof(ExpandoClass&), typeof(Int32&)}, ReturnType = typeof(ExpandoClass))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "get_Value", ReturnType = typeof(ExpandoObject))]
		[CallerCount(Count = 22)]
		 get { } //Length: 117
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static DynamicMetaObject() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BuildCallMethodWithResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", typeof(DynamicMetaObject), "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodReturnLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Collections.Generic.IEnumerable`1<Expression>", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "CallMethodNoResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynamicMetaObjectBinder), "System.Linq.Expressions.Expression[]", "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1<T>+Fallback<T>"}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.NoThrowGetBinderMember", Member = "FallbackGetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.NoThrowSetBinderMember", Member = "FallbackSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "T", "Newtonsoft.Json.Utilities.DynamicProxy`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ExpandoObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindBinaryOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryOperationBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateInstanceBinder), "System.Dynamic.DynamicMetaObject[]"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindDeleteIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteIndexBinder), "System.Dynamic.DynamicMetaObject[]"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindGetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetIndexBinder), "System.Dynamic.DynamicMetaObject[]"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindGetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokeBinder), "System.Dynamic.DynamicMetaObject[]"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokeMemberBinder), "System.Dynamic.DynamicMetaObject[]"}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindSetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetIndexBinder), "System.Dynamic.DynamicMetaObject[]", typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SetIndexBinder), Member = "FallbackSetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[]), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "BindUnaryOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryOperationBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "CreateArgumentMetaObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(DynamicMetaObject[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_HasValue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "InvalidMetaObjectCreated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static DynamicMetaObject Create(object value, Expression expression) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Expression() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CalledBy(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_HasValue() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Type get_LimitType() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public BindingRestrictions get_Restrictions() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Type get_RuntimeType() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetRestrictions", ReturnType = typeof(BindingRestrictions))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1", Member = "GetDynamicMemberNames", ReturnType = "System.Collections.Generic.IEnumerable`1<String>")]
	[CalledBy(Type = typeof(BindingRestrictions), Member = "GetTypeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(BindingRestrictions))]
	[CalledBy(Type = typeof(DynamicMetaObject), Member = "get_RuntimeType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DynamicMetaObject), Member = "get_LimitType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DynamicMetaObjectBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(LabelTarget)}, ReturnType = typeof(Expression))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__6", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "GetClassEnsureIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject), typeof(ExpandoClass&), typeof(Int32&)}, ReturnType = typeof(ExpandoClass))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "get_Value", ReturnType = typeof(ExpandoObject))]
	[CallerCount(Count = 22)]
	public object get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override IEnumerable<String> GetDynamicMemberNames() { }

}

