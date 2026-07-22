namespace System.Linq.Expressions.Interpreter;

internal sealed class Interpreter
{
	internal static readonly object NoValue; //Field offset: 0x0
	private readonly InstructionArray _instructions; //Field offset: 0x10
	internal readonly Object[] _objects; //Field offset: 0x38
	internal readonly RuntimeLabel[] _labels; //Field offset: 0x40
	internal readonly DebugInfo[] _debugInfos; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; //Field offset: 0x60

	internal int ClosureSize
	{
		[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "get_ConsumedStack", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		internal get { } //Length: 71
	}

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal InstructionArray Instructions
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 29
	}

	internal int LocalCount
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal string Name
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Interpreter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "get_ConsumedStack", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	internal int get_ClosureSize() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal InstructionArray get_Instructions() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_LocalCount() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal string get_Name() { }

	[CallerCount(Count = 35)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Run(InterpretedFrame frame) { }

}

