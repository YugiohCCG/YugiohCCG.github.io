namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class JsonPrimitiveContract : JsonContract
{
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; //Field offset: 0x0
	[CompilerGenerated]
	private PrimitiveTypeCode <TypeCode>k__BackingField; //Field offset: 0x90

	internal PrimitiveTypeCode TypeCode
	{
		[CallerCount(Count = 33)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static JsonPrimitiveContract() { }

	[CalledBy(Type = typeof(JsonStringContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(PrimitiveTypeCode))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public JsonPrimitiveContract(Type underlyingType) { }

	[CallerCount(Count = 33)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal PrimitiveTypeCode get_TypeCode() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_TypeCode(PrimitiveTypeCode value) { }

}

