namespace System.Xml.Serialization;

public class XmlSerializerFactory
{
	private static Hashtable serializersBySource; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static XmlSerializerFactory() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSerializerFactory() { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(XmlSerializer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializerFactory), Member = "CreateSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlAttributeOverrides), typeof(Type[]), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlSerializer))]
	public XmlSerializer CreateSerializer(Type type) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "GetXmlSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute)}, ReturnType = typeof(XmlSerializer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializerFactory), Member = "CreateSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlAttributeOverrides), typeof(Type[]), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlSerializer))]
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	[CalledBy(Type = typeof(XmlSerializerFactory), Member = "CreateSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(XmlSerializer))]
	[CalledBy(Type = typeof(XmlSerializerFactory), Member = "CreateSerializer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute)}, ReturnType = typeof(XmlSerializer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTypeSerializationSource), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(XmlAttributeOverrides), typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReflectionImporter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeOverrides), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReflectionImporter), Member = "IncludeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReflectionImporter), Member = "ImportTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

}

