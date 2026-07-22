namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

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

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal LoadLocalInstruction(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "LoadLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	public override Instruction BoxIfIndexMatches(int index) { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public virtual int Run(InterpretedFrame frame) { }

}

