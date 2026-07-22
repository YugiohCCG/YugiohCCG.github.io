namespace System.Linq.Expressions;

internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
{
	private readonly LambdaExpression _conversion; //Field offset: 0x20

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal virtual LambdaExpression GetConversion() { }

}

