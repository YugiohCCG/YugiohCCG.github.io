namespace System.Linq.Expressions;

internal sealed class PropertyExpression : MemberExpression
{
	private readonly PropertyInfo _property; //Field offset: 0x18

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
	public PropertyExpression(Expression expression, PropertyInfo member) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_Type() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual MemberInfo GetMember() { }

}

