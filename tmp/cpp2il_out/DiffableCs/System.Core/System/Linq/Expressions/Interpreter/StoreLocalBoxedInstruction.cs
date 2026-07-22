namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
{

	public virtual int ConsumedStack
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal StoreLocalBoxedInstruction(int index) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public virtual int Run(InterpretedFrame frame) { }

}

