namespace System.Linq.Expressions;

internal sealed class FullConditionalExpressionWithType : FullConditionalExpression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	public virtual Type Type
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionalExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

}

