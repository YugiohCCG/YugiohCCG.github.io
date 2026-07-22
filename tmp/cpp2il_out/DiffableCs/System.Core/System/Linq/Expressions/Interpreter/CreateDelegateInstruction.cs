namespace System.Linq.Expressions.Interpreter;

internal sealed class CreateDelegateInstruction : Instruction
{
	private readonly LightDelegateCreator _creator; //Field offset: 0x10

	public virtual int ConsumedStack
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interpreter), Member = "get_ClosureSize", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 38
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

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CreateDelegateInstruction(LightDelegateCreator delegateCreator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interpreter), Member = "get_ClosureSize", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public virtual int Run(InterpretedFrame frame) { }

}

