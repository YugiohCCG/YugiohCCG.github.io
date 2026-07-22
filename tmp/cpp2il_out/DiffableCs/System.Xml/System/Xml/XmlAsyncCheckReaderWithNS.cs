namespace System.Xml;

internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAsyncCheckReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public XmlAsyncCheckReaderWithNS(XmlReader reader) { }

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

