namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(2)]
internal class FSharpFunction
{
	private readonly object _instance; //Field offset: 0x10
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1})]
	private readonly MethodCall<Object, Object> _invoker; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public FSharpFunction(object instance, MethodCall<Object, Object> invoker) { }

	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "WriteJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonWriter), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(1)]
	public object Invoke(Object[] args) { }

}

