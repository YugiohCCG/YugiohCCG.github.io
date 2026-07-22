namespace System.Xml.Linq;

internal struct NamespaceCache
{
	private XNamespace _ns; //Field offset: 0x0
	private string _namespaceName; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public XNamespace Get(string namespaceName) { }

}

