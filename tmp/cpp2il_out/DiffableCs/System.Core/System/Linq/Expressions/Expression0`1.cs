namespace System.Linq.Expressions;

internal sealed class Expression0 : Expression<TDelegate>
{

	internal virtual int ParameterCount
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Expression0`1(Expression body) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual int get_ParameterCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal virtual ParameterExpression GetParameter(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

