namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x28

	[CalledBy(Type = typeof(XmlAsyncCheckReader), Member = "CreateAsyncCheckWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(XmlAsyncCheckReader))]
	[CalledBy(Type = typeof(XmlAsyncCheckReaderWithLineInfoNSSchema), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

