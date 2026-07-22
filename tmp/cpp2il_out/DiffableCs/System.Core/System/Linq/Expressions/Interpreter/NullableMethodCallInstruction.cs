namespace System.Linq.Expressions.Interpreter;

internal abstract class NullableMethodCallInstruction : Instruction
{
	private sealed class EqualsClass : NullableMethodCallInstruction
	{

		public virtual int ConsumedStack
		{
			[CallerCount(Count = 8)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public EqualsClass() { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		public virtual int get_ConsumedStack() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetHashCodeClass : NullableMethodCallInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public GetHashCodeClass() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValue : NullableMethodCallInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public GetValue() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValueOrDefault : NullableMethodCallInstruction
	{
		private readonly Type _defaultValueType; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public GetValueOrDefault(MethodInfo mi) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Peek", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
	{

		public virtual int ConsumedStack
		{
			[CallerCount(Count = 8)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public GetValueOrDefault1() { }

		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		public virtual int get_ConsumedStack() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class HasValue : NullableMethodCallInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public HasValue() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ToStringClass : NullableMethodCallInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ToStringClass() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private static NullableMethodCallInstruction s_hasValue; //Field offset: 0x0
	private static NullableMethodCallInstruction s_value; //Field offset: 0x8
	private static NullableMethodCallInstruction s_equals; //Field offset: 0x10
	private static NullableMethodCallInstruction s_getHashCode; //Field offset: 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; //Field offset: 0x20
	private static NullableMethodCallInstruction s_toString; //Field offset: 0x28

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

	public virtual int ProducedStack
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private NullableMethodCallInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitNullableCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(ParameterInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMethodCallExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(IArgumentProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 4)]
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Instruction CreateGetValue() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

}

