namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
internal sealed class InstructionList
{
	public sealed class DebugView
	{
		[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
		[IsReadOnly]
		public struct InstructionView
		{
			private readonly int _index; //Field offset: 0x0
			private readonly int _stackDepth; //Field offset: 0x4
			private readonly int _continuationsDepth; //Field offset: 0x8
			private readonly string _name; //Field offset: 0x10
			private readonly Instruction _instruction; //Field offset: 0x18

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }

			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			internal string GetValue() { }

		}


		[CalledBy(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(InstructionView[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Instruction), Member = "get_StackBalance", ReturnType = typeof(int))]
		[Calls(Type = typeof(Instruction), Member = "get_ContinuationsBalance", ReturnType = typeof(int))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 16)]
		internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<Object> objects, Func<Int32, Int32> labelIndexer, IReadOnlyList<KeyValuePair`2<Int32, Object>> debugCookies) { }

	}

	private static Instruction s_null; //Field offset: 0x0
	private static Instruction s_true; //Field offset: 0x8
	private static Instruction s_false; //Field offset: 0x10
	private static Instruction[] s_Ints; //Field offset: 0x18
	private static Instruction[] s_loadObjectCached; //Field offset: 0x20
	private static Instruction[] s_loadLocal; //Field offset: 0x28
	private static Instruction[] s_loadLocalBoxed; //Field offset: 0x30
	private static Instruction[] s_loadLocalFromClosure; //Field offset: 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; //Field offset: 0x40
	private static Instruction[] s_assignLocal; //Field offset: 0x48
	private static Instruction[] s_storeLocal; //Field offset: 0x50
	private static Instruction[] s_assignLocalBoxed; //Field offset: 0x58
	private static Instruction[] s_storeLocalBoxed; //Field offset: 0x60
	private static Instruction[] s_assignLocalToClosure; //Field offset: 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; //Field offset: 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; //Field offset: 0x78
	private readonly List<Instruction> _instructions; //Field offset: 0x10
	private List<Object> _objects; //Field offset: 0x18
	private int _currentStackDepth; //Field offset: 0x20
	private int _maxStackDepth; //Field offset: 0x24
	private int _currentContinuationsDepth; //Field offset: 0x28
	private int _maxContinuationDepth; //Field offset: 0x2C
	private int _runtimeLabelCount; //Field offset: 0x30
	private List<BranchLabel> _labels; //Field offset: 0x38
	private List<KeyValuePair`2<Int32, Object>> _debugCookies; //Field offset: 0x40

