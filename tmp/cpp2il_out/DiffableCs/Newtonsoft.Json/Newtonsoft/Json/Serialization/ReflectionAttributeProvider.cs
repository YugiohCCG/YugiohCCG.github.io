namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ReflectionAttributeProvider : IAttributeProvider
{
	private readonly object _attributeProvider; //Field offset: 0x10

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonProperty), typeof(ParameterInfo)}, ReturnType = typeof(JsonProperty))]
	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberSerialization)}, ReturnType = typeof(JsonProperty))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReflectionAttributeProvider(object attributeProvider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	public override IList<Attribute> GetAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	public override IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }

}

