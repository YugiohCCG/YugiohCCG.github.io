namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
{
	private static readonly EnterFinallyInstruction[] s_cache; //Field offset: 0x0

	public virtual int ConsumedContinuations
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
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static EnterFinallyInstruction() { }

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private EnterFinallyInstruction(int labelIndex) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedContinuations() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "IsJumpHappened", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InterpretedFrame), Member = "SetStackDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushPendingContinuation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Run(InterpretedFrame frame) { }

}

