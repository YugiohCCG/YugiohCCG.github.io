namespace System.Linq.Expressions.Interpreter;

internal abstract class InitializeLocalInstruction : LocalAccessInstruction
{
	public sealed class ImmutableBox : InitializeLocalInstruction
	{
		private readonly object _defaultValue; //Field offset: 0x18

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ImmutableBox(int index, object defaultValue) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ImmutableRefBox : InitializeLocalInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ImmutableRefBox(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly object _defaultValue; //Field offset: 0x18

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ImmutableValue(int index, object defaultValue) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override Instruction BoxIfIndexMatches(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class MutableBox : InitializeLocalInstruction
	{
		private readonly Type _type; //Field offset: 0x18

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal MutableBox(int index, Type type) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly Type _type; //Field offset: 0x18

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal MutableValue(int index, Type type) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override Instruction BoxIfIndexMatches(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 10)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Parameter(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstructionList), Member = "ParameterBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		public override Instruction BoxIfIndexMatches(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ParameterBox : InitializeLocalInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ParameterBox(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
	{

		public virtual string InstructionName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CallerCount(Count = 31)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Reference(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstructionList), Member = "InitImmutableRefBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instruction))]
		public override Instruction BoxIfIndexMatches(int index) { }

		[CallerCount(Count = 0)]
		public virtual string get_InstructionName() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public virtual int Run(InterpretedFrame frame) { }

	}


	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal InitializeLocalInstruction(int index) { }

}

