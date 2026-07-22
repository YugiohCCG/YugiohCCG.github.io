namespace System.Dynamic;

public abstract class DynamicMetaObjectBinder : CallSiteBinder
{

	internal override bool IsStandardBinder
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public override Type ReturnType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		 get { } //Length: 50
	}

	[CalledBy(Type = typeof(GetMemberBinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SetMemberBinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected DynamicMetaObjectBinder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "OutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "BindingCannotBeNull", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "DynamicBindingNeedsRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "DynamicObjectResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Error), Member = "DynamicBinderResultNotAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "BinderNotCompatibleWithCallSite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Expression), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "IfThen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 38)]
	public virtual Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicMetaObject), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static DynamicMetaObject[] CreateArgumentMetaObjects(Object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_IsStandardBinder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public override Type get_ReturnType() { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+MetaExpando", Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Expression), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Type)}, ReturnType = typeof(GotoExpression))]
	public Expression GetUpdateExpression(Type type) { }

}

