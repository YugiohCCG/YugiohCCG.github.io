namespace System.Data;

internal sealed class AutoIncrementBigInteger : AutoIncrementValue
{
	private BigInteger _current; //Field offset: 0x18
	private long _seed; //Field offset: 0x28
	private BigInteger _step; //Field offset: 0x30

	internal virtual object Current
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 69
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 119
	}

	internal virtual Type DataType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		internal get { } //Length: 77
	}

	internal virtual long Seed
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(AutoIncrementBigInteger), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 254
	}

	internal virtual long Step
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(long))]
		internal get { } //Length: 96
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementSeed", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal set { } //Length: 461
	}

	[CalledBy(Type = typeof(DataColumn), Member = "get_AutoInc", ReturnType = typeof(AutoIncrementValue))]
	[CalledBy(Type = typeof(DataColumn), Member = "Clone", ReturnType = typeof(DataColumn))]
	[CalledBy(Type = typeof(AutoIncrementValue), Member = "Clone", ReturnType = typeof(AutoIncrementValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BigInteger))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AutoIncrementBigInteger() { }

	[CalledBy(Type = typeof(AutoIncrementBigInteger), Member = "set_Seed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoIncrementBigInteger), Member = "SetCurrentAndIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BigInteger)}, ReturnType = typeof(bool))]
	private bool BoundaryCheck(BigInteger value) { }

	[CallerCount(Count = 0)]
	internal virtual object get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	internal virtual Type get_DataType() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal virtual long get_Seed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(long))]
	internal virtual long get_Step() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void MoveAfter() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void set_Current(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(AutoIncrementBigInteger), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void set_Seed(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementSeed", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal virtual void set_Step(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigIntegerStorage), Member = "ConvertToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 1)]
	internal virtual void SetCurrent(object value, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AutoIncrementBigInteger), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[CallsUnknownMethods(Count = 3)]
	internal virtual void SetCurrentAndIncrement(object value) { }

}

