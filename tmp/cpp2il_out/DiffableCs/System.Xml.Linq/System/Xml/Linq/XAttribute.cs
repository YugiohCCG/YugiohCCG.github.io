namespace System.Xml.Linq;

public class XAttribute : XObject
{
	internal XAttribute next; //Field offset: 0x20
	internal XName name; //Field offset: 0x28
	internal string value; //Field offset: 0x30

	public bool IsNamespaceDeclaration
	{
		[CalledBy(Type = typeof(XElement), Member = "GetNamespaceOfPrefixInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XElement)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 131
	}

	public XName Name
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public string Value
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 298
	}

	[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_Attributes", ReturnType = "System.Collections.Generic.List`1<IXmlNode>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XContainer), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public XAttribute(XName name, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public XAttribute(XAttribute other) { }

	[CalledBy(Type = typeof(XElement), Member = "GetNamespaceOfPrefixInScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XElement)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsNamespaceDeclaration() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public XName get_Name() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_Value(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XContainer+ContentReader", Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 30)]
	private static void ValidateAttribute(XName name, string value) { }

}

