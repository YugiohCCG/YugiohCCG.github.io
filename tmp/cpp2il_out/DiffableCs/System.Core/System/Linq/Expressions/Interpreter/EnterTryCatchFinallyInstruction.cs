namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
{
	private readonly bool _hasFinally; //Field offset: 0x18
	private TryCatchFinallyHandler _tryHandler; //Field offset: 0x20

	internal TryCatchFinallyHandler Handler
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public virtual string InstructionName
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 74
	}

	public virtual int ProducedContinuations
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryCatch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal TryCatchFinallyHandler get_Handler() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual int get_ProducedContinuations() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "PushContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Goto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 31)]
	public virtual int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

