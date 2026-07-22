namespace System.Reflection;

public abstract class MemberInfo : ICustomAttributeProvider
{

	public override IEnumerable<CustomAttributeData> CustomAttributes
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public abstract Type DeclaringType
	{
		 get { } //Length: 0
	}

	public abstract MemberTypes MemberType
	{
		 get { } //Length: 0
	}

	public override int MetadataToken
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public override Module Module
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 175
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract Type ReflectedType
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MemberInfo() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerable<CustomAttributeData> get_CustomAttributes() { }

	public abstract Type get_DeclaringType() { }

	public abstract MemberTypes get_MemberType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override int get_MetadataToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Module get_Module() { }

	public abstract string get_Name() { }

	public abstract Type get_ReflectedType() { }

	public abstract Object[] GetCustomAttributes(bool inherit) { }

	public abstract Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "TryGetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(String&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "HasBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "TryGetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), "Unity.Burst.BurstCompileAttribute&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetIsSpecifiedActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "CheckOptionalValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RecordFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(MemberInfo), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FormatterServices), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MemberInfo[])}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(FormatterServices), Member = "PopulateObjectMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MemberInfo[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "CheckOptionalValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "GetValueSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillEventInfoAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillSingleMethodAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateObjectContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Newtonsoft.Json.Serialization.JsonObjectContract")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetPropertySettingsFromAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", typeof(object), typeof(string), typeof(Type), "Newtonsoft.Json.MemberSerialization", typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonTypeReflector", Member = "GetAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

}

