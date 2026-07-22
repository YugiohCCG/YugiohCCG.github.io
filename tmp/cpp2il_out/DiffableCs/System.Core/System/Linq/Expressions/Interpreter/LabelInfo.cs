namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }

	}

	private readonly LabelTarget _node; //Field offset: 0x10
	private BranchLabel _label; //Field offset: 0x18
	private object _definitions; //Field offset: 0x20
	private readonly List<LabelScopeInfo> _references; //Field offset: 0x28
	private bool _acrossBlockJump; //Field offset: 0x30

	private bool HasDefinitions
	{
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 9
	}

	private bool HasMultipleDefinitions
	{
		[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 117
	}

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileStringSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "EnsureLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CalledBy(Type = typeof(LightCompiler), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal LabelInfo(LabelTarget node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void AddDefinition(LabelScopeInfo scope) { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	internal static T CommonNode(T first, T second, Func<T, T> parent) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLoopExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileLabelExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LabelInfo), Member = "get_HasMultipleDefinitions", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "LabelTargetAlreadyDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "AmbiguousJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	internal void Define(LabelScopeInfo block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	private bool DefinedIn(LabelScopeInfo scope) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[CallsUnknownMethods(Count = 2)]
	private void EnsureLabel(LightCompiler compiler) { }

	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private LabelScopeInfo FirstDefinition() { }

	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_HasDefinitions() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_HasMultipleDefinitions() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileIntSwitchExpression", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SwitchExpression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InstructionList), Member = "MakeLabel", ReturnType = typeof(BranchLabel))]
	[CallsUnknownMethods(Count = 2)]
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LabelInfo), Member = "ValidateJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void Reference(LabelScopeInfo block) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Error), Member = "LabelTargetUndefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void ValidateFinish() { }

	[CalledBy(Type = typeof(LabelInfo), Member = "Reference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LabelInfo), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelScopeInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileGotoExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "ReferenceLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelInfo))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Error), Member = "ControlCannotEnterExpression", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ControlCannotEnterTry", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ControlCannotLeaveFinally", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "ControlCannotLeaveFilterTest", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "NonLocalJumpWithValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(LabelInfo), Member = "FirstDefinition", ReturnType = typeof(LabelScopeInfo))]
	[Calls(Type = typeof(LabelInfo), Member = "CommonNode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", "System.Func`2<T, T>"}, ReturnType = "T")]
	[Calls(Type = typeof(LabelInfo), Member = "get_HasMultipleDefinitions", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "AmbiguousJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void ValidateJump(LabelScopeInfo reference) { }

}

