namespace System.Linq.Expressions;

internal class TypedConstantExpression : ConstantExpression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	public virtual Type Type
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal TypedConstantExpression(object value, Type type) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

}

