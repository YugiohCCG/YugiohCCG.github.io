//Type is in global namespace

internal static class SR
{

	[CalledBy(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XContainer+ContentReader", Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XDocument), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XProcessingInstruction), Member = "ValidateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1) { }

	[CalledBy(Type = typeof(XElement), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	internal static string Format(string resourceFormat, object p1, object p2) { }

}