	public int Count
	{
		[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
		[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 60
	}

	public int CurrentContinuationsDepth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int CurrentStackDepth
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static InstructionList() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public InstructionList() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitAssignLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssignLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal static Instruction AssignLocalBoxed(int index) { }

	[CalledBy(Type = typeof(InstructionList), Member = "ToArray", ReturnType = typeof(InstructionArray))]
	[CalledBy(Type = typeof(LightCompiler), Member = "MakeInterpreter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Interpreter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BranchLabel), Member = "ToRuntimeLabel", ReturnType = typeof(RuntimeLabel))]
	[Calls(Type = typeof(RuntimeLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private RuntimeLabel[] BuildRuntimeLabels() { }

	[CallerCount(Count = 155)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void Emit(Instruction instruction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(AddInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitAdd(Type type, bool checked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitAnd(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitArrayLength() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitAssignLocal(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "AssignLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitAssignLocalBoxed(int index) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitStoreLocalToClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitAssignLocalToClosure(int index) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BranchInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BranchInstruction), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitBranch(BranchLabel label) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConditionalExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(CallInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileListInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(CallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(CallInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitCall(MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CastInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitCast(Type toType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitCastReferenceToEnum(Type toType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitCastToEnum(Type toType) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToUnderlying), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitDecrement(Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitDefaultValue(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DivInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitDiv(Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitDup() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitEnterExceptionFilter() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitEnterExceptionHandlerNonVoid() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitEnterExceptionHandlerVoid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnterFaultInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterFaultInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnterFinallyInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnterTryCatchFinallyInstruction), Member = "CreateTryCatch", ReturnType = typeof(EnterTryCatchFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitEnterTryCatch() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EnterTryCatchFinallyInstruction), Member = "CreateTryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(EnterTryCatchFinallyInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitEqual(Type type, bool liftedToNull = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExclusiveOrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitExclusiveOr(Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EmitIndexGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitGetArrayItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GotoInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(GotoInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GreaterThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GreaterThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IncrementInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitIncrement(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "GetPrimitiveDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitInitializeLocal(int index, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void EmitInitializeParameter(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void EmitIntSwitch(Dictionary<T, Int32> cases) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLeaveExceptionFilter() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LeaveExceptionHandlerInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LeaveExceptionHandlerInstruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLeaveFault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLeaveFinally() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeftShiftInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLeftShift(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LessThanInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLessThan(Type type, bool liftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LessThanOrEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeEqualExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileDefaultExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConstantExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public void EmitLoad(object value, Type type) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EmitUnaryBoolCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnliftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void EmitLoad(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "EmitLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	public void EmitLoad(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLoadField(FieldInfo field) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitLoadLocal(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "LoadLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitLoadLocalBoxed(int index) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitLoadLocalFromClosure(int index) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModuloInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitModulo(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MulOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(MulInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitMul(Type type, bool checked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NegateInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitNegate(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NegateCheckedInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitNegateChecked(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNewArray(Type elementType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNewRuntimeVariables(int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitNot(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotEqualInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitNotEqual(Type type, bool liftedToNull = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NullableMethodCallInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(MethodInfo)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OrInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitOr(Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileListInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAsVoid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitPop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitRethrow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitRethrowVoid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RightShiftInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitRightShift(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitSetArrayItem() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EmitStoreField(FieldInfo field) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void EmitStoreLocal(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "StoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitStoreLocalBoxed(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "EmitAssignLocalToClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitStoreLocalToClosure(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitStringSwitch(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(SubInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EmitSub(Type type, bool checked) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitThrow() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitThrowVoid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmitTypeAs(Type type) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTypeIsExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InstructionList), Member = "Emit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(void))]
	public void EmitTypeEquals() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	public void EmitTypeIs(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private int EnsureLabelIndex(BranchLabel label) { }

	[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BranchLabel), Member = "AddBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BranchLabel), Member = "FixupBranch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OffsetInstruction), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void FixupBranch(int branchIndex, int offset) { }

	[CalledBy(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public int get_Count() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_CurrentContinuationsDepth() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_CurrentStackDepth() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal Instruction GetInstruction(int index) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private Instruction GetLoadField(FieldInfo field) { }

	[CalledBy(Type = typeof(Reference), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Instruction InitImmutableRefBox(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Instruction InitReference(int index) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLoadLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LoadLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal static Instruction LoadLocalBoxed(int index) { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(BranchLabel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public BranchLabel MakeLabel() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void MarkLabel(BranchLabel label) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[Calls(Type = typeof(BranchLabel), Member = "Mark", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BranchLabel), Member = "get_HasRuntimeLabel", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public int MarkRuntimeLabel() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Instruction Parameter(int index) { }

	[CalledBy(Type = typeof(Parameter), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Instruction ParameterBox(int index) { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitStoreLocalBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StoreLocalInstruction), Member = "BoxIfIndexMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal static Instruction StoreLocalBoxed(int index) { }

	[CalledBy(Type = typeof(LocalVariables), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(InstructionList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(InstructionList), Member = "BuildRuntimeLabels", ReturnType = typeof(RuntimeLabel[]))]
	[CallsUnknownMethods(Count = 5)]
	public InstructionArray ToArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void UnEmit() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateStackDepth(Instruction instruction) { }

}

