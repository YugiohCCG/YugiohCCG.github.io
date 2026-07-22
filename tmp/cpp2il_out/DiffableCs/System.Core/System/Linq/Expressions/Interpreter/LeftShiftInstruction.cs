namespace System.Linq.Expressions.Interpreter;

internal abstract class LeftShiftInstruction : Instruction
{
	private sealed class LeftShiftByte : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftByte() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt16 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt32 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt64 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftSByte : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftSByte() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt16 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftUInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt32 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftUInt32() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt64 : LeftShiftInstruction
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LeftShiftUInt64() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 10)]
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

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private LeftShiftInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitLeftShift", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileBinaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
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

