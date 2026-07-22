namespace System.Linq.Expressions.Interpreter;

internal abstract class Instruction
{

	public override int ConsumedContinuations
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int ConsumedStack
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int ContinuationsBalance
	{
		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 65
	}

	public abstract string InstructionName
	{
		 get { } //Length: 0
	}

	public override int ProducedContinuations
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int ProducedStack
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public int StackBalance
	{
		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 65
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Instruction() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_ConsumedContinuations() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_ConsumedStack() { }

	[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public int get_ContinuationsBalance() { }

	public abstract string get_InstructionName() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_ProducedContinuations() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_ProducedStack() { }

	[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public int get_StackBalance() { }

	[CalledBy(Type = typeof(MethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefMethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void NullCheck(object o) { }

	public abstract int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

}

