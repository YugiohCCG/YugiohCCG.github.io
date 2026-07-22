namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
	[NullableContext(1)]
	private class JValueDynamicProxy : DynamicProxy<JValue>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public JValueDynamicProxy() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(JValue), Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		public virtual bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(ConvertUtils), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public virtual bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	}

	private JTokenType _valueType; //Field offset: 0x30
	private object _value; //Field offset: 0x38

	public virtual bool HasValues
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual JTokenType Type
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public object Value
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>), typeof(object)}, ReturnType = typeof(JTokenType))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 199
	}

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(Guid value) { }

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>), typeof(object)}, ReturnType = typeof(JTokenType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(object value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(TimeSpan value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(Uri value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(string value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(bool value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(DateTimeOffset value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(float value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(DateTime value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	public JValue(ulong value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(char value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(decimal value) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(long value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	public JValue(JValue other) { }

	[CalledBy(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JRaw)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JRaw), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JRaw), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JToken), Member = "CopyAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	internal JValue(JValue other, JsonCloneSettings settings) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JRaw+<CreateAsync>d__0", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JRaw), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader)}, ReturnType = typeof(JRaw))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal JValue(object value, JTokenType type) { }

	[CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BoxedPrimitives), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public JValue(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "CopyAnnotations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JToken)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	[CalledBy(Type = typeof(JsonValidatingReader), Member = "ValidateInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonSchemaModel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValueDynamicProxy), Member = "TryBinaryOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(BinaryOperationBinder), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JValue), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JValue), Member = "ValuesEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JValue), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JValue), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStrictMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JValue)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[ContainsInvalidInstructions]
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConvertUtils), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(MathUtils), Member = "ApproxEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[NullableContext(1)]
	private static int CompareFloat(object objA, object objB) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public override int CompareTo(JValue obj) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public static JValue CreateComment(string value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "EnsureParentToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteNull", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public static JValue CreateNull() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public static JValue CreateString(string value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public static JValue CreateUndefined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	internal virtual bool DeepEquals(JToken node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(JValue other) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_HasValues() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public virtual JTokenType get_Type() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public object get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal virtual int GetDeepHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicProxyMetaObject`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "T", "Newtonsoft.Json.Utilities.DynamicProxy`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	[CallerCount(Count = 0)]
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	[CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	[CalledBy(Type = typeof(JValueDynamicProxy), Member = "TryBinaryOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(BinaryOperationBinder), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(BigInteger), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(ConvertUtils), Member = "ToBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<Newtonsoft.Json.Linq.JTokenType>), typeof(object)}, ReturnType = typeof(JTokenType))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Value(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	private override int System.IComparable.CompareTo(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override TypeCode System.IConvertible.GetTypeCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(char))]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(DateTime))]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(short))]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(long))]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(float))]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[NullableContext(1)]
	private override object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[NullableContext(1)]
	public override string ToString(IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[ContainsInvalidInstructions]
	[NullableContext(1)]
	public string ToString(string format) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(JValue), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JTokenType), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>), typeof(Type)}, ReturnType = typeof(JsonConverter))]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[NullableContext(1)]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>), typeof(Type)}, ReturnType = typeof(JsonConverter))]
	[Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(ArgumentOutOfRangeException))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 24)]
	[NullableContext(1)]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

