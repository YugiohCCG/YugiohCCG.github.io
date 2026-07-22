namespace Newtonsoft.Json.Serialization;

public class JsonISerializableContract : JsonContainerContract
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private ObjectConstructor<Object> <ISerializableCreator>k__BackingField; //Field offset: 0xC0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public ObjectConstructor<Object> ISerializableCreator
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[NullableContext(1)]
	public JsonISerializableContract(Type underlyingType) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ObjectConstructor<Object> get_ISerializableCreator() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ISerializableCreator(ObjectConstructor<Object> value) { }

}

