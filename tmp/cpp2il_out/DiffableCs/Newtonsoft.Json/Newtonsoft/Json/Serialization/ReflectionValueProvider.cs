namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ReflectionValueProvider : IValueProvider
{
	private readonly MemberInfo _memberInfo; //Field offset: 0x10

	[CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateMemberValueProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(IValueProvider))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ReflectionValueProvider(MemberInfo memberInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public override object GetValue(object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public override void SetValue(object target, object value) { }

}

