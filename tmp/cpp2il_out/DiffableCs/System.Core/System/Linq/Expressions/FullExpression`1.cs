namespace System.Linq.Expressions;

internal sealed class FullExpression : ExpressionN<TDelegate>
{
	[CompilerGenerated]
	private readonly string <NameCore>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <TailCallCore>k__BackingField; //Field offset: 0x0

	internal virtual string NameCore
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal virtual bool TailCallCore
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FullExpression`1(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal virtual string get_NameCore() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal virtual bool get_TailCallCore() { }

}

