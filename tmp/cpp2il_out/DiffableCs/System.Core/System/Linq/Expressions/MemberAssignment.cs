namespace System.Linq.Expressions;

public sealed class MemberAssignment : MemberBinding
{
	private readonly Expression _expression; //Field offset: 0x20

	public Expression Expression
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Expression get_Expression() { }

}

