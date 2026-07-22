namespace System.Linq.Expressions;

internal sealed class Expression3 : Expression<TDelegate>
{
	private object _par0; //Field offset: 0x0
	private readonly ParameterExpression _par1; //Field offset: 0x0
	private readonly ParameterExpression _par2; //Field offset: 0x0

	internal virtual int ParameterCount
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public Expression3`1(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal virtual int get_ParameterCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal virtual ParameterExpression GetParameter(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionUtils), Member = "ReturnObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

