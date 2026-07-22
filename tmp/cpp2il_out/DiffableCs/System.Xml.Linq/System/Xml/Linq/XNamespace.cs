namespace System.Xml.Linq;

public sealed class XNamespace
{
	private static XHashtable<WeakReference> s_namespaces; //Field offset: 0x0
	private static WeakReference s_refNone; //Field offset: 0x8
	private static WeakReference s_refXml; //Field offset: 0x10
	private static WeakReference s_refXmlns; //Field offset: 0x18
	private string _namespaceName; //Field offset: 0x10
	private int _hashCode; //Field offset: 0x18
	private XHashtable<XName> _names; //Field offset: 0x20

	public string NamespaceName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static XNamespace None
	{
		[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		 get { } //Length: 79
	}

	public static XNamespace Xml
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		 get { } //Length: 81
	}

	public static XNamespace Xmlns
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
		 get { } //Length: 81
	}

	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XHashtable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XHashtable`1<TValue>+ExtractKeyDelegate<TValue>", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal XNamespace(string namespaceName) { }

	[CalledBy(Type = typeof(XNamespace), Member = "get_None", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "get_Xml", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "get_Xmlns", ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static string ExtractLocalName(XName n) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string ExtractNamespace(WeakReference r) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static XNamespace Get(string namespaceName) { }

	[CalledBy(Type = "System.Xml.Linq.XContainer+ContentReader", Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NamespaceCache), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[CalledBy(Type = typeof(XNamespace), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XNamespace))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XHashtable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Linq.XHashtable`1<TValue>+ExtractKeyDelegate<TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_NamespaceName() { }

	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	public static XNamespace get_None() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	public static XNamespace get_Xml() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = typeof(XNamespace))]
	public static XNamespace get_Xmlns() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public XName GetName(string localName) { }

	[CalledBy(Type = "System.Xml.Linq.XContainer+ContentReader", Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XName))]
	[CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XHashtable`1), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XHashtable`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	internal XName GetName(string localName, int index, int count) { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "HasImplicitNamespaceAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "GetPrefixOfNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
	[CLSCompliant(False)]
	public static XNamespace op_Implicit(string namespaceName) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

