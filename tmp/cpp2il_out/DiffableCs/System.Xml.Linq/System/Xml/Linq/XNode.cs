namespace System.Xml.Linq;

public abstract class XNode : XObject
{
	internal XNode next; //Field offset: 0x20

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XNode() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void AppendText(StringBuilder sb) { }

	internal abstract XNode CloneNode() { }

	[CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_OmitXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_Indent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_NamespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriterSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(XContainer), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private string GetXmlString(SaveOptions o) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", typeof(Type), typeof(object), "Newtonsoft.Json.JsonSerializer"}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void Remove() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "GetSaveOptionsFromAnnotations", ReturnType = typeof(SaveOptions))]
	[Calls(Type = typeof(XNode), Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SaveOptions)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	public abstract void WriteTo(XmlWriter writer) { }

}

