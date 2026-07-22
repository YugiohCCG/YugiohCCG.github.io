namespace System.Linq.Expressions.Interpreter;

internal abstract class AddInstruction : Instruction
{
	private sealed class AddDouble : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddDouble() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt16 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt32 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptingRuntimeHelpers), Member = "Int32ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt64 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddSingle : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddSingle() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt16 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddUInt16() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt32 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddUInt32() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt64 : AddInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public AddUInt64() { }

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
	private AddInstruction() { }

	[CalledBy(Type = typeof(AddOvfInstruction), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Instruction))]
	[CalledBy(Type = typeof(InstructionList), Member = "EmitAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArithmetic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression)}, ReturnType = typeof(void))]
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

