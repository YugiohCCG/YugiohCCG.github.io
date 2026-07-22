namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class DefaultReferenceResolver : IReferenceResolver
{
	private int _referenceCount; //Field offset: 0x10

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultReferenceResolver() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void AddReference(object context, string reference, object value) { }

	[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "ResolveReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "AddReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultReferenceResolver), Member = "IsReferenced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JsonSerializerProxy), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerInternalBase))]
	[Calls(Type = typeof(JsonSerializerInternalBase), Member = "get_DefaultReferenceMappings", ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private BidirectionalDictionary<String, Object> GetMappings(object context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = "TryGetBySecond", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSecond", "TFirst&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override string GetReference(object context, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = "TryGetBySecond", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSecond", "TFirst&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsReferenced(object context, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Newtonsoft.Json.Utilities.BidirectionalDictionary`2<System.String, System.Object>))]
	[Calls(Type = typeof(BidirectionalDictionary`2), Member = "TryGetByFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override object ResolveReference(object context, string reference) { }

}

