namespace System.Xml;

internal class XmlUnspecifiedAttribute : XmlAttribute
{
	private bool fSpecified; //Field offset: 0x28

	public virtual string InnerText
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 set { } //Length: 27
	}

	public virtual bool Specified
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlDocument), Member = "CreateDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlDocument)}, ReturnType = typeof(void))]
	protected private XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public virtual XmlNode CloneNode(bool deep) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual bool get_Specified() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public virtual void set_InnerText(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void SetSpecified(bool f) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	public virtual void WriteTo(XmlWriter w) { }

}

