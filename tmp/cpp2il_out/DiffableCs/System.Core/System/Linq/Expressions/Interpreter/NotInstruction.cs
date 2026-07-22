namespace System.Linq.Expressions.Interpreter;

internal abstract class NotInstruction : Instruction
{
	private sealed class NotBoolean : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotBoolean() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotByte : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotByte() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt16 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt32 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt64 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotInt64() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotSByte : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotSByte() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt16 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotUInt16() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt32 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotUInt32() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt64 : NotInstruction
	{

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NotUInt64() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public static Instruction s_Boolean; //Field offset: 0x0
	public static Instruction s_Int64; //Field offset: 0x8
	public static Instruction s_Int32; //Field offset: 0x10
	public static Instruction s_Int16; //Field offset: 0x18
	public static Instruction s_UInt64; //Field offset: 0x20
	public static Instruction s_UInt32; //Field offset: 0x28
	public static Instruction s_UInt16; //Field offset: 0x30
	public static Instruction s_Byte; //Field offset: 0x38
	public static Instruction s_SByte; //Field offset: 0x40

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
	private NotInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitNot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNotExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnaryExpression)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TypeUtils), Member = "GetNonNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
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

