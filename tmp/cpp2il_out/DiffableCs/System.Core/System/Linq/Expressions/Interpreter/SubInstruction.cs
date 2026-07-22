namespace System.Linq.Expressions.Interpreter;

internal abstract class SubInstruction : Instruction
{
	private sealed class SubDouble : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubDouble() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubInt16 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubInt32 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "Int32ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubInt64 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubSingle : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubSingle() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubUInt16 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubUInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubUInt32 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubUInt32() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubUInt64 : SubInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SubUInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
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
		[CallerCount(Count = 8)]
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
	private SubInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public static Instruction Create(Type type) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

}

