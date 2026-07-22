namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchCaseProxy))]
public sealed class SwitchCase
{
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <TestValues>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x18

	public Expression Body
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ReadOnlyCollection<Expression> TestValues
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Expression get_Body() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ReadOnlyCollection<Expression> get_TestValues() { }

}

