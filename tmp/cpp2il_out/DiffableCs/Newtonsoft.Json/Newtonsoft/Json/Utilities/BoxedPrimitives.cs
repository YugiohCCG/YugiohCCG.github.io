namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class BoxedPrimitives
{
	internal static readonly object BooleanTrue; //Field offset: 0x0
	internal static readonly object BooleanFalse; //Field offset: 0x8
	internal static readonly object Int32_M1; //Field offset: 0x10
	internal static readonly object Int32_0; //Field offset: 0x18
	internal static readonly object Int32_1; //Field offset: 0x20
	internal static readonly object Int32_2; //Field offset: 0x28
	internal static readonly object Int32_3; //Field offset: 0x30
	internal static readonly object Int32_4; //Field offset: 0x38
	internal static readonly object Int32_5; //Field offset: 0x40
	internal static readonly object Int32_6; //Field offset: 0x48
	internal static readonly object Int32_7; //Field offset: 0x50
	internal static readonly object Int32_8; //Field offset: 0x58
	internal static readonly object Int64_M1; //Field offset: 0x60
	internal static readonly object Int64_0; //Field offset: 0x68
	internal static readonly object Int64_1; //Field offset: 0x70
	internal static readonly object Int64_2; //Field offset: 0x78
	internal static readonly object Int64_3; //Field offset: 0x80
	internal static readonly object Int64_4; //Field offset: 0x88
	internal static readonly object Int64_5; //Field offset: 0x90
	internal static readonly object Int64_6; //Field offset: 0x98
	internal static readonly object Int64_7; //Field offset: 0xA0
	internal static readonly object Int64_8; //Field offset: 0xA8
	private static readonly object DecimalZero; //Field offset: 0xB0
	internal static readonly object DoubleNaN; //Field offset: 0xB8
	internal static readonly object DoublePositiveInfinity; //Field offset: 0xC0
	internal static readonly object DoubleNegativeInfinity; //Field offset: 0xC8
	internal static readonly object DoubleZero; //Field offset: 0xD0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 27)]
	private static BoxedPrimitives() { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(System.Nullable`1<System.Boolean>))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static object Get(bool value) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsInvalidInstructions]
	internal static object Get(int value) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsInvalidInstructions]
	internal static object Get(long value) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	internal static object Get(decimal value) { }

	[CalledBy(Type = typeof(JsonTextReader), Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadType), typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static object Get(double value) { }

}

