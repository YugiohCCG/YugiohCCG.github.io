namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

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

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal StoreLocalInstruction(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "StoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	public override Instruction BoxIfIndexMatches(int index) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	public virtual int Run(InterpretedFrame frame) { }

}

