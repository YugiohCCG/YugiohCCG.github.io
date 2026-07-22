namespace System.Linq.Expressions.Interpreter;

internal class LightLambda
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public MethodInfo targetMethod; //Field offset: 0x10
		public Type delegateType; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass74_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }

	}

	private class DebugViewPrinter
	{
		private readonly Interpreter _interpreter; //Field offset: 0x10
		private readonly Dictionary<Int32, Int32> _tryStart; //Field offset: 0x18
		private readonly Dictionary<Int32, String> _handlerEnter; //Field offset: 0x20
		private readonly Dictionary<Int32, Int32> _handlerExit; //Field offset: 0x28
		private string _indent; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugViewPrinter), Member = "Analyze", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		public DebugViewPrinter(Interpreter interpreter) { }

		[CalledBy(Type = typeof(DebugViewPrinter), Member = "Analyze", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private void AddHandlerExit(int index) { }

		[CalledBy(Type = typeof(DebugViewPrinter), Member = "Analyze", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private void AddTryStart(int index) { }

		[CalledBy(Type = typeof(DebugViewPrinter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Interpreter)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightLambda), Member = "get_DebugView", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DebugViewPrinter), Member = "AddTryStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugViewPrinter), Member = "AddHandlerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TryCatchFinallyHandler), Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		private void Analyze() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		private void Dedent() { }

		[CalledBy(Type = typeof(DebugViewPrinter), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 2)]
		private void EmitExits(StringBuilder sb, int index) { }

		[CalledBy(Type = typeof(DebugViewPrinter), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		private void Indent() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(string), Member = "PadLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DebugViewPrinter), Member = "Indent", ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DebugViewPrinter), Member = "EmitExits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugView), Member = "GetInstructionViews", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(InstructionView[]))]
		[Calls(Type = typeof(DebugView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstructionArray)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public virtual string ToString() { }

	}

	private static readonly CacheDict<Type, Func`2<LightLambda, Delegate>> _runCache; //Field offset: 0x0
	private readonly IStrongBox[] _closure; //Field offset: 0x10
	private readonly Interpreter _interpreter; //Field offset: 0x18
	private readonly LightDelegateCreator _delegateCreator; //Field offset: 0x20

	internal string DebugView
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugViewPrinter), Member = "Analyze", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		internal get { } //Length: 387
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CacheDict`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static LightLambda() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	[CalledBy(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(ParameterExpression[])}, ReturnType = typeof(LambdaExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "TryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(TryExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression[])}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression[])}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression[])}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(InvocationExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 87)]
	private Delegate CreateCustomDelegate(Type delegateType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugViewPrinter), Member = "Analyze", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal string get_DebugView() { }

	[CalledBy(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CacheDict`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[Calls(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Delegate MakeDelegate(Type delegateType) { }

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(InterpretedFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Interpreter), typeof(IStrongBox[])}, ReturnType = typeof(void))]
	private InterpretedFrame MakeFrame() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun0(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun1(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun10(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun11(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun12(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun13(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun14(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun15(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun2(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun3(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun4(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun5(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun6(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun7(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun8(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRun9(LightLambda lambda) { }

	[CalledBy(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(DelegateHelpers), Member = "MakeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CacheDict`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 22)]
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid1(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid10(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid11(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid12(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid13(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid14(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid15(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid2(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid3(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid4(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid5(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid6(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid7(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid8(LightLambda lambda) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static Delegate MakeRunVoid9(LightLambda lambda) { }

	[CalledBy(Type = typeof(CallInstruction), Member = "InterpretLambdaInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightLambda), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefMethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterpretedFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Interpreter), typeof(IStrongBox[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 10)]
	public object Run(Object[] arguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal TRet Run0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	internal TRet Run1(T0 arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 70)]
	[DeduplicatedMethod]
	internal TRet Run10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 76)]
	[DeduplicatedMethod]
	internal TRet Run11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 82)]
	[DeduplicatedMethod]
	internal TRet Run12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 88)]
	[DeduplicatedMethod]
	internal TRet Run13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 94)]
	[DeduplicatedMethod]
	internal TRet Run14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 100)]
	[DeduplicatedMethod]
	internal TRet Run15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	internal TRet Run2(T0 arg0, T1 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 28)]
	[DeduplicatedMethod]
	internal TRet Run3(T0 arg0, T1 arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 34)]
	[DeduplicatedMethod]
	internal TRet Run4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 40)]
	[DeduplicatedMethod]
	internal TRet Run5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 46)]
	[DeduplicatedMethod]
	internal TRet Run6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 52)]
	[DeduplicatedMethod]
	internal TRet Run7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 58)]
	[DeduplicatedMethod]
	internal TRet Run8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 64)]
	[DeduplicatedMethod]
	internal TRet Run9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	[CalledBy(Type = typeof(CallInstruction), Member = "InterpretLambdaInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightLambda), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefMethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterpretedFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Interpreter), typeof(IStrongBox[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public object RunVoid(Object[] arguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Interpreter), typeof(IStrongBox[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void RunVoid0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	internal void RunVoid1(T0 arg0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 66)]
	[DeduplicatedMethod]
	internal void RunVoid10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 72)]
	[DeduplicatedMethod]
	internal void RunVoid11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 78)]
	[DeduplicatedMethod]
	internal void RunVoid12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 84)]
	[DeduplicatedMethod]
	internal void RunVoid13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 90)]
	[DeduplicatedMethod]
	internal void RunVoid14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 96)]
	[DeduplicatedMethod]
	internal void RunVoid15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	internal void RunVoid2(T0 arg0, T1 arg1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	internal void RunVoid3(T0 arg0, T1 arg1, T2 arg2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	[DeduplicatedMethod]
	internal void RunVoid4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 36)]
	[DeduplicatedMethod]
	internal void RunVoid5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 42)]
	[DeduplicatedMethod]
	internal void RunVoid6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 48)]
	[DeduplicatedMethod]
	internal void RunVoid7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 54)]
	[DeduplicatedMethod]
	internal void RunVoid8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Leave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 60)]
	[DeduplicatedMethod]
	internal void RunVoid9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightLambda), Member = "MakeFrame", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(InterpretedFrame), Member = "Enter", ReturnType = typeof(InterpretedFrame))]
	[Calls(Type = typeof(Interpreter), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	internal void RunVoidRef2(ref T0 arg0, ref T1 arg1) { }

}

