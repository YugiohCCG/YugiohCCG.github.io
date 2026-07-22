namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
{
	private TryFaultHandler _tryHandler; //Field offset: 0x18

	internal TryFaultHandler Handler
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual string InstructionName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public virtual int ProducedContinuations
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal EnterTryFaultInstruction(int targetIndex) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal TryFaultHandler get_Handler() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedContinuations() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public virtual int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

}

