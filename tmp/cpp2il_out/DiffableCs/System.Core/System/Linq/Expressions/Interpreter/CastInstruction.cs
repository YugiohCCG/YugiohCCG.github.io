namespace System.Linq.Expressions.Interpreter;

internal abstract class CastInstruction : Instruction
{
	private abstract class CastInstructionNoT : CastInstruction
	{
		private sealed class Ref : CastInstructionNoT
		{

			[CallerCount(Count = 27)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public Ref(Type t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		private sealed class Value : CastInstructionNoT
		{

			[CallerCount(Count = 27)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public Value(Type t) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		private readonly Type _t; //Field offset: 0x10

		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		protected CastInstructionNoT(Type t) { }

		protected abstract void ConvertNull(InterpretedFrame frame) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static CastInstruction Create(Type t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeUtils), Member = "HasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TypeUtils), Member = "HasIdentityPrimitiveOrNullableConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class CastInstructionT : CastInstruction
	{

		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CastInstructionT`1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual int Run(InterpretedFrame frame) { }

	}

	private static CastInstruction s_Boolean; //Field offset: 0x0
	private static CastInstruction s_Byte; //Field offset: 0x8
	private static CastInstruction s_Char; //Field offset: 0x10
	private static CastInstruction s_DateTime; //Field offset: 0x18
	private static CastInstruction s_Decimal; //Field offset: 0x20
	private static CastInstruction s_Double; //Field offset: 0x28
	private static CastInstruction s_Int16; //Field offset: 0x30
	private static CastInstruction s_Int32; //Field offset: 0x38
	private static CastInstruction s_Int64; //Field offset: 0x40
	private static CastInstruction s_SByte; //Field offset: 0x48
	private static CastInstruction s_Single; //Field offset: 0x50
	private static CastInstruction s_String; //Field offset: 0x58
	private static CastInstruction s_UInt16; //Field offset: 0x60
	private static CastInstruction s_UInt32; //Field offset: 0x68
	private static CastInstruction s_UInt64; //Field offset: 0x70

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
	protected CastInstruction() { }

	[CalledBy(Type = typeof(InstructionList), Member = "EmitCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TypeExtensions), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtils), Member = "IsNullableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 4)]
	public static Instruction Create(Type t) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

}

