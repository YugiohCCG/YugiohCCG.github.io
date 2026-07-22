namespace System.Data;

internal sealed class AutoIncrementInt64 : AutoIncrementValue
{
	private long _current; //Field offset: 0x18
	private long _seed; //Field offset: 0x20
	private long _step; //Field offset: 0x28

	internal virtual object Current
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 35
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 69
	}

	internal virtual Type DataType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[DeduplicatedMethod]
		internal get { } //Length: 50
	}

	internal virtual long Seed
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(AutoIncrementInt64), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
		internal set { } //Length: 138
	}

	internal virtual long Step
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementSeed", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 125
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AutoIncrementInt64() { }

	[CalledBy(Type = typeof(AutoIncrementInt64), Member = "set_Seed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoIncrementInt64), Member = "SetCurrentAndIncrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BigInteger)}, ReturnType = typeof(bool))]
	private bool BoundaryCheck(BigInteger value) { }

	[CallerCount(Count = 0)]
	internal virtual object get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	internal virtual Type get_DataType() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal virtual long get_Seed() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal virtual long get_Step() { }

	[CallerCount(Count = 0)]
	internal virtual void MoveAfter() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void set_Current(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(AutoIncrementInt64), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	internal virtual void set_Seed(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "AutoIncrementSeed", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void set_Step(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	internal virtual void SetCurrent(object value, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BigInteger), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(AutoIncrementInt64), Member = "BoundaryCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void SetCurrentAndIncrement(object value) { }

}

