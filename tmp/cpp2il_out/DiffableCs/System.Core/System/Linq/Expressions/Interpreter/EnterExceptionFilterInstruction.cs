namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterExceptionFilterInstruction : Instruction
{
	internal static readonly EnterExceptionFilterInstruction Instance; //Field offset: 0x0

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static EnterExceptionFilterInstruction() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private EnterExceptionFilterInstruction() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[ExcludeFromCodeCoverage]
	public virtual int Run(InterpretedFrame frame) { }

}

