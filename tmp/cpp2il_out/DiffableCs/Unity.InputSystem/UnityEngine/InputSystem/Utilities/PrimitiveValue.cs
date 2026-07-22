namespace UnityEngine.InputSystem.Utilities;

public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible
{
	private TypeCode m_Type; //Field offset: 0x0
	private bool m_BoolValue; //Field offset: 0x4
	private char m_CharValue; //Field offset: 0x4
	private byte m_ByteValue; //Field offset: 0x4
	private sbyte m_SByteValue; //Field offset: 0x4
	private short m_ShortValue; //Field offset: 0x4
	private ushort m_UShortValue; //Field offset: 0x4
	private int m_IntValue; //Field offset: 0x4
	private uint m_UIntValue; //Field offset: 0x4
	private long m_LongValue; //Field offset: 0x4
	private ulong m_ULongValue; //Field offset: 0x4
	private float m_FloatValue; //Field offset: 0x4
	private double m_DoubleValue; //Field offset: 0x4

	public bool isEmpty
	{
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public TypeCode type
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal Byte* valuePtr
	{
		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding)}, ReturnType = "System.Nullable`1<TValue>")]
		[CallerCount(Count = 1)]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(HIDElementDescriptor), Member = "DetermineDefaultState", ReturnType = typeof(PrimitiveValue))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 2)]
	public PrimitiveValue(int value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(double value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(float value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(bool value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(char value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(byte value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(sbyte value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(short value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(ushort value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(ulong value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(uint value) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	public PrimitiveValue(long value) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue>), typeof(object), typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NamedValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(NamedValue))]
	[CalledBy(Type = typeof(NamedValue), Member = "ApplyToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public PrimitiveValue ConvertTo(TypeCode type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(PrimitiveValue other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(NamedValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue"}, ReturnType = typeof(NamedValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(PrimitiveValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public static PrimitiveValue From(TValue value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromBoolean(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromByte(byte value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromChar(char value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromDouble(double value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromInt16(short value) { }

	[CallerCount(Count = 345)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromInt32(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromInt64(long value) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(ParameterOverride)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.PrimitiveValue>))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "ToLayout", ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(PrimitiveValue), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public static PrimitiveValue FromObject(object value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromSByte(sbyte value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromSingle(float value) { }

	[CalledBy(Type = typeof(NamedValue), Member = "ParseParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(NamedValue))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimStart", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static PrimitiveValue FromString(string value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromUInt16(ushort value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromUInt32(uint value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue FromUInt64(ulong value) { }

	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isEmpty() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public TypeCode get_type() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding)}, ReturnType = "System.Nullable`1<TValue>")]
	[CallerCount(Count = 1)]
	internal Byte* get_valuePtr() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(PrimitiveValue left, PrimitiveValue right) { }

	[CallerCount(Count = 345)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(int value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(ulong value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(long value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(uint value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(ushort value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(short value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(sbyte value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(byte value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(char value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static PrimitiveValue op_Implicit(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(PrimitiveValue left, PrimitiveValue right) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public override bool ToBoolean(IFormatProvider provider = null) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	public override byte ToByte(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override char ToChar(IFormatProvider provider = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override DateTime ToDateTime(IFormatProvider provider = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public override decimal ToDecimal(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override double ToDouble(IFormatProvider provider = null) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	public override short ToInt16(IFormatProvider provider = null) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	public override int ToInt32(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override long ToInt64(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetParameterValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), "System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding)}, ReturnType = "System.Nullable`1<TValue>")]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Utilities.NamedValue>), typeof(object), typeof(InputActionMap), typeof(InputBinding&), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NamedValue), Member = "ApplyToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsInvalidInstructions]
	public object ToObject() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[DeduplicatedMethod]
	public override sbyte ToSByte(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(InputStateBlock), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(PrimitiveValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AxisControl), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AxisControl), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public override float ToSingle(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(HIDElementDescriptor), Member = "AddChildControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDElementDescriptor&), typeof(string), typeof(Builder&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "FromControlItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[])}, ReturnType = typeof(ControlItemJson[]))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(short), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(sbyte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToString", ReturnType = typeof(string))]
	public override string ToString(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override object ToType(Type conversionType, IFormatProvider provider) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	public override ushort ToUInt16(IFormatProvider provider = null) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	public override uint ToUInt32(IFormatProvider provider = null) { }

	[CalledBy(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(PrimitiveValue), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override ulong ToUInt64(IFormatProvider provider = null) { }

}

