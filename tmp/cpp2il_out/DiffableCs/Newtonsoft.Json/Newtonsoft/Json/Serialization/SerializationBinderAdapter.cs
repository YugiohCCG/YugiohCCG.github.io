namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class SerializationBinderAdapter : ISerializationBinder
{
	public readonly SerializationBinder SerializationBinder; //Field offset: 0x10

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public SerializationBinderAdapter(SerializationBinder serializationBinder) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[NullableContext(2)]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override Type BindToType(string assemblyName, string typeName) { }

}

