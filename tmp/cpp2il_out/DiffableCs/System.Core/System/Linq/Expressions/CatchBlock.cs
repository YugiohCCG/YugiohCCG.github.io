namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(CatchBlockProxy))]
public sealed class CatchBlock
{
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; //Field offset: 0x28

	public Expression Body
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Expression Filter
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type Test
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ParameterExpression Variable
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Body() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Filter() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_Test() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ParameterExpression get_Variable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }

}

