namespace System.Linq.Expressions.Interpreter;

internal abstract class ByRefUpdater
{
	public readonly int ArgumentIndex; //Field offset: 0x10

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ByRefUpdater(int argumentIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public abstract void Update(InterpretedFrame frame, object value) { }

}

