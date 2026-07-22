namespace System.Linq.Expressions.Interpreter;

internal abstract class ExclusiveOrInstruction : Instruction
{
	private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrBoolean() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrByte : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrByte() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 11)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrSByte : ExclusiveOrInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrSByte() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrUInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrUInt32() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 11)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ExclusiveOrUInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 11)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_SByte; //Field offset: 0x0
	private static Instruction s_Int16; //Field offset: 0x8
	private static Instruction s_Int32; //Field offset: 0x10
	private static Instruction s_Int64; //Field offset: 0x18
	private static Instruction s_Byte; //Field offset: 0x20
	private static Instruction s_UInt16; //Field offset: 0x28
	private static Instruction s_UInt32; //Field offset: 0x30
	private static Instruction s_UInt64; //Field offset: 0x38
	private static Instruction s_Boolean; //Field offset: 0x40

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
	private ExclusiveOrInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitExclusiveOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
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

