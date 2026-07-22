namespace System.Xml.Schema;

internal class XmlAnyListConverter : XmlListConverter
{
	public static readonly XmlValueConverter ItemList; //Field offset: 0x0
	public static readonly XmlValueConverter AnyAtomicList; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static XmlAnyListConverter() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlAnyListConverter(XmlBaseConverter atomicConverter) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

