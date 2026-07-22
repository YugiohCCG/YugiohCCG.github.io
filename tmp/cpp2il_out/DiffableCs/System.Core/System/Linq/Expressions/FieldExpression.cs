namespace System.Linq.Expressions;

internal sealed class FieldExpression : MemberExpression
{
	private readonly FieldInfo _field; //Field offset: 0x18

	public virtual Type Type
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public FieldExpression(Expression expression, FieldInfo member) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_Type() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual MemberInfo GetMember() { }

}

