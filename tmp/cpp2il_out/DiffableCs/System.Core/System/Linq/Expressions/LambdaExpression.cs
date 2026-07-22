namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider
{
	private readonly Expression _body; //Field offset: 0x10

	public Expression Body
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Name
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	internal override string NameCore
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[ExcludeFromCodeCoverage]
	internal override int ParameterCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 39
	}

	internal abstract Type PublicType
	{
		internal get { } //Length: 0
	}

	public Type ReturnType
	{
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 125
	}

	[ExcludeFromCodeCoverage]
	private override int System.Linq.Expressions.IParameterProvider.ParameterCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 17
	}

	public bool TailCall
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	internal override bool TailCallCore
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual Type Type
	{
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	internal abstract Type TypeCore
	{
		internal get { } //Length: 0
	}

	[CalledBy(Type = typeof(Expression`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LambdaExpression(Expression body) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Expression get_Body() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal override string get_NameCore() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal override int get_ParameterCount() { }

	internal abstract Type get_PublicType() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Type get_ReturnType() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public bool get_TailCall() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_TailCallCore() { }

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	internal abstract Type get_TypeCore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override ParameterExpression GetParameter(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	private override ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

}

