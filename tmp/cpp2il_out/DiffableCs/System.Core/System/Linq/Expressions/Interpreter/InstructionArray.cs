namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[IsReadOnly]
internal struct InstructionArray
{
	public sealed class DebugView
	{
		private readonly InstructionArray _array; //Field offset: 0x10

		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public DebugView(InstructionArray array) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		private int <GetInstructionViews>b__4_0(int index) { }

		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightLambda+DebugViewPrinter", Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Interpreter.Instruction>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Object>), typeof(System.Func`2<System.Int32, System.Int32>), typeof(System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<System.Int32, System.Object>>)}, ReturnType = typeof(InstructionView[]))]
		[CallsDeduplicatedMethods(Count = 1)]
		public InstructionView[] GetInstructionViews(bool includeDebugCookies = false) { }

	}

	internal readonly int MaxStackDepth; //Field offset: 0x0
	internal readonly int MaxContinuationDepth; //Field offset: 0x4
	internal readonly Instruction[] Instructions; //Field offset: 0x8
	internal readonly Object[] Objects; //Field offset: 0x10
	internal readonly RuntimeLabel[] Labels; //Field offset: 0x18
	internal readonly List<KeyValuePair`2<Int32, Object>> DebugCookies; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, Object[] objects, RuntimeLabel[] labels, List<KeyValuePair`2<Int32, Object>> debugCookies) { }

}

