namespace System.Linq.Expressions;

internal sealed class Block4 : BlockExpression
{
	private object _arg0; //Field offset: 0x10
	private readonly Expression _arg1; //Field offset: 0x18
	private readonly Expression _arg2; //Field offset: 0x20
	private readonly Expression _arg3; //Field offset: 0x28

	internal virtual int ExpressionCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CalledBy(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual int get_ExpressionCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual Expression GetExpression(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlockExpression), Member = "ReturnReadOnlyExpressions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression), typeof(Object&)}, ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>))]
	[DeduplicatedMethod]
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

