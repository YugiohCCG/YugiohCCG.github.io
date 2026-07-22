namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
{
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; //Field offset: 0x0
	private readonly bool _hasValue; //Field offset: 0x18

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
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static LeaveExceptionHandlerInstruction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Run(InterpretedFrame frame) { }

}

