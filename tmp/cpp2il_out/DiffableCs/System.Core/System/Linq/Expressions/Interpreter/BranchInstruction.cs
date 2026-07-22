namespace System.Linq.Expressions.Interpreter;

internal class BranchInstruction : OffsetInstruction
{
	private static Instruction[][][] s_caches; //Field offset: 0x0
	internal readonly bool _hasResult; //Field offset: 0x18
	internal readonly bool _hasValue; //Field offset: 0x19

	public virtual Instruction[] Cache
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 15)]
		 get { } //Length: 676
	}

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

	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal BranchInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BranchInstruction(bool hasResult, bool hasValue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public virtual Instruction[] get_Cache() { }

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

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public virtual int Run(InterpretedFrame frame) { }

}

