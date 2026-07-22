namespace System.Linq.Expressions.Interpreter;

internal sealed class BranchLabel
{
	private int _targetIndex; //Field offset: 0x10
	private int _stackDepth; //Field offset: 0x14
	private int _continuationStackDepth; //Field offset: 0x18
	private List<Int32> _forwardBranchFixups; //Field offset: 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; //Field offset: 0x28

	internal bool HasRuntimeLabel
	{
		[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
		[CalledBy(Type = typeof(InstructionList), Member = "EnsureLabelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(EnterTryFaultInstruction))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 11
	}

	internal int LabelIndex
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int TargetIndex
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BranchLabel() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OffsetInstruction), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitCoalescingBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranchTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitBranchFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CalledBy(Type = typeof(InstructionList), Member = "EnsureLabelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterTryFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(EnterTryFaultInstruction))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitEnterFault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeaveExceptionHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasRuntimeLabel() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal int get_LabelIndex() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	internal int get_TargetIndex() { }

	[CalledBy(Type = typeof(InstructionList), Member = "MarkRuntimeLabel", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryFaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstructionList), Member = "MarkLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BranchLabel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void Mark(InstructionList instructions) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_LabelIndex(int value) { }

	[CalledBy(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CallerCount(Count = 1)]
	internal RuntimeLabel ToRuntimeLabel() { }

}

