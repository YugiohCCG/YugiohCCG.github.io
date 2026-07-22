namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
public sealed class SwitchExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; //Field offset: 0x28

	public ReadOnlyCollection<SwitchCase> Cases
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public MethodInfo Comparison
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Expression DefaultBody
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Expression SwitchValue
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public MethodInfo get_Comparison() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_DefaultBody() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_SwitchValue() { }

}

