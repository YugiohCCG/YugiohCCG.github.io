namespace System.Xml.Linq;

internal struct NamespaceResolver
{
	private class NamespaceDeclaration
	{
		public string prefix; //Field offset: 0x10
		public XNamespace ns; //Field offset: 0x18
		public int scope; //Field offset: 0x20
		public NamespaceDeclaration prev; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NamespaceDeclaration() { }

	}

	private int _scope; //Field offset: 0x0
	private NamespaceDeclaration _declaration; //Field offset: 0x8
	private NamespaceDeclaration _rover; //Field offset: 0x10

	[CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Add(string prefix, XNamespace ns) { }

	[CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void AddFirst(string prefix, XNamespace ns) { }

	[CalledBy(Type = typeof(ElementWriter), Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNamespace), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	[CalledBy(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void PopScope() { }

	[CallerCount(Count = 0)]
	public void PushScope() { }

}

