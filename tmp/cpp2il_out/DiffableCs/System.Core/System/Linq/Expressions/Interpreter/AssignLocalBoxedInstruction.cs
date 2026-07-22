namespace System.Linq.Expressions.Interpreter;

internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction
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

	public virtual int ProducedStack
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal AssignLocalBoxedInstruction(int index) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 7)]
	public virtual int Run(InterpretedFrame frame) { }

}

