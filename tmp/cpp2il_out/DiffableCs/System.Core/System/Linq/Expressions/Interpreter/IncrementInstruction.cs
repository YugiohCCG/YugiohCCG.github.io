namespace System.Linq.Expressions.Interpreter;

internal abstract class IncrementInstruction : Instruction
{
	private sealed class IncrementDouble : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementDouble() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt16 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt32 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "Int32ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 7)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt64 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementSingle : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementSingle() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt16 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementUInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt32 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementUInt32() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt64 : IncrementInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public IncrementUInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_Int16; //Field offset: 0x0
	private static Instruction s_Int32; //Field offset: 0x8
	private static Instruction s_Int64; //Field offset: 0x10
	private static Instruction s_UInt16; //Field offset: 0x18
	private static Instruction s_UInt32; //Field offset: 0x20
	private static Instruction s_UInt64; //Field offset: 0x28
	private static Instruction s_Single; //Field offset: 0x30
	private static Instruction s_Double; //Field offset: 0x38

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

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private IncrementInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public static Instruction Create(Type type) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

}

