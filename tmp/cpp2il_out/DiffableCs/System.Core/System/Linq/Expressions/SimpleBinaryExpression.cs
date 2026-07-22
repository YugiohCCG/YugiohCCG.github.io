namespace System.Linq.Expressions;

internal class SimpleBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	public virtual ExpressionType NodeType
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public virtual Type Type
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual ExpressionType get_NodeType() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual Type get_Type() { }

}

