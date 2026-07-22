namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionFilterInstruction : Instruction
{
	internal static readonly LeaveExceptionFilterInstruction Instance; //Field offset: 0x0

	public virtual int ConsumedStack
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static LeaveExceptionFilterInstruction() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private LeaveExceptionFilterInstruction() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	public virtual int Run(InterpretedFrame frame) { }

}

