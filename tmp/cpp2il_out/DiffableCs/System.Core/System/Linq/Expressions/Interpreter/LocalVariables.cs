namespace System.Linq.Expressions.Interpreter;

internal sealed class LocalVariables
{
	private sealed class VariableScope
	{
		public readonly int Start; //Field offset: 0x10
		public int Stop; //Field offset: 0x14
		public readonly LocalVariable Variable; //Field offset: 0x18
		public readonly VariableScope Parent; //Field offset: 0x20
		public List<VariableScope> ChildScopes; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterMyLockSpin", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[ContainsUnimplementedInstructions]
		public VariableScope(LocalVariable variable, int start, VariableScope parent) { }

	}

	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; //Field offset: 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; //Field offset: 0x18
	private int _localCount; //Field offset: 0x20
	private int _maxLocalCount; //Field offset: 0x24

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public int LocalCount
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(LightCompiler), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public LocalVariables() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(InstructionList), Member = "SwitchToBoxed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LambdaExpression)}, ReturnType = typeof(LightDelegateCreator))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMultiDimArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(IArgumentProvider), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BlockExpression)}, ReturnType = typeof(LocalDefinition[]))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_LocalCount() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureAvailableForClosure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "ResolveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(LocalVariable))]
	[CalledBy(Type = typeof(LightCompiler), Member = "LoadLocalNoValueTypeCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGetBoxedVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSetVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileQuoteUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayByRefUpdater), Member = "UndefineTemps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionList), typeof(LocalVariables)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileCoalesceBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), typeof(Expression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIndexAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBlockEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLiftedLogicalBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryExpression), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void UndefineLocal(LocalDefinition definition, int end) { }

}

