namespace System.Linq.Expressions.Interpreter;

internal class NewInstruction : Instruction
{
	protected readonly ConstructorInfo _constructor; //Field offset: 0x10
	protected readonly int _argumentCount; //Field offset: 0x18

	public virtual int ConsumedStack
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
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

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NewInstruction(ConstructorInfo constructor, int argumentCount) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CalledBy(Type = typeof(NewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefNewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected Object[] GetArgs(InterpretedFrame frame, int first) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NewInstruction), Member = "GetArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(int)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 10)]
	public virtual int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

}

