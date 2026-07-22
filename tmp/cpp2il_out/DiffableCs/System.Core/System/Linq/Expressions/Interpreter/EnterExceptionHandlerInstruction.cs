namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterExceptionHandlerInstruction : Instruction
{
	internal static readonly EnterExceptionHandlerInstruction Void; //Field offset: 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; //Field offset: 0x8
	private readonly bool _hasValue; //Field offset: 0x10

	public virtual int ConsumedStack
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static EnterExceptionHandlerInstruction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private EnterExceptionHandlerInstruction(bool hasValue) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

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

