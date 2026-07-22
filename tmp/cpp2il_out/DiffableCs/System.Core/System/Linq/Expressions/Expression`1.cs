namespace System.Linq.Expressions;

public class Expression : LambdaExpression
{

	internal virtual Type PublicType
	{
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		internal get { } //Length: 57
	}

	internal virtual Type TypeCore
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		internal get { } //Length: 56
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LambdaExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal Expression`1(Expression body) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TDelegate Compile() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public TDelegate Compile(bool preferInterpretation) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	internal virtual Type get_PublicType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	internal virtual Type get_TypeCore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

