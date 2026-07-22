namespace System.Linq.Expressions.Interpreter;

internal sealed class ThrowInstruction : Instruction
{
	internal static readonly ThrowInstruction Throw; //Field offset: 0x0
	internal static readonly ThrowInstruction VoidThrow; //Field offset: 0x8
	internal static readonly ThrowInstruction Rethrow; //Field offset: 0x10
	internal static readonly ThrowInstruction VoidRethrow; //Field offset: 0x18
	private readonly bool _hasResult; //Field offset: 0x10
	private readonly bool _rethrow; //Field offset: 0x11

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
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static ThrowInstruction() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private ThrowInstruction(bool hasResult, bool isRethrow) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(RuntimeWrappedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RethrowException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeWrappedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private static Exception WrapThrownObject(object thrown) { }

}

