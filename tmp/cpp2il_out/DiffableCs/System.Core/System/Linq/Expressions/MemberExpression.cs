namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x10

	public Expression Expression
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public MemberInfo Member
	{
		[CallerCount(Count = 44)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal MemberExpression(Expression expression) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Expression() { }

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public MemberInfo get_Member() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromCodeCoverage]
	internal override MemberInfo GetMember() { }

	[CalledBy(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	[CalledBy(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(FieldInfo)}, ReturnType = typeof(MemberExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeMemberAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo)}, ReturnType = typeof(MemberExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	public MemberExpression Update(Expression expression) { }

}

