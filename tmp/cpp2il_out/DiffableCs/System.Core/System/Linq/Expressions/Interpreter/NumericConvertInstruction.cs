namespace System.Linq.Expressions.Interpreter;

internal abstract class NumericConvertInstruction : Instruction
{
	public sealed class Checked : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Checked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		protected virtual object Convert(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 21)]
		[ContainsUnimplementedInstructions]
		private object ConvertDouble(double obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		private object ConvertInt32(int obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		private object ConvertInt64(long obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 19)]
		[ContainsUnimplementedInstructions]
		private object ConvertUInt64(ulong obj) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

	}

	public sealed class ToUnderlying : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CalledBy(Type = typeof(InstructionList), Member = "EmitConvertToUnderlying", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ToUnderlying(TypeCode to, bool isLiftedToNull) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 23)]
		protected virtual object Convert(object obj) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

	}

	public sealed class Unchecked : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unchecked), Member = "ConvertInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Unchecked), Member = "ConvertInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Unchecked), Member = "ConvertDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 19)]
		[ContainsUnimplementedInstructions]
		protected virtual object Convert(object obj) { }

		[CalledBy(Type = typeof(Unchecked), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private object ConvertDouble(double obj) { }

		[CalledBy(Type = typeof(Unchecked), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private object ConvertInt32(int obj) { }

		[CalledBy(Type = typeof(Unchecked), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private object ConvertInt64(long obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Decimal), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		private object ConvertUInt64(ulong obj) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

	}

	internal readonly TypeCode _from; //Field offset: 0x10
	internal readonly TypeCode _to; //Field offset: 0x14
	private readonly bool _isLiftedToNull; //Field offset: 0x18

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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	protected abstract object Convert(object obj) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ConsumedStack() { }

	[CallerCount(Count = 0)]
	public virtual string get_InstructionName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_ProducedStack() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterpretedFrame), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(InterpretedFrame), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual int Run(InterpretedFrame frame) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

}

